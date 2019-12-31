namespace WindowsFormsApp6
{
    partial class TabSign
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSign));
            this.userNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameText
            // 
            this.userNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameText.HintForeColor = System.Drawing.Color.Empty;
            this.userNameText.HintText = "Kullanıcı Adınızı Giriniz";
            this.userNameText.isPassword = false;
            this.userNameText.LineFocusedColor = System.Drawing.Color.Blue;
            this.userNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.userNameText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userNameText.LineThickness = 3;
            this.userNameText.Location = new System.Drawing.Point(275, 209);
            this.userNameText.Margin = new System.Windows.Forms.Padding(4);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(241, 32);
            this.userNameText.TabIndex = 13;
            this.userNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameText.OnValueChanged += new System.EventHandler(this.userNameText_OnValueChanged);
            // 
            // passText
            // 
            this.passText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passText.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.passText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passText.HintForeColor = System.Drawing.Color.Empty;
            this.passText.HintText = "";
            this.passText.isPassword = true;
            this.passText.LineFocusedColor = System.Drawing.Color.Blue;
            this.passText.LineIdleColor = System.Drawing.Color.Gray;
            this.passText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passText.LineThickness = 3;
            this.passText.Location = new System.Drawing.Point(275, 273);
            this.passText.Margin = new System.Windows.Forms.Padding(4);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(241, 32);
            this.passText.TabIndex = 14;
            this.passText.Text = "aa";
            this.passText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passText.OnValueChanged += new System.EventHandler(this.PassText_OnValueChanged);
            // 
            // loginButton
            // 
            this.loginButton.ActiveBorderThickness = 1;
            this.loginButton.ActiveCornerRadius = 20;
            this.loginButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginButton.ActiveForecolor = System.Drawing.Color.White;
            this.loginButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.ButtonText = "Giriş Yapın";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginButton.IdleBorderThickness = 1;
            this.loginButton.IdleCornerRadius = 20;
            this.loginButton.IdleFillColor = System.Drawing.Color.White;
            this.loginButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.loginButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.loginButton.Location = new System.Drawing.Point(248, 333);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(268, 41);
            this.loginButton.TabIndex = 15;
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(248, 219);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(21, 22);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 17;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(248, 283);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(21, 22);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 18;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(246, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Şifrenizi Giriniz";
            // 
            // usernameProvider
            // 
            this.usernameProvider.ContainerControl = this;
            // 
            // passwordProvider
            // 
            this.passwordProvider.ContainerControl = this;
            // 
            // TabSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userNameText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TabSign";
            this.Size = new System.Drawing.Size(686, 599);
            this.Load += new System.EventHandler(this.TabSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passText;
        private Bunifu.Framework.UI.BunifuThinButton2 loginButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider usernameProvider;
        private System.Windows.Forms.ErrorProvider passwordProvider;
    }
}
