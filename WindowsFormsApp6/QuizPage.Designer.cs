namespace WindowsFormsApp6
{
    partial class QuizPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizPage));
            this.aOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.questionTbox = new System.Windows.Forms.RichTextBox();
            this.eOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.questionNumberLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.questionsCountLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.trueReply = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.falseReply = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aOptionsButton
            // 
            this.aOptionsButton.ActiveBorderThickness = 1;
            this.aOptionsButton.ActiveCornerRadius = 20;
            this.aOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.aOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.BackColor = System.Drawing.Color.White;
            this.aOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aOptionsButton.BackgroundImage")));
            this.aOptionsButton.ButtonText = "";
            this.aOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.IdleBorderThickness = 1;
            this.aOptionsButton.IdleCornerRadius = 20;
            this.aOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.aOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.Location = new System.Drawing.Point(19, 154);
            this.aOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.aOptionsButton.Name = "aOptionsButton";
            this.aOptionsButton.Size = new System.Drawing.Size(643, 78);
            this.aOptionsButton.TabIndex = 29;
            this.aOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aOptionsButton.Click += new System.EventHandler(this.AOptionsButton_Click);
            // 
            // bOptionsButton
            // 
            this.bOptionsButton.ActiveBorderThickness = 1;
            this.bOptionsButton.ActiveCornerRadius = 20;
            this.bOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.bOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.BackColor = System.Drawing.Color.White;
            this.bOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bOptionsButton.BackgroundImage")));
            this.bOptionsButton.ButtonText = "";
            this.bOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.IdleBorderThickness = 1;
            this.bOptionsButton.IdleCornerRadius = 20;
            this.bOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.bOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.Location = new System.Drawing.Point(19, 228);
            this.bOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.bOptionsButton.Name = "bOptionsButton";
            this.bOptionsButton.Size = new System.Drawing.Size(643, 78);
            this.bOptionsButton.TabIndex = 30;
            this.bOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bOptionsButton.Click += new System.EventHandler(this.BOptionsButton_Click);
            // 
            // cOptionsButton
            // 
            this.cOptionsButton.ActiveBorderThickness = 1;
            this.cOptionsButton.ActiveCornerRadius = 20;
            this.cOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.cOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.BackColor = System.Drawing.Color.White;
            this.cOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cOptionsButton.BackgroundImage")));
            this.cOptionsButton.ButtonText = "";
            this.cOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.IdleBorderThickness = 1;
            this.cOptionsButton.IdleCornerRadius = 20;
            this.cOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.cOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.Location = new System.Drawing.Point(19, 302);
            this.cOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.cOptionsButton.Name = "cOptionsButton";
            this.cOptionsButton.Size = new System.Drawing.Size(643, 80);
            this.cOptionsButton.TabIndex = 31;
            this.cOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cOptionsButton.Click += new System.EventHandler(this.COptionsButton_Click);
            // 
            // dOptionsButton
            // 
            this.dOptionsButton.ActiveBorderThickness = 1;
            this.dOptionsButton.ActiveCornerRadius = 20;
            this.dOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.dOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.BackColor = System.Drawing.Color.White;
            this.dOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dOptionsButton.BackgroundImage")));
            this.dOptionsButton.ButtonText = "";
            this.dOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.IdleBorderThickness = 1;
            this.dOptionsButton.IdleCornerRadius = 20;
            this.dOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.dOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.Location = new System.Drawing.Point(19, 379);
            this.dOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.dOptionsButton.Name = "dOptionsButton";
            this.dOptionsButton.Size = new System.Drawing.Size(643, 80);
            this.dOptionsButton.TabIndex = 32;
            this.dOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dOptionsButton.Click += new System.EventHandler(this.DOptionsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.label1.Location = new System.Drawing.Point(161, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 33;
            // 
            // questionTbox
            // 
            this.questionTbox.Enabled = false;
            this.questionTbox.Location = new System.Drawing.Point(20, 12);
            this.questionTbox.Name = "questionTbox";
            this.questionTbox.Size = new System.Drawing.Size(486, 141);
            this.questionTbox.TabIndex = 34;
            this.questionTbox.Text = "";
            // 
            // eOptionsButton
            // 
            this.eOptionsButton.ActiveBorderThickness = 1;
            this.eOptionsButton.ActiveCornerRadius = 20;
            this.eOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.eOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.eOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.eOptionsButton.BackColor = System.Drawing.Color.White;
            this.eOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eOptionsButton.BackgroundImage")));
            this.eOptionsButton.ButtonText = "";
            this.eOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.eOptionsButton.IdleBorderThickness = 1;
            this.eOptionsButton.IdleCornerRadius = 20;
            this.eOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.eOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.eOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.eOptionsButton.Location = new System.Drawing.Point(19, 456);
            this.eOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.eOptionsButton.Name = "eOptionsButton";
            this.eOptionsButton.Size = new System.Drawing.Size(643, 80);
            this.eOptionsButton.TabIndex = 35;
            this.eOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eOptionsButton.Click += new System.EventHandler(this.eOptionsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(512, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.Location = new System.Drawing.Point(645, 6);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(17, 18);
            this.questionNumberLabel.TabIndex = 41;
            this.questionNumberLabel.Text = "1";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(593, 6);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(54, 18);
            this.bunifuCustomLabel1.TabIndex = 40;
            this.bunifuCustomLabel1.Text = "Soru :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 576);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(109, 18);
            this.bunifuCustomLabel2.TabIndex = 42;
            this.bunifuCustomLabel2.Text = "Soru Sayilari:";
            // 
            // questionsCountLabel
            // 
            this.questionsCountLabel.AutoSize = true;
            this.questionsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsCountLabel.Location = new System.Drawing.Point(125, 577);
            this.questionsCountLabel.Name = "questionsCountLabel";
            this.questionsCountLabel.Size = new System.Drawing.Size(17, 18);
            this.questionsCountLabel.TabIndex = 43;
            this.questionsCountLabel.Text = "1";
            // 
            // trueReply
            // 
            this.trueReply.AutoSize = true;
            this.trueReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueReply.Location = new System.Drawing.Point(139, 542);
            this.trueReply.Name = "trueReply";
            this.trueReply.Size = new System.Drawing.Size(17, 18);
            this.trueReply.TabIndex = 45;
            this.trueReply.Text = "1";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(15, 541);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(125, 18);
            this.bunifuCustomLabel4.TabIndex = 44;
            this.bunifuCustomLabel4.Text = "Doğru Cevaplar";
            // 
            // falseReply
            // 
            this.falseReply.AutoSize = true;
            this.falseReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseReply.Location = new System.Drawing.Point(140, 559);
            this.falseReply.Name = "falseReply";
            this.falseReply.Size = new System.Drawing.Size(17, 18);
            this.falseReply.TabIndex = 47;
            this.falseReply.Text = "1";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(16, 558);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(124, 18);
            this.bunifuCustomLabel5.TabIndex = 46;
            this.bunifuCustomLabel5.Text = "Yanlış Cevaplar";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(512, 6);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(17, 18);
            this.timeLabel.TabIndex = 48;
            this.timeLabel.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.falseReply);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.trueReply);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.questionsCountLabel);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.eOptionsButton);
            this.Controls.Add(this.questionTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dOptionsButton);
            this.Controls.Add(this.cOptionsButton);
            this.Controls.Add(this.bOptionsButton);
            this.Controls.Add(this.aOptionsButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuizPage";
            this.Size = new System.Drawing.Size(686, 599);
            this.Load += new System.EventHandler(this.QuizPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 aOptionsButton;
        private Bunifu.Framework.UI.BunifuThinButton2 bOptionsButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cOptionsButton;
        private Bunifu.Framework.UI.BunifuThinButton2 dOptionsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox questionTbox;
        private Bunifu.Framework.UI.BunifuThinButton2 eOptionsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel questionNumberLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel questionsCountLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel trueReply;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel falseReply;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel timeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
