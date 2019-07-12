﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IdleMaster
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblCookieStatus = new System.Windows.Forms.Label();
            this.tmrCheckCookieData = new System.Windows.Forms.Timer(this.components);
            this.lblSteamStatus = new System.Windows.Forms.Label();
            this.tmrCheckSteam = new System.Windows.Forms.Timer(this.components);
            this.lnkResetCookies = new System.Windows.Forms.LinkLabel();
            this.lnkSignIn = new System.Windows.Forms.LinkLabel();
            this.lblDrops = new System.Windows.Forms.Label();
            this.lblIdle = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblCurrentRemaining = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.LinkLabel();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FreeIdleMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autoNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableImgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseIdlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeIdlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.blacklistCurrentGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrReadyToGo = new System.Windows.Forms.Timer(this.components);
            this.tmrCardDropCheck = new System.Windows.Forms.Timer(this.components);
            this.ssFooter = new System.Windows.Forms.StatusStrip();
            this.pbIdle = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.picReadingPage = new System.Windows.Forms.PictureBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.picIdleStatus = new System.Windows.Forms.PictureBox();
            this.picCookieStatus = new System.Windows.Forms.PictureBox();
            this.picSteamStatus = new System.Windows.Forms.PictureBox();
            this.picApp = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.tmrStartNext = new System.Windows.Forms.Timer(this.components);
            this.tmrBadgeReload = new System.Windows.Forms.Timer(this.components);
            this.lblSignedOnAs = new System.Windows.Forms.Label();
            this.GamesState = new System.Windows.Forms.ListView();
            this.GameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHoursPlayed = new System.Windows.Forms.Label();
            this.tmrStatistics = new System.Windows.Forms.Timer(this.components);
            this.tmrAutoNext = new System.Windows.Forms.Timer(this.components);
            this.autonextlabel = new System.Windows.Forms.Label();
            this.AutoRestarter = new System.Windows.Forms.Timer(this.components);
            this.labautorestart = new System.Windows.Forms.Label();
            this.mnuTop.SuspendLayout();
            this.ssFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdleStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCookieStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteamStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCookieStatus
            // 
            this.lblCookieStatus.AutoSize = true;
            this.lblCookieStatus.Location = new System.Drawing.Point(31, 59);
            this.lblCookieStatus.Name = "lblCookieStatus";
            this.lblCookieStatus.Size = new System.Drawing.Size(186, 13);
            this.lblCookieStatus.TabIndex = 0;
            this.lblCookieStatus.Text = "Idle Master is not connected to Steam";
            // 
            // tmrCheckCookieData
            // 
            this.tmrCheckCookieData.Enabled = true;
            this.tmrCheckCookieData.Tick += new System.EventHandler(this.tmrCheckCookieData_Tick);
            // 
            // lblSteamStatus
            // 
            this.lblSteamStatus.AutoSize = true;
            this.lblSteamStatus.Location = new System.Drawing.Point(30, 37);
            this.lblSteamStatus.Name = "lblSteamStatus";
            this.lblSteamStatus.Size = new System.Drawing.Size(103, 13);
            this.lblSteamStatus.TabIndex = 3;
            this.lblSteamStatus.Text = "Steam is not running";
            // 
            // tmrCheckSteam
            // 
            this.tmrCheckSteam.Enabled = true;
            this.tmrCheckSteam.Interval = 500;
            this.tmrCheckSteam.Tick += new System.EventHandler(this.tmrCheckSteam_Tick);
            // 
            // lnkResetCookies
            // 
            this.lnkResetCookies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkResetCookies.AutoSize = true;
            this.lnkResetCookies.Location = new System.Drawing.Point(240, 59);
            this.lnkResetCookies.Name = "lnkResetCookies";
            this.lnkResetCookies.Size = new System.Drawing.Size(52, 13);
            this.lnkResetCookies.TabIndex = 4;
            this.lnkResetCookies.TabStop = true;
            this.lnkResetCookies.Text = "(Sign out)";
            this.lnkResetCookies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkResetCookies_LinkClicked);
            // 
            // lnkSignIn
            // 
            this.lnkSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSignIn.AutoSize = true;
            this.lnkSignIn.Location = new System.Drawing.Point(250, 59);
            this.lnkSignIn.Name = "lnkSignIn";
            this.lnkSignIn.Size = new System.Drawing.Size(45, 13);
            this.lnkSignIn.TabIndex = 5;
            this.lnkSignIn.TabStop = true;
            this.lnkSignIn.Text = "(Sign in)";
            this.lnkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignIn_LinkClicked);
            // 
            // lblDrops
            // 
            this.lblDrops.AutoSize = true;
            this.lblDrops.Location = new System.Drawing.Point(31, 92);
            this.lblDrops.Name = "lblDrops";
            this.lblDrops.Size = new System.Drawing.Size(105, 13);
            this.lblDrops.TabIndex = 9;
            this.lblDrops.Text = "card drops remaining";
            this.lblDrops.Visible = false;
            // 
            // lblIdle
            // 
            this.lblIdle.AutoSize = true;
            this.lblIdle.Location = new System.Drawing.Point(31, 108);
            this.lblIdle.Name = "lblIdle";
            this.lblIdle.Size = new System.Drawing.Size(86, 13);
            this.lblIdle.TabIndex = 10;
            this.lblIdle.Text = "games left to idle";
            this.lblIdle.Visible = false;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.Location = new System.Drawing.Point(15, 135);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentStatus.TabIndex = 11;
            this.lblCurrentStatus.Text = "Currently in-game";
            // 
            // lblCurrentRemaining
            // 
            this.lblCurrentRemaining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCurrentRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRemaining.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrentRemaining.Location = new System.Drawing.Point(18, 291);
            this.lblCurrentRemaining.Name = "lblCurrentRemaining";
            this.lblCurrentRemaining.Size = new System.Drawing.Size(320, 20);
            this.lblCurrentRemaining.TabIndex = 12;
            this.lblCurrentRemaining.Text = "3 card drops remaining";
            this.lblCurrentRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentRemaining.Click += new System.EventHandler(this.lblCurrentRemaining_Click);
            // 
            // lblGameName
            // 
            this.lblGameName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGameName.Location = new System.Drawing.Point(119, 135);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(159, 15);
            this.lblGameName.TabIndex = 16;
            this.lblGameName.TabStop = true;
            this.lblGameName.Text = "Game Name";
            this.lblGameName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGameName_LinkClicked);
            // 
            // mnuTop
            // 
            this.mnuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.quickToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuTop.Size = new System.Drawing.Size(350, 24);
            this.mnuTop.TabIndex = 19;
            this.mnuTop.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.blacklistToolStripMenuItem,
            this.FreeIdleMode,
            this.toolStripSeparator1,
            this.autoNextToolStripMenuItem,
            this.EnableImgToolStripMenuItem,
            this.ReloadToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgSettings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // blacklistToolStripMenuItem
            // 
            this.blacklistToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgBlacklist;
            this.blacklistToolStripMenuItem.Name = "blacklistToolStripMenuItem";
            this.blacklistToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.blacklistToolStripMenuItem.Text = "&Blacklist";
            this.blacklistToolStripMenuItem.Click += new System.EventHandler(this.blacklistToolStripMenuItem_Click);
            // 
            // FreeIdleMode
            // 
            this.FreeIdleMode.Name = "FreeIdleMode";
            this.FreeIdleMode.Size = new System.Drawing.Size(159, 22);
            this.FreeIdleMode.Text = "自由运行模式";
            this.FreeIdleMode.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // autoNextToolStripMenuItem
            // 
            this.autoNextToolStripMenuItem.Name = "autoNextToolStripMenuItem";
            this.autoNextToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.autoNextToolStripMenuItem.Text = "打开自动下一个";
            this.autoNextToolStripMenuItem.Click += new System.EventHandler(this.autoNextToolStripMenuItem_Click);
            // 
            // EnableImgToolStripMenuItem
            // 
            this.EnableImgToolStripMenuItem.Name = "EnableImgToolStripMenuItem";
            this.EnableImgToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.EnableImgToolStripMenuItem.Text = "打开图片显示";
            this.EnableImgToolStripMenuItem.Click += new System.EventHandler(this.EnableImgToolStripMenuItem_Click);
            // 
            // ReloadToolStripMenuItem
            // 
            this.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem";
            this.ReloadToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ReloadToolStripMenuItem.Text = "重新加载";
            this.ReloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgExit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseIdlingToolStripMenuItem,
            this.resumeIdlingToolStripMenuItem,
            this.skipGameToolStripMenuItem,
            this.toolStripMenuItem2,
            this.blacklistCurrentGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // pauseIdlingToolStripMenuItem
            // 
            this.pauseIdlingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseIdlingToolStripMenuItem.Image")));
            this.pauseIdlingToolStripMenuItem.Name = "pauseIdlingToolStripMenuItem";
            this.pauseIdlingToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pauseIdlingToolStripMenuItem.Text = "&Pause Idling";
            this.pauseIdlingToolStripMenuItem.Click += new System.EventHandler(this.pauseIdlingToolStripMenuItem_Click);
            // 
            // resumeIdlingToolStripMenuItem
            // 
            this.resumeIdlingToolStripMenuItem.Enabled = false;
            this.resumeIdlingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resumeIdlingToolStripMenuItem.Image")));
            this.resumeIdlingToolStripMenuItem.Name = "resumeIdlingToolStripMenuItem";
            this.resumeIdlingToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.resumeIdlingToolStripMenuItem.Text = "Resume Idling";
            this.resumeIdlingToolStripMenuItem.Click += new System.EventHandler(this.resumeIdlingToolStripMenuItem_Click);
            // 
            // skipGameToolStripMenuItem
            // 
            this.skipGameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("skipGameToolStripMenuItem.Image")));
            this.skipGameToolStripMenuItem.Name = "skipGameToolStripMenuItem";
            this.skipGameToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.skipGameToolStripMenuItem.Text = "&Skip Current Game";
            this.skipGameToolStripMenuItem.Click += new System.EventHandler(this.skipGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // blacklistCurrentGameToolStripMenuItem
            // 
            this.blacklistCurrentGameToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgBlacklist;
            this.blacklistCurrentGameToolStripMenuItem.Name = "blacklistCurrentGameToolStripMenuItem";
            this.blacklistCurrentGameToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.blacklistCurrentGameToolStripMenuItem.Text = "&Blacklist Current Game";
            this.blacklistCurrentGameToolStripMenuItem.Click += new System.EventHandler(this.blacklistCurrentGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.officialGroupToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgStatistics;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.statisticsToolStripMenuItem.Text = "&Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgDocument;
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changelogToolStripMenuItem.Text = "&Release Notes";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // officialGroupToolStripMenuItem
            // 
            this.officialGroupToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgGlobe;
            this.officialGroupToolStripMenuItem.Name = "officialGroupToolStripMenuItem";
            this.officialGroupToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.officialGroupToolStripMenuItem.Text = "&Official Group";
            this.officialGroupToolStripMenuItem.Click += new System.EventHandler(this.officialGroupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::IdleMaster.Properties.Resources.stcn;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem1.Text = "问题反馈和更新";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(158, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::IdleMaster.Properties.Resources.imgInfo;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quickToolStripMenuItem
            // 
            this.quickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.quickToolStripMenuItem.Name = "quickToolStripMenuItem";
            this.quickToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.quickToolStripMenuItem.Text = "Quick";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // tmrReadyToGo
            // 
            this.tmrReadyToGo.Enabled = true;
            this.tmrReadyToGo.Tick += new System.EventHandler(this.tmrReadyToGo_Tick);
            // 
            // tmrCardDropCheck
            // 
            this.tmrCardDropCheck.Interval = 1000;
            this.tmrCardDropCheck.Tick += new System.EventHandler(this.tmrCardDropCheck_Tick);
            // 
            // ssFooter
            // 
            this.ssFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pbIdle,
            this.toolStripStatusLabel1,
            this.lblTimer});
            this.ssFooter.Location = new System.Drawing.Point(0, 317);
            this.ssFooter.Name = "ssFooter";
            this.ssFooter.ShowItemToolTips = true;
            this.ssFooter.Size = new System.Drawing.Size(304, 22);
            this.ssFooter.SizingGrip = false;
            this.ssFooter.TabIndex = 20;
            this.ssFooter.Text = "statusStrip1";
            this.ssFooter.Visible = false;
            // 
            // pbIdle
            // 
            this.pbIdle.Name = "pbIdle";
            this.pbIdle.Size = new System.Drawing.Size(130, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "Next check";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimer
            // 
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(34, 17);
            this.lblTimer.Text = "15:00";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Idle Master";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // picReadingPage
            // 
            this.picReadingPage.Image = global::IdleMaster.Properties.Resources.imgSpin;
            this.picReadingPage.Location = new System.Drawing.Point(15, 90);
            this.picReadingPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReadingPage.Name = "picReadingPage";
            this.picReadingPage.Size = new System.Drawing.Size(15, 15);
            this.picReadingPage.TabIndex = 26;
            this.picReadingPage.TabStop = false;
            this.picReadingPage.Visible = false;
            // 
            // btnSkip
            // 
            this.btnSkip.Image = global::IdleMaster.Properties.Resources.imgSkipSmall;
            this.btnSkip.Location = new System.Drawing.Point(323, 133);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(15, 15);
            this.btnSkip.TabIndex = 23;
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // picIdleStatus
            // 
            this.picIdleStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picIdleStatus.Location = new System.Drawing.Point(332, 351);
            this.picIdleStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picIdleStatus.Name = "picIdleStatus";
            this.picIdleStatus.Size = new System.Drawing.Size(15, 15);
            this.picIdleStatus.TabIndex = 15;
            this.picIdleStatus.TabStop = false;
            // 
            // picCookieStatus
            // 
            this.picCookieStatus.Location = new System.Drawing.Point(15, 57);
            this.picCookieStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCookieStatus.Name = "picCookieStatus";
            this.picCookieStatus.Size = new System.Drawing.Size(15, 15);
            this.picCookieStatus.TabIndex = 8;
            this.picCookieStatus.TabStop = false;
            // 
            // picSteamStatus
            // 
            this.picSteamStatus.Location = new System.Drawing.Point(15, 34);
            this.picSteamStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSteamStatus.Name = "picSteamStatus";
            this.picSteamStatus.Size = new System.Drawing.Size(15, 15);
            this.picSteamStatus.TabIndex = 7;
            this.picSteamStatus.TabStop = false;
            // 
            // picApp
            // 
            this.picApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picApp.Location = new System.Drawing.Point(15, 154);
            this.picApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picApp.Name = "picApp";
            this.picApp.Size = new System.Drawing.Size(274, 139);
            this.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picApp.TabIndex = 6;
            this.picApp.TabStop = false;
            this.picApp.Visible = false;
            // 
            // btnPause
            // 
            this.btnPause.Image = global::IdleMaster.Properties.Resources.imgPauseSmall;
            this.btnPause.Location = new System.Drawing.Point(302, 133);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(15, 15);
            this.btnPause.TabIndex = 22;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Image = global::IdleMaster.Properties.Resources.imgPlaySmall;
            this.btnResume.Location = new System.Drawing.Point(302, 134);
            this.btnResume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(15, 15);
            this.btnResume.TabIndex = 24;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Visible = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // tmrStartNext
            // 
            this.tmrStartNext.Tick += new System.EventHandler(this.tmrStartNext_Tick);
            // 
            // tmrBadgeReload
            // 
            this.tmrBadgeReload.Interval = 1000;
            this.tmrBadgeReload.Tick += new System.EventHandler(this.tmrBadgeReload_Tick);
            // 
            // lblSignedOnAs
            // 
            this.lblSignedOnAs.AutoSize = true;
            this.lblSignedOnAs.Location = new System.Drawing.Point(30, 72);
            this.lblSignedOnAs.Name = "lblSignedOnAs";
            this.lblSignedOnAs.Size = new System.Drawing.Size(65, 13);
            this.lblSignedOnAs.TabIndex = 27;
            this.lblSignedOnAs.Text = "Signed in as";
            this.lblSignedOnAs.Visible = false;
            // 
            // GamesState
            // 
            this.GamesState.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameName,
            this.Hours});
            this.GamesState.HideSelection = false;
            this.GamesState.Location = new System.Drawing.Point(15, 154);
            this.GamesState.Margin = new System.Windows.Forms.Padding(2);
            this.GamesState.Name = "GamesState";
            this.GamesState.Size = new System.Drawing.Size(324, 139);
            this.GamesState.TabIndex = 28;
            this.GamesState.UseCompatibleStateImageBehavior = false;
            this.GamesState.View = System.Windows.Forms.View.Details;
            this.GamesState.Visible = false;
            // 
            // GameName
            // 
            this.GameName.Tag = "";
            this.GameName.Text = "Name";
            this.GameName.Width = 200;
            // 
            // Hours
            // 
            this.Hours.Text = "Hours";
            this.Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hours.Width = 45;
            // 
            // lblHoursPlayed
            // 
            this.lblHoursPlayed.AutoSize = true;
            this.lblHoursPlayed.Location = new System.Drawing.Point(15, 295);
            this.lblHoursPlayed.Name = "lblHoursPlayed";
            this.lblHoursPlayed.Size = new System.Drawing.Size(0, 13);
            this.lblHoursPlayed.TabIndex = 29;
            this.lblHoursPlayed.Visible = false;
            // 
            // tmrStatistics
            // 
            this.tmrStatistics.Interval = 60000;
            this.tmrStatistics.Tick += new System.EventHandler(this.tmrStatistics_Tick);
            // 
            // tmrAutoNext
            // 
            this.tmrAutoNext.Interval = 500;
            this.tmrAutoNext.Tick += new System.EventHandler(this.tmrAutoNext_Tick);
            // 
            // autonextlabel
            // 
            this.autonextlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autonextlabel.AutoSize = true;
            this.autonextlabel.ForeColor = System.Drawing.Color.Red;
            this.autonextlabel.Location = new System.Drawing.Point(256, 37);
            this.autonextlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.autonextlabel.Name = "autonextlabel";
            this.autonextlabel.Size = new System.Drawing.Size(91, 13);
            this.autonextlabel.TabIndex = 30;
            this.autonextlabel.Text = "关闭自动下一个";
            this.autonextlabel.Visible = false;
            this.autonextlabel.Click += new System.EventHandler(this.autonextlabel_Click);
            // 
            // AutoRestarter
            // 
            this.AutoRestarter.Enabled = true;
            this.AutoRestarter.Interval = 1000;
            this.AutoRestarter.Tick += new System.EventHandler(this.AutoRestarter_Tick);
            // 
            // labautorestart
            // 
            this.labautorestart.AutoSize = true;
            this.labautorestart.Location = new System.Drawing.Point(182, 108);
            this.labautorestart.Name = "labautorestart";
            this.labautorestart.Size = new System.Drawing.Size(35, 13);
            this.labautorestart.TabIndex = 31;
            this.labautorestart.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 371);
            this.Controls.Add(this.labautorestart);
            this.Controls.Add(this.autonextlabel);
            this.Controls.Add(this.lblHoursPlayed);
            this.Controls.Add(this.GamesState);
            this.Controls.Add(this.lblSignedOnAs);
            this.Controls.Add(this.picReadingPage);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.picIdleStatus);
            this.Controls.Add(this.lblCurrentRemaining);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblIdle);
            this.Controls.Add(this.lblDrops);
            this.Controls.Add(this.picCookieStatus);
            this.Controls.Add(this.picSteamStatus);
            this.Controls.Add(this.lnkSignIn);
            this.Controls.Add(this.lnkResetCookies);
            this.Controls.Add(this.lblSteamStatus);
            this.Controls.Add(this.lblCookieStatus);
            this.Controls.Add(this.mnuTop);
            this.Controls.Add(this.ssFooter);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.picApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idle Master HTTPS Fix";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClose);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.ssFooter.ResumeLayout(false);
            this.ssFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdleStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCookieStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSteamStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCookieStatus;
        private Timer tmrCheckCookieData;
        private Label lblSteamStatus;
        private Timer tmrCheckSteam;
        private LinkLabel lnkResetCookies;
        private LinkLabel lnkSignIn;
        private PictureBox picApp;
        private PictureBox picSteamStatus;
        private PictureBox picCookieStatus;
        private Label lblDrops;
        private Label lblIdle;
        private Label lblCurrentStatus;
        private Label lblCurrentRemaining;
        private PictureBox picIdleStatus;
        private LinkLabel lblGameName;
        private MenuStrip mnuTop;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Timer tmrReadyToGo;
        private Timer tmrCardDropCheck;
        private StatusStrip ssFooter;
        private ToolStripProgressBar pbIdle;
        private ToolStripStatusLabel lblTimer;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnPause;
        private Button btnSkip;
        private Button btnResume;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem pauseIdlingToolStripMenuItem;
        private ToolStripMenuItem resumeIdlingToolStripMenuItem;
        private ToolStripMenuItem skipGameToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private PictureBox picReadingPage;
        private ToolStripMenuItem blacklistToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem blacklistCurrentGameToolStripMenuItem;
        private Timer tmrStartNext;
        private ToolStripMenuItem changelogToolStripMenuItem;
        private ToolStripMenuItem officialGroupToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private Timer tmrBadgeReload;
        private Label lblSignedOnAs;
    private ListView GamesState;
    private ColumnHeader GameName;
    private ColumnHeader Hours;
    private Label lblHoursPlayed;
        private Timer tmrStatistics;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem autoNextToolStripMenuItem;
        private ToolStripMenuItem ReloadToolStripMenuItem;
        private Timer tmrAutoNext;
        private ToolStripSeparator toolStripSeparator1;
        private Label autonextlabel;
        private ToolStripMenuItem EnableImgToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem FreeIdleMode;
        private ToolStripMenuItem quickToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private Timer AutoRestarter;
        private Label labautorestart;
    }
}

