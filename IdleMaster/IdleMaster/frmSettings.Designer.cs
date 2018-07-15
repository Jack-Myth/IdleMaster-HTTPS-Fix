using System.ComponentModel;
using System.Windows.Forms;

namespace IdleMaster
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.chkShowUsername = new System.Windows.Forms.CheckBox();
            this.chkIgnoreClientStatus = new System.Windows.Forms.CheckBox();
            this.chkMinToTray = new System.Windows.Forms.CheckBox();
            this.grpPriority = new System.Windows.Forms.GroupBox();
            this.radIdleMostValue = new System.Windows.Forms.RadioButton();
            this.radIdleLeastDrops = new System.Windows.Forms.RadioButton();
            this.radIdleMostDrops = new System.Windows.Forms.RadioButton();
            this.radIdleDefault = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ttHints = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.btnWaga = new System.Windows.Forms.Button();
            this.grpIdlingQuantity = new System.Windows.Forms.GroupBox();
            this.radOneThenMany = new System.Windows.Forms.RadioButton();
            this.radManyThenOne = new System.Windows.Forms.RadioButton();
            this.radOneGameOnly = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonhs2 = new System.Windows.Forms.Button();
            this.buttonhs = new System.Windows.Forms.Button();
            this.PageRedit = new System.Windows.Forms.ComboBox();
            this.Maxtimeout = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpGeneral.SuspendLayout();
            this.grpPriority.SuspendLayout();
            this.grpIdlingQuantity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGeneral
            // 
            this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneral.Controls.Add(this.cboLanguage);
            this.grpGeneral.Controls.Add(this.lblLanguage);
            this.grpGeneral.Controls.Add(this.chkShowUsername);
            this.grpGeneral.Controls.Add(this.chkIgnoreClientStatus);
            this.grpGeneral.Controls.Add(this.chkMinToTray);
            this.grpGeneral.Location = new System.Drawing.Point(13, 12);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGeneral.Size = new System.Drawing.Size(392, 98);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "Chinese (Simplified, China)",
            "Chinese (Traditional, China)",
            "Czech",
            "Dutch",
            "Finnish",
            "French",
            "German",
            "Greek",
            "Hungarian",
            "Italian",
            "Japanese",
            "Korean",
            "Norwegian",
            "Polish",
            "Portuguese",
            "Portuguese (Brazil)",
            "Romanian",
            "Russian",
            "Spanish",
            "Swedish",
            "Thai",
            "Turkish",
            "Ukrainian"});
            this.cboLanguage.Location = new System.Drawing.Point(135, 70);
            this.cboLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(190, 20);
            this.cboLanguage.TabIndex = 4;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(26, 73);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(119, 12);
            this.lblLanguage.TabIndex = 3;
            this.lblLanguage.Text = "Interface Language:";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkShowUsername
            // 
            this.chkShowUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowUsername.Location = new System.Drawing.Point(8, 50);
            this.chkShowUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowUsername.Name = "chkShowUsername";
            this.chkShowUsername.Size = new System.Drawing.Size(378, 18);
            this.chkShowUsername.TabIndex = 2;
            this.chkShowUsername.Text = "Show Steam username of signed on user";
            this.chkShowUsername.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreClientStatus
            // 
            this.chkIgnoreClientStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIgnoreClientStatus.Location = new System.Drawing.Point(8, 35);
            this.chkIgnoreClientStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIgnoreClientStatus.Name = "chkIgnoreClientStatus";
            this.chkIgnoreClientStatus.Size = new System.Drawing.Size(378, 16);
            this.chkIgnoreClientStatus.TabIndex = 1;
            this.chkIgnoreClientStatus.Text = "Ignore Steam client status";
            this.chkIgnoreClientStatus.UseVisualStyleBackColor = true;
            // 
            // chkMinToTray
            // 
            this.chkMinToTray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMinToTray.Location = new System.Drawing.Point(8, 18);
            this.chkMinToTray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMinToTray.Name = "chkMinToTray";
            this.chkMinToTray.Size = new System.Drawing.Size(378, 16);
            this.chkMinToTray.TabIndex = 0;
            this.chkMinToTray.Text = "Minimize Idle Master to system tray";
            this.chkMinToTray.UseVisualStyleBackColor = true;
            // 
            // grpPriority
            // 
            this.grpPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPriority.Controls.Add(this.radIdleMostValue);
            this.grpPriority.Controls.Add(this.radIdleLeastDrops);
            this.grpPriority.Controls.Add(this.radIdleMostDrops);
            this.grpPriority.Controls.Add(this.radIdleDefault);
            this.grpPriority.Location = new System.Drawing.Point(13, 192);
            this.grpPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPriority.Size = new System.Drawing.Size(392, 85);
            this.grpPriority.TabIndex = 1;
            this.grpPriority.TabStop = false;
            this.grpPriority.Text = "Idling Order";
            // 
            // radIdleMostValue
            // 
            this.radIdleMostValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radIdleMostValue.Location = new System.Drawing.Point(7, 32);
            this.radIdleMostValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radIdleMostValue.Name = "radIdleMostValue";
            this.radIdleMostValue.Size = new System.Drawing.Size(379, 16);
            this.radIdleMostValue.TabIndex = 3;
            this.radIdleMostValue.TabStop = true;
            this.radIdleMostValue.Text = "Prioritize games with the highest card values";
            this.radIdleMostValue.UseVisualStyleBackColor = true;
            // 
            // radIdleLeastDrops
            // 
            this.radIdleLeastDrops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radIdleLeastDrops.Location = new System.Drawing.Point(7, 64);
            this.radIdleLeastDrops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radIdleLeastDrops.Name = "radIdleLeastDrops";
            this.radIdleLeastDrops.Size = new System.Drawing.Size(379, 16);
            this.radIdleLeastDrops.TabIndex = 2;
            this.radIdleLeastDrops.Text = "Prioritize games with the lowest number of available drops";
            this.radIdleLeastDrops.UseVisualStyleBackColor = true;
            // 
            // radIdleMostDrops
            // 
            this.radIdleMostDrops.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radIdleMostDrops.Location = new System.Drawing.Point(7, 48);
            this.radIdleMostDrops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radIdleMostDrops.Name = "radIdleMostDrops";
            this.radIdleMostDrops.Size = new System.Drawing.Size(379, 16);
            this.radIdleMostDrops.TabIndex = 1;
            this.radIdleMostDrops.Text = "Prioritize games with the highest number of available drops";
            this.radIdleMostDrops.UseVisualStyleBackColor = true;
            // 
            // radIdleDefault
            // 
            this.radIdleDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radIdleDefault.Checked = true;
            this.radIdleDefault.Location = new System.Drawing.Point(7, 17);
            this.radIdleDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radIdleDefault.Name = "radIdleDefault";
            this.radIdleDefault.Size = new System.Drawing.Size(379, 16);
            this.radIdleDefault.TabIndex = 0;
            this.radIdleDefault.TabStop = true;
            this.radIdleDefault.Text = "Default (Alphabetical Order)";
            this.radIdleDefault.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(330, 399);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(249, 399);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&Accept";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdvanced.Image = global::IdleMaster.Properties.Resources.imgLock;
            this.btnAdvanced.Location = new System.Drawing.Point(13, 384);
            this.btnAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(41, 44);
            this.btnAdvanced.TabIndex = 4;
            this.ttHints.SetToolTip(this.btnAdvanced, "Display advanced authentication information");
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // btnWaga
            // 
            this.btnWaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWaga.Image = global::IdleMaster.Properties.Resources.neko;
            this.btnWaga.Location = new System.Drawing.Point(60, 384);
            this.btnWaga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWaga.Name = "btnWaga";
            this.btnWaga.Size = new System.Drawing.Size(41, 44);
            this.btnWaga.TabIndex = 6;
            this.ttHints.SetToolTip(this.btnWaga, "魔改设置");
            this.btnWaga.UseVisualStyleBackColor = true;
            this.btnWaga.Click += new System.EventHandler(this.btnWaga_Click);
            // 
            // grpIdlingQuantity
            // 
            this.grpIdlingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIdlingQuantity.Controls.Add(this.radOneThenMany);
            this.grpIdlingQuantity.Controls.Add(this.radManyThenOne);
            this.grpIdlingQuantity.Controls.Add(this.radOneGameOnly);
            this.grpIdlingQuantity.Location = new System.Drawing.Point(13, 114);
            this.grpIdlingQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.grpIdlingQuantity.Name = "grpIdlingQuantity";
            this.grpIdlingQuantity.Padding = new System.Windows.Forms.Padding(2);
            this.grpIdlingQuantity.Size = new System.Drawing.Size(392, 74);
            this.grpIdlingQuantity.TabIndex = 5;
            this.grpIdlingQuantity.TabStop = false;
            this.grpIdlingQuantity.Text = "Idling Behavior";
            // 
            // radOneThenMany
            // 
            this.radOneThenMany.AutoSize = true;
            this.radOneThenMany.Location = new System.Drawing.Point(7, 49);
            this.radOneThenMany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radOneThenMany.Name = "radOneThenMany";
            this.radOneThenMany.Size = new System.Drawing.Size(425, 16);
            this.radOneThenMany.TabIndex = 6;
            this.radOneThenMany.TabStop = true;
            this.radOneThenMany.Text = "Idle games with more than 2 hours individually, then simultaneously";
            this.radOneThenMany.UseVisualStyleBackColor = true;
            // 
            // radManyThenOne
            // 
            this.radManyThenOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radManyThenOne.Location = new System.Drawing.Point(7, 32);
            this.radManyThenOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radManyThenOne.Name = "radManyThenOne";
            this.radManyThenOne.Size = new System.Drawing.Size(379, 16);
            this.radManyThenOne.TabIndex = 5;
            this.radManyThenOne.TabStop = true;
            this.radManyThenOne.Text = "Idle games simultaneously up to 2 hours, then individually";
            this.radManyThenOne.UseVisualStyleBackColor = true;
            // 
            // radOneGameOnly
            // 
            this.radOneGameOnly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radOneGameOnly.Checked = true;
            this.radOneGameOnly.Location = new System.Drawing.Point(7, 17);
            this.radOneGameOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radOneGameOnly.Name = "radOneGameOnly";
            this.radOneGameOnly.Size = new System.Drawing.Size(379, 16);
            this.radOneGameOnly.TabIndex = 4;
            this.radOneGameOnly.TabStop = true;
            this.radOneGameOnly.Text = "Idle each game individually";
            this.radOneGameOnly.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonhs2);
            this.groupBox1.Controls.Add(this.buttonhs);
            this.groupBox1.Controls.Add(this.PageRedit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Maxtimeout);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(392, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HTTPS 修复版 设置";
            // 
            // buttonhs2
            // 
            this.buttonhs2.Location = new System.Drawing.Point(351, 34);
            this.buttonhs2.Name = "buttonhs2";
            this.buttonhs2.Size = new System.Drawing.Size(35, 23);
            this.buttonhs2.TabIndex = 2;
            this.buttonhs2.Text = "?";
            this.buttonhs2.UseVisualStyleBackColor = true;
            this.buttonhs2.Click += new System.EventHandler(this.buttonhs2_Click);
            // 
            // buttonhs
            // 
            this.buttonhs.Location = new System.Drawing.Point(351, 14);
            this.buttonhs.Name = "buttonhs";
            this.buttonhs.Size = new System.Drawing.Size(35, 23);
            this.buttonhs.TabIndex = 2;
            this.buttonhs.Text = "?";
            this.buttonhs.UseVisualStyleBackColor = true;
            this.buttonhs.Click += new System.EventHandler(this.buttonhs_Click);
            // 
            // PageRedit
            // 
            this.PageRedit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PageRedit.FormattingEnabled = true;
            this.PageRedit.Items.AddRange(new object[] {
            "个人主页（默认）",
            "徽章页面",
            "库存页面（不推荐）",
            "截图页面（不推荐）",
            "评测页面",
            "组页面"});
            this.PageRedit.Location = new System.Drawing.Point(104, 37);
            this.PageRedit.Name = "PageRedit";
            this.PageRedit.Size = new System.Drawing.Size(241, 20);
            this.PageRedit.TabIndex = 1;
            // 
            // Maxtimeout
            // 
            this.Maxtimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Maxtimeout.FormattingEnabled = true;
            this.Maxtimeout.Items.AddRange(new object[] {
            "15秒(不推荐)",
            "30秒(默认)",
            "60秒(频繁出问题时使用)",
            "不限时"});
            this.Maxtimeout.Location = new System.Drawing.Point(175, 17);
            this.Maxtimeout.Name = "Maxtimeout";
            this.Maxtimeout.Size = new System.Drawing.Size(170, 20);
            this.Maxtimeout.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "登陆重定向网址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读取用户信息的最长等待时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "最大同时挂";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "30";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "个游戏(默认30)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(417, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWaga);
            this.Controls.Add(this.grpIdlingQuantity);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpPriority);
            this.Controls.Add(this.grpGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ve";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpPriority.ResumeLayout(false);
            this.grpIdlingQuantity.ResumeLayout(false);
            this.grpIdlingQuantity.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpGeneral;
        private CheckBox chkMinToTray;
        private GroupBox grpPriority;
        private RadioButton radIdleLeastDrops;
        private RadioButton radIdleMostDrops;
        private RadioButton radIdleDefault;
        private Button btnCancel;
        private Button btnOK;
        private RadioButton radIdleMostValue;
        private Button btnAdvanced;
        private ToolTip ttHints;
        private CheckBox chkIgnoreClientStatus;
        private CheckBox chkShowUsername;
    private GroupBox grpIdlingQuantity;
    private RadioButton radManyThenOne;
    private RadioButton radOneGameOnly;
    private ComboBox cboLanguage;
    private Label lblLanguage;
    private RadioButton radOneThenMany;
        private Button btnWaga;
        private GroupBox groupBox1;
        private Button buttonhs;
        private ComboBox Maxtimeout;
        private Label label1;
        private Button buttonhs2;
        private ComboBox PageRedit;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}