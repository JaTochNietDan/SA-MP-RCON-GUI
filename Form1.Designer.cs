namespace SA_MP_RCON_GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPlayers = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKick = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBan = new System.Windows.Forms.Button();
            this.lstRCON = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReloadLog = new System.Windows.Forms.Button();
            this.btnReloadBans = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGMX = new System.Windows.Forms.Button();
            this.btnReloadFS = new System.Windows.Forms.Button();
            this.btnUnloadFS = new System.Windows.Forms.Button();
            this.btnLoadFS = new System.Windows.Forms.Button();
            this.txtFilterscript = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSetGravity = new System.Windows.Forms.Button();
            this.txtGravity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUnbanIP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBanIP = new System.Windows.Forms.Button();
            this.txtBanIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChangemode = new System.Windows.Forms.Button();
            this.txtChangemode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMapname = new System.Windows.Forms.Button();
            this.txtMapname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGameText = new System.Windows.Forms.Button();
            this.txtGamemode = new System.Windows.Forms.TextBox();
            this.lstRCON2 = new System.Windows.Forms.ListBox();
            this.btnSetHost = new System.Windows.Forms.Button();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Items.AddRange(new object[] {
            "Players display here!"});
            this.lstPlayers.Location = new System.Drawing.Point(6, 6);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(216, 277);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // txtConnection
            // 
            this.txtConnection.Location = new System.Drawing.Point(228, 6);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(138, 20);
            this.txtConnection.TabIndex = 1;
            this.txtConnection.Text = "IP:PORT";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(228, 58);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(138, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Refresh Server";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(291, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(75, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(228, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(222, 139);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(44, 13);
            this.lblPlayers.TabIndex = 6;
            this.lblPlayers.Text = "Players:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(94, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtPlayers
            // 
            this.txtPlayers.Location = new System.Drawing.Point(266, 136);
            this.txtPlayers.Name = "txtPlayers";
            this.txtPlayers.Size = new System.Drawing.Size(94, 20);
            this.txtPlayers.TabIndex = 8;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(229, 165);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(37, 13);
            this.lblMode.TabIndex = 9;
            this.lblMode.Text = "Mode:";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(266, 162);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(94, 20);
            this.txtMode.TabIndex = 10;
            // 
            // txtMap
            // 
            this.txtMap.Location = new System.Drawing.Point(266, 188);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(94, 20);
            this.txtMap.TabIndex = 11;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(235, 191);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(31, 13);
            this.lblMap.TabIndex = 12;
            this.lblMap.Text = "Map:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "RCON Pass:";
            // 
            // btnKick
            // 
            this.btnKick.Enabled = false;
            this.btnKick.Location = new System.Drawing.Point(306, 253);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(54, 23);
            this.btnKick.TabIndex = 15;
            this.btnKick.Text = "Kick";
            this.btnKick.UseVisualStyleBackColor = true;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Player Control";
            // 
            // btnBan
            // 
            this.btnBan.Enabled = false;
            this.btnBan.Location = new System.Drawing.Point(238, 253);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(54, 23);
            this.btnBan.TabIndex = 17;
            this.btnBan.Text = "Ban";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // lstRCON
            // 
            this.lstRCON.FormattingEnabled = true;
            this.lstRCON.Items.AddRange(new object[] {
            "RCON output displays here!"});
            this.lstRCON.Location = new System.Drawing.Point(6, 286);
            this.lstRCON.Name = "lstRCON";
            this.lstRCON.Size = new System.Drawing.Size(357, 30);
            this.lstRCON.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 345);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstPlayers);
            this.tabPage1.Controls.Add(this.lstRCON);
            this.tabPage1.Controls.Add(this.txtConnection);
            this.tabPage1.Controls.Add(this.btnBan);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.btnKick);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.lblPlayers);
            this.tabPage1.Controls.Add(this.lblMap);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtMap);
            this.tabPage1.Controls.Add(this.txtPlayers);
            this.tabPage1.Controls.Add(this.txtMode);
            this.tabPage1.Controls.Add(this.lblMode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExit);
            this.tabPage2.Controls.Add(this.btnReloadLog);
            this.tabPage2.Controls.Add(this.btnReloadBans);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnGMX);
            this.tabPage2.Controls.Add(this.btnReloadFS);
            this.tabPage2.Controls.Add(this.btnUnloadFS);
            this.tabPage2.Controls.Add(this.btnLoadFS);
            this.tabPage2.Controls.Add(this.txtFilterscript);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnSendMessage);
            this.tabPage2.Controls.Add(this.txtMessage);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnSetGravity);
            this.tabPage2.Controls.Add(this.txtGravity);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnUnbanIP);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnBanIP);
            this.tabPage2.Controls.Add(this.txtBanIP);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnChangemode);
            this.tabPage2.Controls.Add(this.txtChangemode);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnMapname);
            this.tabPage2.Controls.Add(this.txtMapname);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnGameText);
            this.tabPage2.Controls.Add(this.txtGamemode);
            this.tabPage2.Controls.Add(this.lstRCON2);
            this.tabPage2.Controls.Add(this.btnSetHost);
            this.tabPage2.Controls.Add(this.txtHostname);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Server Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(29, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Close Server";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReloadLog
            // 
            this.btnReloadLog.Location = new System.Drawing.Point(110, 201);
            this.btnReloadLog.Name = "btnReloadLog";
            this.btnReloadLog.Size = new System.Drawing.Size(75, 23);
            this.btnReloadLog.TabIndex = 34;
            this.btnReloadLog.Text = "Reload Log";
            this.btnReloadLog.UseVisualStyleBackColor = true;
            this.btnReloadLog.Click += new System.EventHandler(this.btnReloadLog_Click);
            // 
            // btnReloadBans
            // 
            this.btnReloadBans.Location = new System.Drawing.Point(191, 201);
            this.btnReloadBans.Name = "btnReloadBans";
            this.btnReloadBans.Size = new System.Drawing.Size(79, 23);
            this.btnReloadBans.TabIndex = 33;
            this.btnReloadBans.Text = "Reload Bans";
            this.btnReloadBans.UseVisualStyleBackColor = true;
            this.btnReloadBans.Click += new System.EventHandler(this.btnReloadBans_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(205, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Gravity:";
            // 
            // btnGMX
            // 
            this.btnGMX.Location = new System.Drawing.Point(276, 201);
            this.btnGMX.Name = "btnGMX";
            this.btnGMX.Size = new System.Drawing.Size(75, 23);
            this.btnGMX.TabIndex = 31;
            this.btnGMX.Text = "GMX";
            this.btnGMX.UseVisualStyleBackColor = true;
            this.btnGMX.Click += new System.EventHandler(this.btnGMX_Click);
            // 
            // btnReloadFS
            // 
            this.btnReloadFS.Location = new System.Drawing.Point(310, 154);
            this.btnReloadFS.Name = "btnReloadFS";
            this.btnReloadFS.Size = new System.Drawing.Size(51, 23);
            this.btnReloadFS.TabIndex = 30;
            this.btnReloadFS.Text = "Reload";
            this.btnReloadFS.UseVisualStyleBackColor = true;
            this.btnReloadFS.Click += new System.EventHandler(this.btnReloadFS_Click);
            // 
            // btnUnloadFS
            // 
            this.btnUnloadFS.Location = new System.Drawing.Point(253, 154);
            this.btnUnloadFS.Name = "btnUnloadFS";
            this.btnUnloadFS.Size = new System.Drawing.Size(51, 23);
            this.btnUnloadFS.TabIndex = 29;
            this.btnUnloadFS.Text = "Unload";
            this.btnUnloadFS.UseVisualStyleBackColor = true;
            this.btnUnloadFS.Click += new System.EventHandler(this.btnUnloadFS_Click);
            // 
            // btnLoadFS
            // 
            this.btnLoadFS.Location = new System.Drawing.Point(205, 154);
            this.btnLoadFS.Name = "btnLoadFS";
            this.btnLoadFS.Size = new System.Drawing.Size(42, 23);
            this.btnLoadFS.TabIndex = 28;
            this.btnLoadFS.Text = "Load";
            this.btnLoadFS.UseVisualStyleBackColor = true;
            this.btnLoadFS.Click += new System.EventHandler(this.btnLoadFS_Click);
            // 
            // txtFilterscript
            // 
            this.txtFilterscript.Location = new System.Drawing.Point(72, 156);
            this.txtFilterscript.Name = "txtFilterscript";
            this.txtFilterscript.Size = new System.Drawing.Size(127, 20);
            this.txtFilterscript.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Filterscript:";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(309, 228);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(58, 23);
            this.btnSendMessage.TabIndex = 25;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(68, 230);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(235, 20);
            this.txtMessage.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Message:";
            // 
            // btnSetGravity
            // 
            this.btnSetGravity.Location = new System.Drawing.Point(319, 128);
            this.btnSetGravity.Name = "btnSetGravity";
            this.btnSetGravity.Size = new System.Drawing.Size(42, 23);
            this.btnSetGravity.TabIndex = 22;
            this.btnSetGravity.Text = "Set";
            this.btnSetGravity.UseVisualStyleBackColor = true;
            this.btnSetGravity.Click += new System.EventHandler(this.btnSetGravity_Click);
            // 
            // txtGravity
            // 
            this.txtGravity.Location = new System.Drawing.Point(254, 130);
            this.txtGravity.Name = "txtGravity";
            this.txtGravity.Size = new System.Drawing.Size(59, 20);
            this.txtGravity.TabIndex = 20;
            this.txtGravity.Text = "0.008";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Gravity:";
            // 
            // btnUnbanIP
            // 
            this.btnUnbanIP.Location = new System.Drawing.Point(286, 102);
            this.btnUnbanIP.Name = "btnUnbanIP";
            this.btnUnbanIP.Size = new System.Drawing.Size(75, 23);
            this.btnUnbanIP.TabIndex = 18;
            this.btnUnbanIP.Text = "Unban IP";
            this.btnUnbanIP.UseVisualStyleBackColor = true;
            this.btnUnbanIP.Click += new System.EventHandler(this.btnUnbanIP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(145, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Server Control";
            // 
            // btnBanIP
            // 
            this.btnBanIP.Location = new System.Drawing.Point(205, 102);
            this.btnBanIP.Name = "btnBanIP";
            this.btnBanIP.Size = new System.Drawing.Size(75, 23);
            this.btnBanIP.TabIndex = 16;
            this.btnBanIP.Text = "Ban IP";
            this.btnBanIP.UseVisualStyleBackColor = true;
            this.btnBanIP.Click += new System.EventHandler(this.btnBanIP_Click);
            // 
            // txtBanIP
            // 
            this.txtBanIP.Location = new System.Drawing.Point(57, 104);
            this.txtBanIP.Name = "txtBanIP";
            this.txtBanIP.Size = new System.Drawing.Size(142, 20);
            this.txtBanIP.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ban IP:";
            // 
            // btnChangemode
            // 
            this.btnChangemode.Location = new System.Drawing.Point(157, 128);
            this.btnChangemode.Name = "btnChangemode";
            this.btnChangemode.Size = new System.Drawing.Size(42, 23);
            this.btnChangemode.TabIndex = 13;
            this.btnChangemode.Text = "Set";
            this.btnChangemode.UseVisualStyleBackColor = true;
            this.btnChangemode.Click += new System.EventHandler(this.btnChangemode_Click);
            // 
            // txtChangemode
            // 
            this.txtChangemode.Location = new System.Drawing.Point(88, 130);
            this.txtChangemode.Name = "txtChangemode";
            this.txtChangemode.Size = new System.Drawing.Size(63, 20);
            this.txtChangemode.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Changemode:";
            // 
            // btnMapname
            // 
            this.btnMapname.Location = new System.Drawing.Point(156, 53);
            this.btnMapname.Name = "btnMapname";
            this.btnMapname.Size = new System.Drawing.Size(36, 23);
            this.btnMapname.TabIndex = 10;
            this.btnMapname.Text = "Set";
            this.btnMapname.UseVisualStyleBackColor = true;
            this.btnMapname.Click += new System.EventHandler(this.btnMapname_Click);
            // 
            // txtMapname
            // 
            this.txtMapname.Location = new System.Drawing.Point(68, 55);
            this.txtMapname.Name = "txtMapname";
            this.txtMapname.Size = new System.Drawing.Size(82, 20);
            this.txtMapname.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mapname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gametext:";
            // 
            // btnGameText
            // 
            this.btnGameText.Location = new System.Drawing.Point(328, 53);
            this.btnGameText.Name = "btnGameText";
            this.btnGameText.Size = new System.Drawing.Size(32, 23);
            this.btnGameText.TabIndex = 6;
            this.btnGameText.Text = "Set";
            this.btnGameText.UseVisualStyleBackColor = true;
            this.btnGameText.Click += new System.EventHandler(this.btnGameText_Click);
            // 
            // txtGamemode
            // 
            this.txtGamemode.Location = new System.Drawing.Point(253, 55);
            this.txtGamemode.Name = "txtGamemode";
            this.txtGamemode.Size = new System.Drawing.Size(69, 20);
            this.txtGamemode.TabIndex = 5;
            // 
            // lstRCON2
            // 
            this.lstRCON2.FormattingEnabled = true;
            this.lstRCON2.Items.AddRange(new object[] {
            "RCON output displays here, although not every command gives an output!"});
            this.lstRCON2.Location = new System.Drawing.Point(6, 256);
            this.lstRCON2.Name = "lstRCON2";
            this.lstRCON2.Size = new System.Drawing.Size(361, 56);
            this.lstRCON2.TabIndex = 4;
            // 
            // btnSetHost
            // 
            this.btnSetHost.Location = new System.Drawing.Point(285, 27);
            this.btnSetHost.Name = "btnSetHost";
            this.btnSetHost.Size = new System.Drawing.Size(75, 23);
            this.btnSetHost.TabIndex = 3;
            this.btnSetHost.Text = "Set";
            this.btnSetHost.UseVisualStyleBackColor = true;
            this.btnSetHost.Click += new System.EventHandler(this.btnSetHost_Click);
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(68, 29);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(211, 20);
            this.txtHostname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hostname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please make sure the IP and RCON password are set on the general tab!";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(373, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 305);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 345);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "SA-MP RCON GUI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPlayers;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.ListBox lstRCON;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetHost;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstRCON2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGameText;
        private System.Windows.Forms.TextBox txtGamemode;
        private System.Windows.Forms.Button btnMapname;
        private System.Windows.Forms.TextBox txtMapname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChangemode;
        private System.Windows.Forms.TextBox txtChangemode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGMX;
        private System.Windows.Forms.Button btnReloadFS;
        private System.Windows.Forms.Button btnUnloadFS;
        private System.Windows.Forms.Button btnLoadFS;
        private System.Windows.Forms.TextBox txtFilterscript;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSetGravity;
        private System.Windows.Forms.TextBox txtGravity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUnbanIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBanIP;
        private System.Windows.Forms.TextBox txtBanIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReloadLog;
        private System.Windows.Forms.Button btnReloadBans;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

