namespace WindowsFormsApp6
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.statisticPageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.QuizOpPageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.quizPageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.loginTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuizOpPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizPageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.exitButton);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(750, 51);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 11);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(233, 25);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Öğrenci Sınav Projesi";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(717, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(22, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.statisticPageButton);
            this.bunifuGradientPanel2.Controls.Add(this.panel4);
            this.bunifuGradientPanel2.Controls.Add(this.QuizOpPageButton);
            this.bunifuGradientPanel2.Controls.Add(this.quizPageButton);
            this.bunifuGradientPanel2.Controls.Add(this.panel1);
            this.bunifuGradientPanel2.Controls.Add(this.panel2);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Gainsboro;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 51);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(64, 599);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // statisticPageButton
            // 
            this.statisticPageButton.BackColor = System.Drawing.Color.Transparent;
            this.statisticPageButton.Image = ((System.Drawing.Image)(resources.GetObject("statisticPageButton.Image")));
            this.statisticPageButton.ImageActive = null;
            this.statisticPageButton.Location = new System.Drawing.Point(16, 24);
            this.statisticPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.statisticPageButton.Name = "statisticPageButton";
            this.statisticPageButton.Size = new System.Drawing.Size(42, 50);
            this.statisticPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statisticPageButton.TabIndex = 23;
            this.statisticPageButton.TabStop = false;
            this.statisticPageButton.Zoom = 20;
            this.statisticPageButton.Click += new System.EventHandler(this.statisticPageButton_Click_1);
            this.statisticPageButton.MouseEnter += new System.EventHandler(this.BunifuImageButton2_MouseEnter_1);
            this.statisticPageButton.MouseLeave += new System.EventHandler(this.BunifuImageButton2_MouseLeave_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Location = new System.Drawing.Point(5, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 50);
            this.panel4.TabIndex = 24;
            this.panel4.Visible = false;
            // 
            // QuizOpPageButton
            // 
            this.QuizOpPageButton.BackColor = System.Drawing.Color.Transparent;
            this.QuizOpPageButton.Image = ((System.Drawing.Image)(resources.GetObject("QuizOpPageButton.Image")));
            this.QuizOpPageButton.ImageActive = null;
            this.QuizOpPageButton.Location = new System.Drawing.Point(16, 171);
            this.QuizOpPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuizOpPageButton.Name = "QuizOpPageButton";
            this.QuizOpPageButton.Size = new System.Drawing.Size(42, 50);
            this.QuizOpPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuizOpPageButton.TabIndex = 15;
            this.QuizOpPageButton.TabStop = false;
            this.QuizOpPageButton.Zoom = 20;
            this.QuizOpPageButton.Click += new System.EventHandler(this.QuizOpPageButton_Click);
            this.QuizOpPageButton.MouseEnter += new System.EventHandler(this.BunifuImageButton3_MouseEnter);
            this.QuizOpPageButton.MouseLeave += new System.EventHandler(this.BunifuImageButton3_MouseLeave);
            // 
            // quizPageButton
            // 
            this.quizPageButton.BackColor = System.Drawing.Color.Transparent;
            this.quizPageButton.Image = ((System.Drawing.Image)(resources.GetObject("quizPageButton.Image")));
            this.quizPageButton.ImageActive = null;
            this.quizPageButton.Location = new System.Drawing.Point(16, 93);
            this.quizPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.quizPageButton.Name = "quizPageButton";
            this.quizPageButton.Size = new System.Drawing.Size(42, 50);
            this.quizPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quizPageButton.TabIndex = 14;
            this.quizPageButton.TabStop = false;
            this.quizPageButton.Zoom = 20;
            this.quizPageButton.Click += new System.EventHandler(this.quizPageButton_Click);
            this.quizPageButton.MouseEnter += new System.EventHandler(this.BunifuImageButton2_MouseEnter);
            this.quizPageButton.MouseLeave += new System.EventHandler(this.BunifuImageButton2_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Location = new System.Drawing.Point(5, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 50);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Location = new System.Drawing.Point(5, 171);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 50);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.GradientBottomLeft = System.Drawing.Color.GhostWhite;
            this.panelMain.GradientBottomRight = System.Drawing.Color.GhostWhite;
            this.panelMain.GradientTopLeft = System.Drawing.Color.GhostWhite;
            this.panelMain.GradientTopRight = System.Drawing.Color.GhostWhite;
            this.panelMain.Location = new System.Drawing.Point(64, 51);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Quality = 10;
            this.panelMain.Size = new System.Drawing.Size(686, 599);
            this.panelMain.TabIndex = 3;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelMain;
            this.bunifuDragControl2.Vertical = true;
            // 
            // loginTimer
            // 
            this.loginTimer.Tick += new System.EventHandler(this.LoginTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // exitButton
            // 
            this.exitButton.ActiveBorderThickness = 1;
            this.exitButton.ActiveCornerRadius = 20;
            this.exitButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.exitButton.ActiveForecolor = System.Drawing.Color.White;
            this.exitButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.ButtonText = "Çıkış";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.exitButton.IdleBorderThickness = 1;
            this.exitButton.IdleCornerRadius = 20;
            this.exitButton.IdleFillColor = System.Drawing.Color.White;
            this.exitButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.exitButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.exitButton.Location = new System.Drawing.Point(657, -3);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(53, 31);
            this.exitButton.TabIndex = 26;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuizOpPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizPageButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMain;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton QuizOpPageButton;
        private Bunifu.Framework.UI.BunifuImageButton quizPageButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer loginTimer;
        private Bunifu.Framework.UI.BunifuImageButton statisticPageButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuThinButton2 exitButton;
    }
}

