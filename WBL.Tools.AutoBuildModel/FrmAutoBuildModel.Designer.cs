namespace WBL.Tools.AutoBuildModel
{
    partial class FrmAutoBuildModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoBuildModel));
            this.btnReLogin = new System.Windows.Forms.Button();
            this.fbdShowFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lnklblBlog = new System.Windows.Forms.LinkLabel();
            this.grpOperation.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReLogin
            // 
            this.btnReLogin.Enabled = false;
            this.btnReLogin.Location = new System.Drawing.Point(394, 310);
            this.btnReLogin.Name = "btnReLogin";
            this.btnReLogin.Size = new System.Drawing.Size(75, 23);
            this.btnReLogin.TabIndex = 23;
            this.btnReLogin.Text = "重新登录";
            this.btnReLogin.UseVisualStyleBackColor = true;
            this.btnReLogin.Click += new System.EventHandler(this.btnReLogin_Click);
            // 
            // fbdShowFilePath
            // 
            this.fbdShowFilePath.SelectedPath = "C:\\Documents and Settings\\Administrator\\桌面";
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.txtPath);
            this.grpOperation.Controls.Add(this.txtModelName);
            this.grpOperation.Controls.Add(this.label6);
            this.grpOperation.Controls.Add(this.btnOK);
            this.grpOperation.Controls.Add(this.btnShow);
            this.grpOperation.Controls.Add(this.label7);
            this.grpOperation.Enabled = false;
            this.grpOperation.Location = new System.Drawing.Point(12, 152);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(548, 114);
            this.grpOperation.TabIndex = 22;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "操作";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(89, 31);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(368, 21);
            this.txtPath.TabIndex = 6;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(119, 75);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(215, 21);
            this.txtModelName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "保存路径:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(411, 73);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "生成实体类";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(463, 29);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(48, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "预览";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Model命名空间:";
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.txtLoginName);
            this.grpLogin.Controls.Add(this.txtLoginPwd);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.txtDBName);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.txtSerName);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.label4);
            this.grpLogin.Controls.Add(this.label3);
            this.grpLogin.Location = new System.Drawing.Point(12, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(544, 134);
            this.grpLogin.TabIndex = 21;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "登录信息";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(89, 65);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(164, 21);
            this.txtLoginName.TabIndex = 3;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point(333, 65);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(178, 21);
            this.txtLoginPwd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器名:";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(333, 26);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(178, 21);
            this.txtDBName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "登录名:";
            // 
            // txtSerName
            // 
            this.txtSerName.Location = new System.Drawing.Point(89, 26);
            this.txtSerName.Name = "txtSerName";
            this.txtSerName.Size = new System.Drawing.Size(164, 21);
            this.txtSerName.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(463, 96);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(48, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "登录密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据库名:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(77, 281);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(245, 12);
            this.lblMsg.TabIndex = 18;
            this.lblMsg.Text = "您尚未登录，登录成功后才能进行生成工作！";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(475, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "登录提示：";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(12, 315);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(65, 12);
            this.lblPrompt.TabIndex = 24;
            this.lblPrompt.Text = "交流博客：";
            // 
            // lnklblBlog
            // 
            this.lnklblBlog.AutoSize = true;
            this.lnklblBlog.Location = new System.Drawing.Point(83, 315);
            this.lnklblBlog.Name = "lnklblBlog";
            this.lnklblBlog.Size = new System.Drawing.Size(185, 12);
            this.lnklblBlog.TabIndex = 25;
            this.lnklblBlog.TabStop = true;
            this.lnklblBlog.Text = "http://www.cnblogs.com/wbl168/";
            this.lnklblBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBlog_LinkClicked);
            // 
            // FrmAutoBuildModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 353);
            this.Controls.Add(this.lnklblBlog);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnReLogin);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAutoBuildModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动生成Model";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAutoBuildModel_FormClosing);
            this.grpOperation.ResumeLayout(false);
            this.grpOperation.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReLogin;
        private System.Windows.Forms.FolderBrowserDialog fbdShowFilePath;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.LinkLabel lnklblBlog;
    }
}