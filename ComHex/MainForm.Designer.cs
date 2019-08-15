namespace ComHex
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPortName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxConnectButton = new System.Windows.Forms.CheckBox();
            this.imageListCheckButton = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageConnectionSettings = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageConsole = new System.Windows.Forms.TabPage();
            this.textBoxSerialMonitor = new System.Windows.Forms.TextBox();
            this.checkBoxControllerDebug = new System.Windows.Forms.CheckBox();
            this.textBoxCommandText = new System.Windows.Forms.TextBox();
            this.buttonTestSend = new System.Windows.Forms.Button();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxAboutInfo = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.serialPortMain = new System.IO.Ports.SerialPort(this.components);
            this.timerKeyObserver = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageConnectionSettings.SuspendLayout();
            this.tabPageConsole.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.contextMenuStripNotify.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // comboBoxPortName
            // 
            this.comboBoxPortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPortName.FormattingEnabled = true;
            this.comboBoxPortName.Location = new System.Drawing.Point(79, 25);
            this.comboBoxPortName.Name = "comboBoxPortName";
            this.comboBoxPortName.Size = new System.Drawing.Size(215, 20);
            this.comboBoxPortName.TabIndex = 0;
            this.comboBoxPortName.DropDown += new System.EventHandler(this.comboBoxPortName_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxConnectButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxPortName);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入力側";
            // 
            // checkBoxConnectButton
            // 
            this.checkBoxConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxConnectButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxConnectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxConnectButton.ImageIndex = 0;
            this.checkBoxConnectButton.ImageList = this.imageListCheckButton;
            this.checkBoxConnectButton.Location = new System.Drawing.Point(300, 25);
            this.checkBoxConnectButton.Name = "checkBoxConnectButton";
            this.checkBoxConnectButton.Padding = new System.Windows.Forms.Padding(4);
            this.checkBoxConnectButton.Size = new System.Drawing.Size(132, 46);
            this.checkBoxConnectButton.TabIndex = 2;
            this.checkBoxConnectButton.Text = "接続";
            this.checkBoxConnectButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxConnectButton.UseVisualStyleBackColor = true;
            this.checkBoxConnectButton.CheckedChanged += new System.EventHandler(this.checkBoxConnectButton_CheckedChanged);
            // 
            // imageListCheckButton
            // 
            this.imageListCheckButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCheckButton.ImageStream")));
            this.imageListCheckButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCheckButton.Images.SetKeyName(0, "btn_unchecked.png");
            this.imageListCheckButton.Images.SetKeyName(1, "btn_checked.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud rate";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "28800",
            "19200",
            "14400",
            "9600"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(79, 51);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(215, 20);
            this.comboBoxBaudRate.TabIndex = 1;
            this.comboBoxBaudRate.Text = "115200";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageConnectionSettings);
            this.tabControlMain.Controls.Add(this.tabPageConsole);
            this.tabControlMain.Controls.Add(this.tabPageAbout);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(462, 394);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageConnectionSettings
            // 
            this.tabPageConnectionSettings.Controls.Add(this.button16);
            this.tabPageConnectionSettings.Controls.Add(this.button20);
            this.tabPageConnectionSettings.Controls.Add(this.button12);
            this.tabPageConnectionSettings.Controls.Add(this.button8);
            this.tabPageConnectionSettings.Controls.Add(this.button19);
            this.tabPageConnectionSettings.Controls.Add(this.button4);
            this.tabPageConnectionSettings.Controls.Add(this.button15);
            this.tabPageConnectionSettings.Controls.Add(this.button11);
            this.tabPageConnectionSettings.Controls.Add(this.button7);
            this.tabPageConnectionSettings.Controls.Add(this.button18);
            this.tabPageConnectionSettings.Controls.Add(this.button3);
            this.tabPageConnectionSettings.Controls.Add(this.button14);
            this.tabPageConnectionSettings.Controls.Add(this.button10);
            this.tabPageConnectionSettings.Controls.Add(this.button6);
            this.tabPageConnectionSettings.Controls.Add(this.button17);
            this.tabPageConnectionSettings.Controls.Add(this.button2);
            this.tabPageConnectionSettings.Controls.Add(this.button13);
            this.tabPageConnectionSettings.Controls.Add(this.button9);
            this.tabPageConnectionSettings.Controls.Add(this.button5);
            this.tabPageConnectionSettings.Controls.Add(this.button1);
            this.tabPageConnectionSettings.Controls.Add(this.groupBox1);
            this.tabPageConnectionSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnectionSettings.Name = "tabPageConnectionSettings";
            this.tabPageConnectionSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnectionSettings.Size = new System.Drawing.Size(454, 368);
            this.tabPageConnectionSettings.TabIndex = 0;
            this.tabPageConnectionSettings.Text = "基本";
            this.tabPageConnectionSettings.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.ImageIndex = 0;
            this.button16.Location = new System.Drawing.Point(8, 277);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 48);
            this.button16.TabIndex = 15;
            this.button16.Text = "15";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.ImageIndex = 0;
            this.button20.Location = new System.Drawing.Point(97, 277);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(83, 48);
            this.button20.TabIndex = 16;
            this.button20.Text = "16";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.ImageIndex = 0;
            this.button12.Location = new System.Drawing.Point(97, 223);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(83, 48);
            this.button12.TabIndex = 11;
            this.button12.Text = "11";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.ImageIndex = 0;
            this.button8.Location = new System.Drawing.Point(186, 169);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 48);
            this.button8.TabIndex = 7;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.ImageIndex = 0;
            this.button19.Location = new System.Drawing.Point(364, 277);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(83, 48);
            this.button19.TabIndex = 19;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 0;
            this.button4.Location = new System.Drawing.Point(275, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.ImageIndex = 0;
            this.button15.Location = new System.Drawing.Point(364, 223);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(83, 48);
            this.button15.TabIndex = 14;
            this.button15.Text = "14";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.ImageIndex = 0;
            this.button11.Location = new System.Drawing.Point(8, 223);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(83, 48);
            this.button11.TabIndex = 10;
            this.button11.Text = "10";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageIndex = 0;
            this.button7.Location = new System.Drawing.Point(97, 169);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.ImageIndex = 0;
            this.button18.Location = new System.Drawing.Point(275, 277);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(83, 48);
            this.button18.TabIndex = 18;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 0;
            this.button3.Location = new System.Drawing.Point(186, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.ImageIndex = 0;
            this.button14.Location = new System.Drawing.Point(275, 223);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(83, 48);
            this.button14.TabIndex = 13;
            this.button14.Text = "13";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.ImageIndex = 0;
            this.button10.Location = new System.Drawing.Point(364, 169);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(83, 48);
            this.button10.TabIndex = 9;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 0;
            this.button6.Location = new System.Drawing.Point(8, 169);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.ImageIndex = 0;
            this.button17.Location = new System.Drawing.Point(186, 277);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(83, 48);
            this.button17.TabIndex = 17;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.Location = new System.Drawing.Point(97, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.ImageIndex = 0;
            this.button13.Location = new System.Drawing.Point(186, 223);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(83, 48);
            this.button13.TabIndex = 12;
            this.button13.Text = "12";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.ImageIndex = 0;
            this.button9.Location = new System.Drawing.Point(275, 169);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 48);
            this.button9.TabIndex = 8;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 0;
            this.button5.Location = new System.Drawing.Point(364, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 48);
            this.button5.TabIndex = 20;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.Location = new System.Drawing.Point(8, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // tabPageConsole
            // 
            this.tabPageConsole.Controls.Add(this.textBoxSerialMonitor);
            this.tabPageConsole.Controls.Add(this.checkBoxControllerDebug);
            this.tabPageConsole.Controls.Add(this.textBoxCommandText);
            this.tabPageConsole.Controls.Add(this.buttonTestSend);
            this.tabPageConsole.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsole.Name = "tabPageConsole";
            this.tabPageConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsole.Size = new System.Drawing.Size(454, 368);
            this.tabPageConsole.TabIndex = 3;
            this.tabPageConsole.Text = "コンソール";
            this.tabPageConsole.UseVisualStyleBackColor = true;
            // 
            // textBoxSerialMonitor
            // 
            this.textBoxSerialMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerialMonitor.Font = new System.Drawing.Font("ＭＳ ゴシック", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSerialMonitor.Location = new System.Drawing.Point(7, 50);
            this.textBoxSerialMonitor.Multiline = true;
            this.textBoxSerialMonitor.Name = "textBoxSerialMonitor";
            this.textBoxSerialMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSerialMonitor.Size = new System.Drawing.Size(440, 154);
            this.textBoxSerialMonitor.TabIndex = 26;
            // 
            // checkBoxControllerDebug
            // 
            this.checkBoxControllerDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxControllerDebug.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxControllerDebug.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxControllerDebug.Checked = true;
            this.checkBoxControllerDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxControllerDebug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxControllerDebug.ImageIndex = 1;
            this.checkBoxControllerDebug.ImageList = this.imageListCheckButton;
            this.checkBoxControllerDebug.Location = new System.Drawing.Point(6, 6);
            this.checkBoxControllerDebug.Name = "checkBoxControllerDebug";
            this.checkBoxControllerDebug.Padding = new System.Windows.Forms.Padding(4);
            this.checkBoxControllerDebug.Size = new System.Drawing.Size(445, 38);
            this.checkBoxControllerDebug.TabIndex = 25;
            this.checkBoxControllerDebug.Text = "受信結果表示";
            this.checkBoxControllerDebug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxControllerDebug.UseVisualStyleBackColor = false;
            this.checkBoxControllerDebug.CheckedChanged += new System.EventHandler(this.checkBoxControllerDebug_CheckedChanged);
            // 
            // textBoxCommandText
            // 
            this.textBoxCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCommandText.Font = new System.Drawing.Font("ＭＳ ゴシック", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxCommandText.Location = new System.Drawing.Point(8, 210);
            this.textBoxCommandText.Multiline = true;
            this.textBoxCommandText.Name = "textBoxCommandText";
            this.textBoxCommandText.Size = new System.Drawing.Size(438, 101);
            this.textBoxCommandText.TabIndex = 22;
            // 
            // buttonTestSend
            // 
            this.buttonTestSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestSend.Location = new System.Drawing.Point(369, 317);
            this.buttonTestSend.Name = "buttonTestSend";
            this.buttonTestSend.Size = new System.Drawing.Size(82, 26);
            this.buttonTestSend.TabIndex = 21;
            this.buttonTestSend.Text = "送信";
            this.buttonTestSend.UseVisualStyleBackColor = true;
            this.buttonTestSend.Click += new System.EventHandler(this.ButtonTestSend_Click);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelProductName);
            this.tabPageAbout.Controls.Add(this.labelVersion);
            this.tabPageAbout.Controls.Add(this.labelCopyright);
            this.tabPageAbout.Controls.Add(this.labelDescription);
            this.tabPageAbout.Controls.Add(this.labelCompanyName);
            this.tabPageAbout.Controls.Add(this.textBoxAboutInfo);
            this.tabPageAbout.Controls.Add(this.pictureBoxLogo);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(454, 368);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "情報";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(135, 12);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelProductName.MinimumSize = new System.Drawing.Size(40, 16);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(41, 16);
            this.labelProductName.TabIndex = 24;
            this.labelProductName.Text = "製品名";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(135, 38);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelVersion.MinimumSize = new System.Drawing.Size(40, 16);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(50, 16);
            this.labelVersion.TabIndex = 23;
            this.labelVersion.Text = "バージョン";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(310, 11);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelCopyright.MinimumSize = new System.Drawing.Size(40, 16);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(41, 16);
            this.labelCopyright.TabIndex = 25;
            this.labelCopyright.Text = "著作権";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCopyright.Visible = false;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(135, 90);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelDescription.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelDescription.MinimumSize = new System.Drawing.Size(40, 16);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(40, 16);
            this.labelDescription.TabIndex = 26;
            this.labelDescription.Text = "説明";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(135, 64);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelCompanyName.MinimumSize = new System.Drawing.Size(40, 16);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(41, 16);
            this.labelCompanyName.TabIndex = 26;
            this.labelCompanyName.Text = "会社名";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAboutInfo
            // 
            this.textBoxAboutInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAboutInfo.Location = new System.Drawing.Point(8, 116);
            this.textBoxAboutInfo.Multiline = true;
            this.textBoxAboutInfo.Name = "textBoxAboutInfo";
            this.textBoxAboutInfo.ReadOnly = true;
            this.textBoxAboutInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAboutInfo.Size = new System.Drawing.Size(442, 0);
            this.textBoxAboutInfo.TabIndex = 7;
            this.textBoxAboutInfo.Text = "使い方\r\n\r\nマイコンに合わせたCOMポートを指定して「接続」すると、動作を開始します。\r\n";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(8, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(113, 30);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // serialPortMain
            // 
            this.serialPortMain.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortMain_DataReceived);
            // 
            // timerKeyObserver
            // 
            this.timerKeyObserver.Enabled = true;
            this.timerKeyObserver.Tick += new System.EventHandler(this.timerKeyObserver_Tick);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripSeparator1,
            this.toolStripMenuItemQuit});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            this.contextMenuStripNotify.Size = new System.Drawing.Size(122, 54);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemOpen.Text = "開く(&O)";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // toolStripMenuItemQuit
            // 
            this.toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            this.toolStripMenuItemQuit.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemQuit.Text = "終了 (&X)";
            this.toolStripMenuItemQuit.Click += new System.EventHandler(this.toolStripMenuItemQuit_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStripMain.Location = new System.Drawing.Point(0, 372);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(462, 22);
            this.statusStripMain.TabIndex = 5;
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(447, 17);
            this.toolStripStatusLabelMessage.Spring = true;
            this.toolStripStatusLabelMessage.Text = "Ready";
            this.toolStripStatusLabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonTestSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 394);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Text = "COM HEX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageConnectionSettings.ResumeLayout(false);
            this.tabPageConsole.ResumeLayout(false);
            this.tabPageConsole.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.contextMenuStripNotify.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPortName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageConnectionSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.IO.Ports.SerialPort serialPortMain;
        private System.Windows.Forms.CheckBox checkBoxConnectButton;
        private System.Windows.Forms.Timer timerKeyObserver;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuit;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.TextBox textBoxAboutInfo;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ImageList imageListCheckButton;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TabPage tabPageConsole;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Button buttonTestSend;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox textBoxCommandText;
        private System.Windows.Forms.TextBox textBoxSerialMonitor;
        private System.Windows.Forms.CheckBox checkBoxControllerDebug;
    }
}

