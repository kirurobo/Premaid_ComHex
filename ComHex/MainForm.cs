using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace ComHex
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 細かい時間を測るためのStopwatch
        /// </summary>
        Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// 受信データバッファ
        /// 初期サイズは適当
        /// </summary>
        Queue<byte> receivedData = new Queue<byte>(2048);

        /// <summary>
        /// 最後に受信した時刻 [ms]
        /// </summary>
        long lastReceivedTime = 0;

        /// <summary>
        /// 現在の電源電圧 [V]
        /// </summary>
        double currentVoltage = 10.0;

        /// <summary>
        /// 警告を出す電圧下限 [V]
        /// </summary>
        readonly double voltageThreshold = 9.0;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Initialize();    // 独自部分の初期化
        }

        /// <summary>
        /// 操作のメインロジック。一定間隔で繰り返し実行される。
        /// </summary>
        private void UpdateProcess()
        {
            InterpretReceivedData();
        }

        /// <summary>
        /// マイコンに現在の指令値を送信
        /// </summary>
        private void SendPresetPoseCommand(int no)
        {
            if (!serialPortMain.IsOpen) return;

            if (currentVoltage < voltageThreshold)
            {
                ShowMessage(string.Format("バッテリー電圧 {0:0.00}[V]", currentVoltage));
                SendBatteryCheckCommand();  // 再度バッテリー電圧チェック

                MessageBox.Show("バッテリー電圧が低下しています\nロボットの電源を切り、充電してください！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] buff = new byte[5];

            // https://twitter.com/GOROman/status/1144565121630404609
            buff[0] = 0x05;
            buff[1] = 0x1F;
            buff[2] = 0x00;
            buff[3] = (byte)(0x3D + no);
            buff[4] = GetCheckXor(buff);

            serialPortMain.Write(buff, 0, buff.Length);

            ShowMessage(string.Format("Preset {0}", no));     // デバッグ用。出力の確認
            Application.DoEvents();

            Thread.Sleep(200);
            SendBatteryCheckCommand();  // バッテリー電圧チェックもセットで行う
        }

        /// <summary>
        /// バッテリー電圧照会コマンド発行
        /// </summary>
        private void SendBatteryCheckCommand()
        {
            if (!serialPortMain.IsOpen) return;

            byte[] buff = new byte[7];

            buff[0] = 0x07;
            buff[1] = 0x01;
            buff[2] = 0x00;
            buff[3] = 0x02;
            buff[4] = 0x00;
            buff[5] = 0x02;
            buff[6] = GetCheckXor(buff);

            serialPortMain.Write(buff, 0, buff.Length);
        }

        /// <summary>
        /// 文字列を改行つきでシリアル送信
        /// </summary>
        /// <param name="text"></param>
        /// <returns>送信失敗ならfalse</returns>
        private bool SendText(string text)
        {
            if (!serialPortMain.IsOpen) return false;

            serialPortMain.WriteLine(text);

            ShowMessage(string.Format("送信 {0}", text));
            return true;
        }

        /// <summary>
        /// テキスト内容を16進数と解釈してシリアル送信
        /// </summary>
        /// <param name="text"></param>
        /// <returns>送信失敗ならfalse</returns>
        private bool SendHex(string text)
        {
            if (!serialPortMain.IsOpen) return false;

            string[] lines = text.Split('\r', '\n');

            for (int j = 0; j < lines.Length; j++)
            {
                var record = lines[j];
                if (string.IsNullOrWhiteSpace(record)) continue;

                // 空白やコンマ等はバイト区切りと見做す
                string[] values = record.Split(' ', ',', ':', ';', '\t');

                List<byte> buff = new List<byte>();
                string message = "";

                foreach (string val in values)
                {
                    for (int i = 0; i < val.Length; i += 2)
                    {
                        string hex = val.Substring(i, (val.Length - i >= 2 ? 2 : 1));

                        try
                        {
                            byte b = Convert.ToByte(hex, 16);
                            buff.Add(b);
                            message += hex + " ";
                        }
                        catch
                        {
                            ShowMessage(string.Format("16進数でない部分があります {0}", message));
                            return false;
                        }
                    }
                }
                serialPortMain.Write(buff.ToArray(), 0, buff.Count);
                ShowMessage(string.Format("送信 {0}", message));
                Application.DoEvents();
                Thread.Sleep(100);  // 1行ごとに待ち時間[ms]を入れる
            }

            return true;
        }

        /// <summary>
        /// XORによるチェック用1バイトを求める
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        private byte GetCheckXor(byte[] buffer)
        {
            byte xor = 0;
            for (int i = 0; i < buffer.Length - 1; i++)
            {
                xor ^= buffer[i];
            }
            return xor;
        }

        /// <summary>
        /// シリアルポートに接続
        /// </summary>
        /// <returns></returns>
        private bool Connect()
        {
            Disconnect();

            int baudrate;
            if (!int.TryParse(comboBoxBaudRate.Text, out baudrate))
            {
                ShowMessage("Baud rate が正しくありません");
                return false;
            }
            if (comboBoxPortName.Text == "")
            {
                ShowMessage("COMポートを指定して下さい");
                return false;
            }

            serialPortMain.PortName = comboBoxPortName.Text;
            serialPortMain.BaudRate = baudrate;
            serialPortMain.Parity = Parity.None;
            serialPortMain.StopBits = StopBits.One;
            serialPortMain.DataBits = 8;
            serialPortMain.Handshake = Handshake.None;
            serialPortMain.RtsEnable = true;
            serialPortMain.DtrEnable = true;

            bool retValue = false;
            try
            {
                ShowMessage("接続中...");
                Application.DoEvents();
                serialPortMain.Open();
                ShowMessage(serialPortMain.PortName + "に接続しました");

                retValue = true;
            }
            catch (Exception ex)
            {
                ShowMessage(serialPortMain.PortName + "に接続できません");
                retValue = false;
            }

            return retValue;
        }

        /// <summary>
        /// シリアルポートを切断
        /// </summary>
        /// <returns></returns>
        private bool Disconnect()
        {
            if (serialPortMain.IsOpen)
            {
                serialPortMain.Close();
                ShowMessage("切断しました");
            }
            return true;
        }

        /// <summary>
        /// シリアルからの入力を受け取る
        /// </summary>
        /// <returns></returns>
        private bool ReceiveSerial()
        {
            if (!serialPortMain.IsOpen) return false;

            bool received = false;

            try
            {
                while (serialPortMain.BytesToRead > 0)
                {
                    int b = serialPortMain.ReadByte();
                    if (b < 0) break;

                    this.Invoke(new SerialPortDelegate(
                        delegate {
                            receivedData.Enqueue((byte)b);
                        }
                        ));

                    char c = Convert.ToChar(b);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Receive:" + ex.Message);
            }

            // 何か受信があれば
            if (received)
            {
                // 最終受信時刻を更新
                this.Invoke(new SerialPortDelegate(
                    delegate {
                        lastReceivedTime = stopwatch.ElapsedMilliseconds;
                    }
                    ));
            }

            return false;
        }

        delegate void SerialPortDelegate();


        /// <summary>
        /// 受信データの解釈
        /// </summary>
        private void InterpretReceivedData()
        {
            const long timeout = 10000;  // 前回受信からこれ[ms]以上時間がたっていれば一旦全データ破棄
            if ((lastReceivedTime + timeout) < stopwatch.ElapsedMilliseconds)
            {
                lastReceivedTime = stopwatch.ElapsedMilliseconds;
                receivedData.Clear();
                //ShowMessage(string.Format("受信タイムアウト {0}[ms]", lastReceivedTime));

                SendBatteryCheckCommand();  // 定期的にバッテリー電圧チェック
                return;
            }

            // 受信データが溜まっていなければ何もしない
            if (receivedData.Count < 1) return;

            byte len = receivedData.First();

            // まだ指定バイト数まで未受信なら何もしない
            if (receivedData.Count < len) return;

            // テキストボックスに出力するか
            bool display = checkBoxControllerDebug.Checked;

            byte xor = 0;
            byte[] data = new byte[len];
            for (int i = 0; i < len; i++)
            {
                byte b = receivedData.Dequeue();
                data[i] = b;
                xor ^= b;

                if (display)
                {
                    textBoxSerialMonitor.Text += b.ToString("X2") + " ";
                }
            }

            if (display)
            {
                if (xor != 0)
                {
                    textBoxSerialMonitor.Text += "XOR! ";
                }
                textBoxSerialMonitor.Text += Environment.NewLine;

                // 最後の行にスクロール
                textBoxSerialMonitor.SelectionStart = textBoxSerialMonitor.Text.Length;
                textBoxSerialMonitor.ScrollToCaret();
            }

            // XORチェックに失敗していたら応答として処理しない
            if (xor != 0) return;


            // 解釈

            // 電圧情報
            if (data[0] == 0x06 && data[1] == 0x01 && data[2] == 0x00)
            {
                currentVoltage = (data[4] * 256 + data[3]) / 216.7;
                if (currentVoltage < voltageThreshold)
                {
                    ShowMessage(string.Format("バッテリー電圧低下！ 充電してください！ {0:0.00}[V]", currentVoltage));
                } else
                {
                    ShowMessage(string.Format("バッテリー電圧 {0:0.00}[V]", currentVoltage));
                }
            }
            else if (data[0] == 0x04 && data[1] == 0x1F)
            {
                // モーション再生に対する応答
                if (data[2] == 0x00)
                {
                    //ShowMessage("モーション再生を受け付けました");
                }
                else if (data[2] == 0x08)
                {
                    ShowMessage("コマンド受付失敗");
                }
                else if (data[2] == 0x80)
                {
                    ShowMessage("モーション再生中は別のモーションは受け付けません");
                }
            }
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        private void Initialize()
        {
            // COMポートの選択肢を準備
            InitializeComPorts();

            // 情報読み込み
            this.Text = AssemblyTitle;
            this.labelProductName.Text += "：" + AssemblyProduct;
            this.labelVersion.Text += "：" + String.Format("Ver.{0}", AssemblyVersion);
            this.labelCopyright.Text += "：" + AssemblyCopyright;
            this.labelCompanyName.Text += "：" + AssemblyCompany;
            this.labelDescription.Text += "：" + AssemblyDescription;

            // 通知表示
            ShowMessage("");

            // ストップウォッチを開始s
            stopwatch.Start();
        }

        /// <summary>
        /// シリアルポートの選択肢を準備
        /// </summary>
        /// 参考 http://kana-soft.com/tech/sample_0007.htm
        private void InitializeComPorts()
        {
            // シリアルポートの選択肢を準備
            string[] portnames = SerialPort.GetPortNames();
            Regex reg = new Regex("COM[0-9]+");
            comboBoxPortName.Items.Clear();
            foreach (string name in portnames)
            {
                Match match = reg.Match(name);
                if (match.Success)
                {
                    comboBoxPortName.Items.Add(match.Value);
                }
            }
            if (comboBoxPortName.Text == "" && comboBoxPortName.Items.Count > 0)
            {
                comboBoxPortName.SelectedIndex = comboBoxPortName.Items.Count - 1;
            }
        }

        /// <summary>
        /// 設定画面をタスクトレイから復帰して表示
        /// </summary>
        private void ShowMainForm()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            this.Focus();   // フォーカスを得る
        }

        /// <summary>
        /// 通知メッセージを表示
        /// </summary>
        /// <param name="text"></param>
        private void ShowMessage(string text)
        {
            this.toolStripStatusLabelMessage.Text = text;
        }

        #region アセンブリ属性アクセサー

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        #region GUI関連メソッド
        /// <summary>
        /// 「接続」または「切断」ボタンが押されたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxConnectButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox)) return;

            CheckBox checkbox = checkBoxConnectButton;
            checkbox.Checked = ((CheckBox)sender).Checked;
            if (checkbox.Checked && Connect())
            {
                checkbox.Text = "接続済";
                checkbox.ImageIndex = 1;

                comboBoxPortName.Enabled = false;
                comboBoxBaudRate.Enabled = false;
            }
            else
            {
                // 切断処理
                Disconnect();
                checkbox.Text = "接続";
                checkbox.ImageIndex = 0;
                checkbox.Checked = false;

                comboBoxPortName.Enabled = true;
                comboBoxBaudRate.Enabled = true;
            }
        }

        /// <summary>
        /// ウィンドウが作成された際の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 定期監視用タイマーでの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerKeyObserver_Tick(object sender, EventArgs e)
        {
            UpdateProcess();
        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 設定画面を表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        /// <summary>
        /// タスクトレイのアイコンダブルクリック時の処理
        /// 設定画面を表示させる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowMainForm();
        }

        /// <summary>
        /// シリアル通信でデータ受信時に呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPortMain_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceiveSerial();
        }

        /// <summary>
        /// ウィンドウを閉じる際の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();       // シリアルポートは切断
        }

        /// <summary>
        /// シリアルポート一覧が開かれた時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxPortName_DropDown(object sender, EventArgs e)
        {
            // 現時点でのポート一覧を取得しなおす
            InitializeComPorts();
        }

        /// <summary>
        /// 受信内容表示モードON/OFF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxControllerDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox)) return;

            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked)
            {
                checkbox.ImageIndex = 1;
            }
            else
            {
                checkbox.ImageIndex = 0;
            }
        }

        /// <summary>
        /// プリセット動作ボタンが押された時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            if (!serialPortMain.IsOpen)
            {
                ShowMessage("先に接続してください");
                return;
            }

            if (sender is Button)
            {
                Button button = (Button)sender;

                // ボタン名文字列を数値として解釈
                int no;
                if (int.TryParse(button.Text, out no))
                {
                    SendPresetPoseCommand(no);
                }
            }
        }

        /// <summary>
        /// コマンド送信ボタンが押された時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTestSend_Click(object sender, EventArgs e)
        {
            // コンソールのタブが開かれていなければ、何もしない
            if (tabControlMain.SelectedTab != tabPageConsole)
            {
                return;
            }

            if (!serialPortMain.IsOpen)
            {
                ShowMessage("先に接続してください");
                return;
            }

            if (SendHex(textBoxCommandText.Text))
            {
                // 送信完了ならテキストボックスを消去
                textBoxCommandText.Text = "";
            }
        }
    }
    #endregion
}
