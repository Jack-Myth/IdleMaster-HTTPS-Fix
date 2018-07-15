namespace IdleMaster
{
    partial class frmWagaSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWagaSettings));
            this.changetimegroupBox = new System.Windows.Forms.GroupBox();
            this.mslabel = new System.Windows.Forms.Label();
            this.timebox = new System.Windows.Forms.TextBox();
            this.changeautonextime = new System.Windows.Forms.Button();
            this.aboutlabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.changeminruntimegroupBox = new System.Windows.Forms.GroupBox();
            this.changeminruntimelabel = new System.Windows.Forms.Label();
            this.changeminruntimetextBox = new System.Windows.Forms.TextBox();
            this.changeminruntimebutton = new System.Windows.Forms.Button();
            this.changetimegroupBox.SuspendLayout();
            this.changeminruntimegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // changetimegroupBox
            // 
            this.changetimegroupBox.Controls.Add(this.mslabel);
            this.changetimegroupBox.Controls.Add(this.timebox);
            this.changetimegroupBox.Controls.Add(this.changeautonextime);
            this.changetimegroupBox.Location = new System.Drawing.Point(12, 12);
            this.changetimegroupBox.Name = "changetimegroupBox";
            this.changetimegroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changetimegroupBox.Size = new System.Drawing.Size(523, 68);
            this.changetimegroupBox.TabIndex = 8;
            this.changetimegroupBox.TabStop = false;
            this.changetimegroupBox.Text = "修改自动切换游戏时间间隔";
            // 
            // mslabel
            // 
            this.mslabel.AutoSize = true;
            this.mslabel.Location = new System.Drawing.Point(91, 30);
            this.mslabel.Name = "mslabel";
            this.mslabel.Size = new System.Drawing.Size(23, 15);
            this.mslabel.TabIndex = 2;
            this.mslabel.Text = "ms";
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(11, 24);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(73, 25);
            this.timebox.TabIndex = 1;
            // 
            // changeautonextime
            // 
            this.changeautonextime.Location = new System.Drawing.Point(119, 24);
            this.changeautonextime.Name = "changeautonextime";
            this.changeautonextime.Size = new System.Drawing.Size(100, 27);
            this.changeautonextime.TabIndex = 0;
            this.changeautonextime.Text = "确定";
            this.changeautonextime.UseVisualStyleBackColor = true;
            this.changeautonextime.Click += new System.EventHandler(this.changeautonextime_Click);
            // 
            // aboutlabel
            // 
            this.aboutlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutlabel.AutoSize = true;
            this.aboutlabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aboutlabel.Location = new System.Drawing.Point(12, 174);
            this.aboutlabel.Name = "aboutlabel";
            this.aboutlabel.Size = new System.Drawing.Size(199, 20);
            this.aboutlabel.TabIndex = 9;
            this.aboutlabel.Text = "哇嘎吖噜哒 魔改制作";
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VersionLabel.Location = new System.Drawing.Point(415, 174);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(129, 20);
            this.VersionLabel.TabIndex = 10;
            this.VersionLabel.Text = "V1.3.1(11.7)";
            // 
            // changeminruntimegroupBox
            // 
            this.changeminruntimegroupBox.Controls.Add(this.changeminruntimelabel);
            this.changeminruntimegroupBox.Controls.Add(this.changeminruntimetextBox);
            this.changeminruntimegroupBox.Controls.Add(this.changeminruntimebutton);
            this.changeminruntimegroupBox.Location = new System.Drawing.Point(12, 86);
            this.changeminruntimegroupBox.Name = "changeminruntimegroupBox";
            this.changeminruntimegroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changeminruntimegroupBox.Size = new System.Drawing.Size(523, 68);
            this.changeminruntimegroupBox.TabIndex = 9;
            this.changeminruntimegroupBox.TabStop = false;
            this.changeminruntimegroupBox.Text = "修改最小运行时间";
            // 
            // changeminruntimelabel
            // 
            this.changeminruntimelabel.AutoSize = true;
            this.changeminruntimelabel.Location = new System.Drawing.Point(91, 30);
            this.changeminruntimelabel.Name = "changeminruntimelabel";
            this.changeminruntimelabel.Size = new System.Drawing.Size(15, 15);
            this.changeminruntimelabel.TabIndex = 2;
            this.changeminruntimelabel.Text = "h";
            // 
            // changeminruntimetextBox
            // 
            this.changeminruntimetextBox.Location = new System.Drawing.Point(11, 24);
            this.changeminruntimetextBox.Name = "changeminruntimetextBox";
            this.changeminruntimetextBox.Size = new System.Drawing.Size(73, 25);
            this.changeminruntimetextBox.TabIndex = 1;
            // 
            // changeminruntimebutton
            // 
            this.changeminruntimebutton.Location = new System.Drawing.Point(119, 24);
            this.changeminruntimebutton.Name = "changeminruntimebutton";
            this.changeminruntimebutton.Size = new System.Drawing.Size(100, 27);
            this.changeminruntimebutton.TabIndex = 0;
            this.changeminruntimebutton.Text = "确定";
            this.changeminruntimebutton.UseVisualStyleBackColor = true;
            this.changeminruntimebutton.Click += new System.EventHandler(this.changeminruntimebutton_Click);
            // 
            // frmWagaSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 203);
            this.Controls.Add(this.changeminruntimegroupBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.aboutlabel);
            this.Controls.Add(this.changetimegroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWagaSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔改设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWagaSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmWagaSettings_Load);
            this.changetimegroupBox.ResumeLayout(false);
            this.changetimegroupBox.PerformLayout();
            this.changeminruntimegroupBox.ResumeLayout(false);
            this.changeminruntimegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox changetimegroupBox;
        private System.Windows.Forms.Label mslabel;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.Button changeautonextime;
        private System.Windows.Forms.Label aboutlabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.GroupBox changeminruntimegroupBox;
        private System.Windows.Forms.Label changeminruntimelabel;
        private System.Windows.Forms.TextBox changeminruntimetextBox;
        private System.Windows.Forms.Button changeminruntimebutton;
    }
}