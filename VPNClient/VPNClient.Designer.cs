namespace VPNClient
{
    partial class VPNClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPNClient));
            this.AllUsersPhoneBook = new DotRas.RasPhoneBook(this.components);
            this.Dialer = new DotRas.RasDialer(this.components);
            this.SettingBox = new System.Windows.Forms.GroupBox();
            this.tUserkey = new System.Windows.Forms.TextBox();
            this.lUserKey = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.tServerIP = new System.Windows.Forms.TextBox();
            this.lServerIP = new System.Windows.Forms.Label();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.tMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dialer
            // 
            // TODO: “”的代码生成失败，原因是出现异常“无效的基元类型: System.IntPtr。请考虑使用 CodeObjectCreateExpression。”。
            // TODO: “”的代码生成失败，原因是出现异常“无效的基元类型: System.IntPtr。请考虑使用 CodeObjectCreateExpression。”。
            this.Dialer.Credentials = null;
            this.Dialer.EapOptions = new DotRas.RasEapOptions(false, false, false);
            this.Dialer.Options = new DotRas.RasDialOptions(false, false, false, false, false, false, false, false, false, false, false);
            this.Dialer.StateChanged += new System.EventHandler<DotRas.StateChangedEventArgs>(this.Dialer_StateChanged);
            this.Dialer.DialCompleted += new System.EventHandler<DotRas.DialCompletedEventArgs>(this.Dialer_DialCompleted);
            this.Dialer.Error += new System.EventHandler<System.IO.ErrorEventArgs>(this.Dialer_Error);
            // 
            // SettingBox
            // 
            this.SettingBox.Controls.Add(this.tUserkey);
            this.SettingBox.Controls.Add(this.lUserKey);
            this.SettingBox.Controls.Add(this.tUsername);
            this.SettingBox.Controls.Add(this.lUsername);
            this.SettingBox.Controls.Add(this.tServerIP);
            this.SettingBox.Controls.Add(this.lServerIP);
            this.SettingBox.Location = new System.Drawing.Point(12, 62);
            this.SettingBox.Name = "SettingBox";
            this.SettingBox.Size = new System.Drawing.Size(268, 121);
            this.SettingBox.TabIndex = 2;
            this.SettingBox.TabStop = false;
            // 
            // tUserkey
            // 
            this.tUserkey.Location = new System.Drawing.Point(83, 75);
            this.tUserkey.Name = "tUserkey";
            this.tUserkey.PasswordChar = '*';
            this.tUserkey.Size = new System.Drawing.Size(166, 21);
            this.tUserkey.TabIndex = 5;
            this.tUserkey.Text = "hxedu";
            // 
            // lUserKey
            // 
            this.lUserKey.AutoSize = true;
            this.lUserKey.Location = new System.Drawing.Point(12, 79);
            this.lUserKey.Name = "lUserKey";
            this.lUserKey.Size = new System.Drawing.Size(65, 12);
            this.lUserKey.TabIndex = 4;
            this.lUserKey.Text = "用户密码：";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(83, 48);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(166, 21);
            this.tUsername.TabIndex = 3;
            this.tUsername.Text = "hxedu";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(12, 52);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(65, 12);
            this.lUsername.TabIndex = 2;
            this.lUsername.Text = "用户账号：";
            // 
            // tServerIP
            // 
            this.tServerIP.Location = new System.Drawing.Point(83, 21);
            this.tServerIP.Name = "tServerIP";
            this.tServerIP.Size = new System.Drawing.Size(166, 21);
            this.tServerIP.TabIndex = 1;
            this.tServerIP.Text = "60.30.156.187";
            // 
            // lServerIP
            // 
            this.lServerIP.AutoSize = true;
            this.lServerIP.Location = new System.Drawing.Point(12, 25);
            this.lServerIP.Name = "lServerIP";
            this.lServerIP.Size = new System.Drawing.Size(65, 12);
            this.lServerIP.TabIndex = 0;
            this.lServerIP.Text = "服务地址：";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(58, 189);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 3;
            this.bConnect.Text = "连接";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(139, 189);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 23);
            this.bDisconnect.TabIndex = 4;
            this.bDisconnect.Text = "断开";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // tMessage
            // 
            this.tMessage.Location = new System.Drawing.Point(11, 218);
            this.tMessage.Multiline = true;
            this.tMessage.Name = "tMessage";
            this.tMessage.ReadOnly = true;
            this.tMessage.Size = new System.Drawing.Size(268, 87);
            this.tMessage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "VPN";
            // 
            // VPNClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.SettingBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VPNClient";
            this.Text = "VPN";
            this.SettingBox.ResumeLayout(false);
            this.SettingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingBox;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.TextBox tUserkey;
        private System.Windows.Forms.Label lUserKey;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tServerIP;
        private System.Windows.Forms.Label lServerIP;

        private DotRas.RasPhoneBook AllUsersPhoneBook;
        private DotRas.RasDialer Dialer;
        private System.Windows.Forms.Label label1;
    }
}

