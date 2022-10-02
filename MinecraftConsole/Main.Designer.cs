
namespace MinecraftConsole
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbxPrefix = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.gbxDirectorate = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPromote = new System.Windows.Forms.Button();
            this.btnDemotion = new System.Windows.Forms.Button();
            this.btnAddBlack = new System.Windows.Forms.Button();
            this.btnReBlack = new System.Windows.Forms.Button();
            this.btnFly = new System.Windows.Forms.Button();
            this.btnNoFly = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnNoMute = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnNight = new System.Windows.Forms.Button();
            this.cbxDifficulty = new System.Windows.Forms.ComboBox();
            this.btnTiming = new System.Windows.Forms.Button();
            this.btnUpLevels = new System.Windows.Forms.Button();
            this.txtLevels = new System.Windows.Forms.TextBox();
            this.btnGameMode = new System.Windows.Forms.Button();
            this.btnTell = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTPID = new System.Windows.Forms.TextBox();
            this.btnTP = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTPZ = new System.Windows.Forms.TextBox();
            this.txtTPY = new System.Windows.Forms.TextBox();
            this.txtTPX = new System.Windows.Forms.TextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNotice = new System.Windows.Forms.Button();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbxOlineUser = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxBan = new System.Windows.Forms.ListBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.plGameRule = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.gbxDirectorate.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.cbxPrefix);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录";
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(173, 143);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 32);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(105, 143);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(62, 32);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbxPrefix
            // 
            this.cbxPrefix.AutoSize = true;
            this.cbxPrefix.Location = new System.Drawing.Point(15, 147);
            this.cbxPrefix.Name = "cbxPrefix";
            this.cbxPrefix.Size = new System.Drawing.Size(84, 25);
            this.cbxPrefix.TabIndex = 32;
            this.cbxPrefix.Text = "命令带/";
            this.cbxPrefix.UseVisualStyleBackColor = true;
            this.cbxPrefix.CheckedChanged += new System.EventHandler(this.cbxPrefix_CheckedChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(59, 104);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(176, 28);
            this.txtPort.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(59, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 28);
            this.txtPassword.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(59, 36);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 28);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "地址";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 211);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(502, 362);
            this.txtLog.TabIndex = 1;
            // 
            // gbxDirectorate
            // 
            this.gbxDirectorate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDirectorate.Controls.Add(this.tabControl1);
            this.gbxDirectorate.Controls.Add(this.btnTiming);
            this.gbxDirectorate.Controls.Add(this.btnUpLevels);
            this.gbxDirectorate.Controls.Add(this.txtLevels);
            this.gbxDirectorate.Controls.Add(this.btnGameMode);
            this.gbxDirectorate.Controls.Add(this.btnTell);
            this.gbxDirectorate.Controls.Add(this.btnKill);
            this.gbxDirectorate.Controls.Add(this.label22);
            this.gbxDirectorate.Controls.Add(this.txtTPID);
            this.gbxDirectorate.Controls.Add(this.btnTP);
            this.gbxDirectorate.Controls.Add(this.label25);
            this.gbxDirectorate.Controls.Add(this.label24);
            this.gbxDirectorate.Controls.Add(this.label23);
            this.gbxDirectorate.Controls.Add(this.txtTPZ);
            this.gbxDirectorate.Controls.Add(this.txtTPY);
            this.gbxDirectorate.Controls.Add(this.txtTPX);
            this.gbxDirectorate.Controls.Add(this.btnSendCommand);
            this.gbxDirectorate.Controls.Add(this.txtCommand);
            this.gbxDirectorate.Controls.Add(this.label5);
            this.gbxDirectorate.Controls.Add(this.btnNotice);
            this.gbxDirectorate.Controls.Add(this.txtNotice);
            this.gbxDirectorate.Controls.Add(this.txtID);
            this.gbxDirectorate.Controls.Add(this.label6);
            this.gbxDirectorate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxDirectorate.Location = new System.Drawing.Point(268, 12);
            this.gbxDirectorate.Name = "gbxDirectorate";
            this.gbxDirectorate.Size = new System.Drawing.Size(744, 193);
            this.gbxDirectorate.TabIndex = 8;
            this.gbxDirectorate.TabStop = false;
            this.gbxDirectorate.Text = "指挥部";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(6, 52);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 99);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(330, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "权力";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPromote);
            this.flowLayoutPanel1.Controls.Add(this.btnDemotion);
            this.flowLayoutPanel1.Controls.Add(this.btnAddBlack);
            this.flowLayoutPanel1.Controls.Add(this.btnReBlack);
            this.flowLayoutPanel1.Controls.Add(this.btnFly);
            this.flowLayoutPanel1.Controls.Add(this.btnNoFly);
            this.flowLayoutPanel1.Controls.Add(this.btnMute);
            this.flowLayoutPanel1.Controls.Add(this.btnNoMute);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 71);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(3, 3);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(58, 28);
            this.btnPromote.TabIndex = 4;
            this.btnPromote.Text = "设为OP";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // btnDemotion
            // 
            this.btnDemotion.Location = new System.Drawing.Point(67, 3);
            this.btnDemotion.Name = "btnDemotion";
            this.btnDemotion.Size = new System.Drawing.Size(58, 28);
            this.btnDemotion.TabIndex = 5;
            this.btnDemotion.Text = "取消OP";
            this.btnDemotion.UseVisualStyleBackColor = true;
            this.btnDemotion.Click += new System.EventHandler(this.btnDemotion_Click);
            // 
            // btnAddBlack
            // 
            this.btnAddBlack.Location = new System.Drawing.Point(131, 3);
            this.btnAddBlack.Name = "btnAddBlack";
            this.btnAddBlack.Size = new System.Drawing.Size(58, 28);
            this.btnAddBlack.TabIndex = 13;
            this.btnAddBlack.Text = "拉黑";
            this.btnAddBlack.UseVisualStyleBackColor = true;
            this.btnAddBlack.Click += new System.EventHandler(this.btnAddBlack_Click);
            // 
            // btnReBlack
            // 
            this.btnReBlack.Location = new System.Drawing.Point(195, 3);
            this.btnReBlack.Name = "btnReBlack";
            this.btnReBlack.Size = new System.Drawing.Size(58, 28);
            this.btnReBlack.TabIndex = 14;
            this.btnReBlack.Text = "除拉黑";
            this.btnReBlack.UseVisualStyleBackColor = true;
            this.btnReBlack.Click += new System.EventHandler(this.btnReBlack_Click);
            // 
            // btnFly
            // 
            this.btnFly.Location = new System.Drawing.Point(259, 3);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(58, 28);
            this.btnFly.TabIndex = 27;
            this.btnFly.Text = "飞行";
            this.btnFly.UseVisualStyleBackColor = true;
            this.btnFly.Click += new System.EventHandler(this.btnFly_Click);
            // 
            // btnNoFly
            // 
            this.btnNoFly.Location = new System.Drawing.Point(3, 37);
            this.btnNoFly.Name = "btnNoFly";
            this.btnNoFly.Size = new System.Drawing.Size(58, 28);
            this.btnNoFly.TabIndex = 29;
            this.btnNoFly.Text = "禁飞行";
            this.btnNoFly.UseVisualStyleBackColor = true;
            this.btnNoFly.Click += new System.EventHandler(this.btnNoFly_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(67, 37);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(58, 28);
            this.btnMute.TabIndex = 28;
            this.btnMute.Text = "禁言";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnNoMute
            // 
            this.btnNoMute.Location = new System.Drawing.Point(131, 37);
            this.btnNoMute.Name = "btnNoMute";
            this.btnNoMute.Size = new System.Drawing.Size(58, 28);
            this.btnNoMute.TabIndex = 30;
            this.btnNoMute.Text = "除禁言";
            this.btnNoMute.UseVisualStyleBackColor = true;
            this.btnNoMute.Click += new System.EventHandler(this.btnNoMute_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "游戏性";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnDay);
            this.flowLayoutPanel2.Controls.Add(this.btnNight);
            this.flowLayoutPanel2.Controls.Add(this.cbxDifficulty);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(324, 65);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnDay
            // 
            this.btnDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDay.Location = new System.Drawing.Point(3, 3);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(58, 28);
            this.btnDay.TabIndex = 33;
            this.btnDay.Text = "白天";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnNight
            // 
            this.btnNight.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNight.Location = new System.Drawing.Point(67, 3);
            this.btnNight.Name = "btnNight";
            this.btnNight.Size = new System.Drawing.Size(58, 28);
            this.btnNight.TabIndex = 34;
            this.btnNight.Text = "黑夜";
            this.btnNight.UseVisualStyleBackColor = true;
            this.btnNight.Click += new System.EventHandler(this.btnNight_Click);
            // 
            // cbxDifficulty
            // 
            this.cbxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDifficulty.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxDifficulty.FormattingEnabled = true;
            this.cbxDifficulty.ItemHeight = 19;
            this.cbxDifficulty.Items.AddRange(new object[] {
            "和平",
            "简单",
            "普通",
            "困难"});
            this.cbxDifficulty.Location = new System.Drawing.Point(131, 3);
            this.cbxDifficulty.Name = "cbxDifficulty";
            this.cbxDifficulty.Size = new System.Drawing.Size(58, 27);
            this.cbxDifficulty.TabIndex = 26;
            this.cbxDifficulty.TextChanged += new System.EventHandler(this.cbxDifficulty_TextChanged);
            // 
            // btnTiming
            // 
            this.btnTiming.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTiming.Location = new System.Drawing.Point(343, 119);
            this.btnTiming.Name = "btnTiming";
            this.btnTiming.Size = new System.Drawing.Size(81, 28);
            this.btnTiming.TabIndex = 38;
            this.btnTiming.Text = "定时任务";
            this.btnTiming.UseVisualStyleBackColor = true;
            this.btnTiming.Click += new System.EventHandler(this.btnTiming_Click);
            // 
            // btnUpLevels
            // 
            this.btnUpLevels.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpLevels.Location = new System.Drawing.Point(710, 79);
            this.btnUpLevels.Name = "btnUpLevels";
            this.btnUpLevels.Size = new System.Drawing.Size(28, 28);
            this.btnUpLevels.TabIndex = 37;
            this.btnUpLevels.Text = "Up";
            this.btnUpLevels.UseVisualStyleBackColor = true;
            this.btnUpLevels.Click += new System.EventHandler(this.btnUpLevels_Click);
            // 
            // txtLevels
            // 
            this.txtLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLevels.Location = new System.Drawing.Point(646, 79);
            this.txtLevels.Name = "txtLevels";
            this.txtLevels.Size = new System.Drawing.Size(58, 28);
            this.txtLevels.TabIndex = 36;
            // 
            // btnGameMode
            // 
            this.btnGameMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGameMode.Location = new System.Drawing.Point(316, 21);
            this.btnGameMode.Name = "btnGameMode";
            this.btnGameMode.Size = new System.Drawing.Size(58, 28);
            this.btnGameMode.TabIndex = 35;
            this.btnGameMode.Text = "模式";
            this.btnGameMode.UseVisualStyleBackColor = true;
            this.btnGameMode.Click += new System.EventHandler(this.btnGameMode_Click);
            // 
            // btnTell
            // 
            this.btnTell.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTell.Location = new System.Drawing.Point(252, 157);
            this.btnTell.Name = "btnTell";
            this.btnTell.Size = new System.Drawing.Size(58, 28);
            this.btnTell.TabIndex = 31;
            this.btnTell.Text = "私信";
            this.btnTell.UseVisualStyleBackColor = true;
            this.btnTell.Click += new System.EventHandler(this.btnTell_Click);
            // 
            // btnKill
            // 
            this.btnKill.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKill.Location = new System.Drawing.Point(252, 21);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(58, 28);
            this.btnKill.TabIndex = 25;
            this.btnKill.Text = "杀死";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(574, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 21);
            this.label22.TabIndex = 24;
            this.label22.Text = "玩家";
            // 
            // txtTPID
            // 
            this.txtTPID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTPID.Location = new System.Drawing.Point(622, 16);
            this.txtTPID.Name = "txtTPID";
            this.txtTPID.Size = new System.Drawing.Size(116, 28);
            this.txtTPID.TabIndex = 23;
            // 
            // btnTP
            // 
            this.btnTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTP.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTP.Location = new System.Drawing.Point(680, 116);
            this.btnTP.Name = "btnTP";
            this.btnTP.Size = new System.Drawing.Size(58, 28);
            this.btnTP.TabIndex = 22;
            this.btnTP.Text = "传送";
            this.btnTP.UseVisualStyleBackColor = true;
            this.btnTP.Click += new System.EventHandler(this.btnTP_Click);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(599, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 17);
            this.label25.TabIndex = 21;
            this.label25.Text = "Z";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(516, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 17);
            this.label24.TabIndex = 20;
            this.label24.Text = "Y";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(430, 121);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 17);
            this.label23.TabIndex = 19;
            this.label23.Text = "X";
            // 
            // txtTPZ
            // 
            this.txtTPZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTPZ.Location = new System.Drawing.Point(620, 116);
            this.txtTPZ.Name = "txtTPZ";
            this.txtTPZ.Size = new System.Drawing.Size(56, 28);
            this.txtTPZ.TabIndex = 18;
            // 
            // txtTPY
            // 
            this.txtTPY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTPY.Location = new System.Drawing.Point(537, 117);
            this.txtTPY.Name = "txtTPY";
            this.txtTPY.Size = new System.Drawing.Size(56, 28);
            this.txtTPY.TabIndex = 17;
            // 
            // txtTPX
            // 
            this.txtTPX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTPX.Location = new System.Drawing.Point(452, 117);
            this.txtTPX.Name = "txtTPX";
            this.txtTPX.Size = new System.Drawing.Size(58, 28);
            this.txtTPX.TabIndex = 16;
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCommand.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendCommand.Location = new System.Drawing.Point(682, 157);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(58, 28);
            this.btnSendCommand.TabIndex = 12;
            this.btnSendCommand.Text = "发送";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.Location = new System.Drawing.Point(412, 158);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(264, 28);
            this.txtCommand.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "自定义命令";
            // 
            // btnNotice
            // 
            this.btnNotice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotice.Location = new System.Drawing.Point(188, 157);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(58, 28);
            this.btnNotice.TabIndex = 8;
            this.btnNotice.Text = "公告";
            this.btnNotice.UseVisualStyleBackColor = true;
            this.btnNotice.Click += new System.EventHandler(this.btnNotice_Click);
            // 
            // txtNotice
            // 
            this.txtNotice.Location = new System.Drawing.Point(6, 157);
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(176, 28);
            this.txtNotice.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(70, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 28);
            this.txtID.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "用户名";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbxOlineUser
            // 
            this.lbxOlineUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxOlineUser.FormattingEnabled = true;
            this.lbxOlineUser.ItemHeight = 17;
            this.lbxOlineUser.Location = new System.Drawing.Point(892, 246);
            this.lbxOlineUser.Name = "lbxOlineUser";
            this.lbxOlineUser.Size = new System.Drawing.Size(120, 327);
            this.lbxOlineUser.TabIndex = 9;
            this.lbxOlineUser.MouseEnter += new System.EventHandler(this.lbxOlineUser_MouseEnter);
            this.lbxOlineUser.MouseLeave += new System.EventHandler(this.lbxOlineUser_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(892, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "当前在线用户";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(766, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "黑名单";
            // 
            // lbxBan
            // 
            this.lbxBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxBan.FormattingEnabled = true;
            this.lbxBan.ItemHeight = 17;
            this.lbxBan.Location = new System.Drawing.Point(766, 246);
            this.lbxBan.Name = "lbxBan";
            this.lbxBan.Size = new System.Drawing.Size(120, 327);
            this.lbxBan.TabIndex = 11;
            this.lbxBan.MouseEnter += new System.EventHandler(this.lbxBan_MouseEnter);
            this.lbxBan.MouseLeave += new System.EventHandler(this.lbxBan_MouseLeave);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(438, 541);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(58, 28);
            this.btnClearLog.TabIndex = 31;
            this.btnClearLog.Text = "清空";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // plGameRule
            // 
            this.plGameRule.AutoScroll = true;
            this.plGameRule.Location = new System.Drawing.Point(520, 211);
            this.plGameRule.Name = "plGameRule";
            this.plGameRule.Size = new System.Drawing.Size(240, 362);
            this.plGameRule.TabIndex = 32;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 581);
            this.Controls.Add(this.plGameRule);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxOlineUser);
            this.Controls.Add(this.gbxDirectorate);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1040, 620);
            this.MinimumSize = new System.Drawing.Size(1040, 620);
            this.Name = "Main";
            this.Text = "Minecraft后台控制器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxDirectorate.ResumeLayout(false);
            this.gbxDirectorate.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox gbxDirectorate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Button btnDemotion;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbxOlineUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.Button btnAddBlack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxBan;
        private System.Windows.Forms.Button btnReBlack;
        private System.Windows.Forms.TextBox txtTPX;
        private System.Windows.Forms.TextBox txtTPZ;
        private System.Windows.Forms.TextBox txtTPY;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnTP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTPID;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.ComboBox cbxDifficulty;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnNoMute;
        private System.Windows.Forms.Button btnNoFly;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnTell;
        private System.Windows.Forms.CheckBox cbxPrefix;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnNight;
        private System.Windows.Forms.Button btnGameMode;
        private System.Windows.Forms.Button btnUpLevels;
        private System.Windows.Forms.TextBox txtLevels;
        private System.Windows.Forms.Button btnTiming;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel plGameRule;
    }
}

