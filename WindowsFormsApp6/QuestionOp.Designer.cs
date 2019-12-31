namespace WindowsFormsApp6
{
    partial class QuestionOp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionOp));
            this.picUrlTBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.deleteQuestionButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updateQuestionButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.questionListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectPhoto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.categoryTypeCombo = new System.Windows.Forms.ComboBox();
            this.addQuestionButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.replyTBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.alignLeft = new System.Windows.Forms.PictureBox();
            this.alignCenter = new System.Windows.Forms.PictureBox();
            this.alignRight = new System.Windows.Forms.PictureBox();
            this.fontChangeButton = new System.Windows.Forms.PictureBox();
            this.colorChangeButton = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.questionTbox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.questionUpdateButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelUpdateButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.replyTBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.replyTBox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.replyTBox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.replyTBox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.questionProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.replyProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.reply1Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.reply3Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.reply2Provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.reply4Provider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alignLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontChangeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorChangeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replyProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply1Provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply3Provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply2Provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply4Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // picUrlTBox
            // 
            this.picUrlTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picUrlTBox.Enabled = false;
            this.picUrlTBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.picUrlTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picUrlTBox.HintForeColor = System.Drawing.Color.Empty;
            this.picUrlTBox.HintText = "Resim Url";
            this.picUrlTBox.isPassword = false;
            this.picUrlTBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.picUrlTBox.LineIdleColor = System.Drawing.Color.Gray;
            this.picUrlTBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.picUrlTBox.LineThickness = 3;
            this.picUrlTBox.Location = new System.Drawing.Point(381, 132);
            this.picUrlTBox.Margin = new System.Windows.Forms.Padding(4);
            this.picUrlTBox.Name = "picUrlTBox";
            this.picUrlTBox.Size = new System.Drawing.Size(148, 32);
            this.picUrlTBox.TabIndex = 42;
            this.picUrlTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.ActiveBorderThickness = 1;
            this.deleteQuestionButton.ActiveCornerRadius = 20;
            this.deleteQuestionButton.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.deleteQuestionButton.ActiveForecolor = System.Drawing.Color.White;
            this.deleteQuestionButton.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.deleteQuestionButton.BackColor = System.Drawing.Color.White;
            this.deleteQuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteQuestionButton.BackgroundImage")));
            this.deleteQuestionButton.ButtonText = "Soruyu Sil";
            this.deleteQuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteQuestionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuestionButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteQuestionButton.IdleBorderThickness = 1;
            this.deleteQuestionButton.IdleCornerRadius = 20;
            this.deleteQuestionButton.IdleFillColor = System.Drawing.Color.White;
            this.deleteQuestionButton.IdleForecolor = System.Drawing.Color.DarkRed;
            this.deleteQuestionButton.IdleLineColor = System.Drawing.Color.DarkRed;
            this.deleteQuestionButton.Location = new System.Drawing.Point(477, 337);
            this.deleteQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(193, 33);
            this.deleteQuestionButton.TabIndex = 41;
            this.deleteQuestionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // updateQuestionButton
            // 
            this.updateQuestionButton.ActiveBorderThickness = 1;
            this.updateQuestionButton.ActiveCornerRadius = 20;
            this.updateQuestionButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.updateQuestionButton.ActiveForecolor = System.Drawing.Color.White;
            this.updateQuestionButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.updateQuestionButton.BackColor = System.Drawing.Color.White;
            this.updateQuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateQuestionButton.BackgroundImage")));
            this.updateQuestionButton.ButtonText = "Soruyu Düzenle";
            this.updateQuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateQuestionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuestionButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.updateQuestionButton.IdleBorderThickness = 1;
            this.updateQuestionButton.IdleCornerRadius = 20;
            this.updateQuestionButton.IdleFillColor = System.Drawing.Color.White;
            this.updateQuestionButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.updateQuestionButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.updateQuestionButton.Location = new System.Drawing.Point(477, 307);
            this.updateQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateQuestionButton.Name = "updateQuestionButton";
            this.updateQuestionButton.Size = new System.Drawing.Size(193, 33);
            this.updateQuestionButton.TabIndex = 40;
            this.updateQuestionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateQuestionButton.Click += new System.EventHandler(this.updateQuestionButton_Click);
            // 
            // questionListBox
            // 
            this.questionListBox.FormattingEnabled = true;
            this.questionListBox.Location = new System.Drawing.Point(7, 284);
            this.questionListBox.Name = "questionListBox";
            this.questionListBox.Size = new System.Drawing.Size(463, 303);
            this.questionListBox.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 5);
            this.panel1.TabIndex = 38;
            // 
            // selectPhoto
            // 
            this.selectPhoto.ActiveBorderThickness = 1;
            this.selectPhoto.ActiveCornerRadius = 20;
            this.selectPhoto.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.selectPhoto.ActiveForecolor = System.Drawing.Color.White;
            this.selectPhoto.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.selectPhoto.BackColor = System.Drawing.Color.White;
            this.selectPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectPhoto.BackgroundImage")));
            this.selectPhoto.ButtonText = "Resim Seç";
            this.selectPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPhoto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPhoto.ForeColor = System.Drawing.Color.SeaGreen;
            this.selectPhoto.IdleBorderThickness = 1;
            this.selectPhoto.IdleCornerRadius = 20;
            this.selectPhoto.IdleFillColor = System.Drawing.Color.White;
            this.selectPhoto.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.selectPhoto.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.selectPhoto.Location = new System.Drawing.Point(533, 133);
            this.selectPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.selectPhoto.Name = "selectPhoto";
            this.selectPhoto.Size = new System.Drawing.Size(138, 33);
            this.selectPhoto.TabIndex = 37;
            this.selectPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectPhoto.Click += new System.EventHandler(this.selectPhoto_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(378, 171);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(46, 13);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "Kategori";
            // 
            // categoryTypeCombo
            // 
            this.categoryTypeCombo.FormattingEnabled = true;
            this.categoryTypeCombo.Location = new System.Drawing.Point(426, 168);
            this.categoryTypeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTypeCombo.Name = "categoryTypeCombo";
            this.categoryTypeCombo.Size = new System.Drawing.Size(242, 21);
            this.categoryTypeCombo.TabIndex = 35;
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.ActiveBorderThickness = 1;
            this.addQuestionButton.ActiveCornerRadius = 20;
            this.addQuestionButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addQuestionButton.ActiveForecolor = System.Drawing.Color.White;
            this.addQuestionButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addQuestionButton.BackColor = System.Drawing.Color.White;
            this.addQuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addQuestionButton.BackgroundImage")));
            this.addQuestionButton.ButtonText = "Soruyu Ekle";
            this.addQuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addQuestionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestionButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.addQuestionButton.IdleBorderThickness = 1;
            this.addQuestionButton.IdleCornerRadius = 20;
            this.addQuestionButton.IdleFillColor = System.Drawing.Color.White;
            this.addQuestionButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addQuestionButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addQuestionButton.Location = new System.Drawing.Point(381, 188);
            this.addQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(289, 33);
            this.addQuestionButton.TabIndex = 32;
            this.addQuestionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // replyTBox
            // 
            this.replyTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.replyTBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.replyTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.replyTBox.HintForeColor = System.Drawing.Color.Empty;
            this.replyTBox.HintText = "Cevabı yazınız";
            this.replyTBox.isPassword = false;
            this.replyTBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.replyTBox.LineIdleColor = System.Drawing.Color.Gray;
            this.replyTBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.replyTBox.LineThickness = 3;
            this.replyTBox.Location = new System.Drawing.Point(382, 40);
            this.replyTBox.Margin = new System.Windows.Forms.Padding(4);
            this.replyTBox.Name = "replyTBox";
            this.replyTBox.Size = new System.Drawing.Size(131, 28);
            this.replyTBox.TabIndex = 31;
            this.replyTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.replyTBox.OnValueChanged += new System.EventHandler(this.replyTBox_OnValueChanged);
            // 
            // alignLeft
            // 
            this.alignLeft.Image = ((System.Drawing.Image)(resources.GetObject("alignLeft.Image")));
            this.alignLeft.Location = new System.Drawing.Point(304, 12);
            this.alignLeft.Name = "alignLeft";
            this.alignLeft.Size = new System.Drawing.Size(22, 22);
            this.alignLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alignLeft.TabIndex = 43;
            this.alignLeft.TabStop = false;
            this.alignLeft.Click += new System.EventHandler(this.alignLeft_Click);
            // 
            // alignCenter
            // 
            this.alignCenter.Image = ((System.Drawing.Image)(resources.GetObject("alignCenter.Image")));
            this.alignCenter.Location = new System.Drawing.Point(327, 12);
            this.alignCenter.Name = "alignCenter";
            this.alignCenter.Size = new System.Drawing.Size(22, 22);
            this.alignCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alignCenter.TabIndex = 45;
            this.alignCenter.TabStop = false;
            this.alignCenter.Click += new System.EventHandler(this.alignCenter_Click);
            // 
            // alignRight
            // 
            this.alignRight.Image = ((System.Drawing.Image)(resources.GetObject("alignRight.Image")));
            this.alignRight.Location = new System.Drawing.Point(351, 12);
            this.alignRight.Name = "alignRight";
            this.alignRight.Size = new System.Drawing.Size(22, 22);
            this.alignRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alignRight.TabIndex = 46;
            this.alignRight.TabStop = false;
            this.alignRight.Click += new System.EventHandler(this.alignRight_Click);
            // 
            // fontChangeButton
            // 
            this.fontChangeButton.Image = ((System.Drawing.Image)(resources.GetObject("fontChangeButton.Image")));
            this.fontChangeButton.Location = new System.Drawing.Point(7, 12);
            this.fontChangeButton.Name = "fontChangeButton";
            this.fontChangeButton.Size = new System.Drawing.Size(22, 22);
            this.fontChangeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fontChangeButton.TabIndex = 47;
            this.fontChangeButton.TabStop = false;
            this.fontChangeButton.Click += new System.EventHandler(this.fontChangeButton_Click);
            // 
            // colorChangeButton
            // 
            this.colorChangeButton.Image = ((System.Drawing.Image)(resources.GetObject("colorChangeButton.Image")));
            this.colorChangeButton.Location = new System.Drawing.Point(32, 12);
            this.colorChangeButton.Name = "colorChangeButton";
            this.colorChangeButton.Size = new System.Drawing.Size(22, 22);
            this.colorChangeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorChangeButton.TabIndex = 48;
            this.colorChangeButton.TabStop = false;
            this.colorChangeButton.Click += new System.EventHandler(this.colorChangeButton_Click);
            // 
            // questionTbox
            // 
            this.questionTbox.Location = new System.Drawing.Point(7, 40);
            this.questionTbox.Name = "questionTbox";
            this.questionTbox.Size = new System.Drawing.Size(366, 206);
            this.questionTbox.TabIndex = 49;
            this.questionTbox.Text = "";
            this.questionTbox.TextChanged += new System.EventHandler(this.questionTbox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // questionUpdateButton
            // 
            this.questionUpdateButton.ActiveBorderThickness = 1;
            this.questionUpdateButton.ActiveCornerRadius = 20;
            this.questionUpdateButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.questionUpdateButton.ActiveForecolor = System.Drawing.Color.White;
            this.questionUpdateButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.questionUpdateButton.BackColor = System.Drawing.Color.White;
            this.questionUpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("questionUpdateButton.BackgroundImage")));
            this.questionUpdateButton.ButtonText = "Soruyu Güncelle";
            this.questionUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionUpdateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionUpdateButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.questionUpdateButton.IdleBorderThickness = 1;
            this.questionUpdateButton.IdleCornerRadius = 20;
            this.questionUpdateButton.IdleFillColor = System.Drawing.Color.White;
            this.questionUpdateButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.questionUpdateButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.questionUpdateButton.Location = new System.Drawing.Point(381, 198);
            this.questionUpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.questionUpdateButton.Name = "questionUpdateButton";
            this.questionUpdateButton.Size = new System.Drawing.Size(289, 33);
            this.questionUpdateButton.TabIndex = 53;
            this.questionUpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionUpdateButton.Visible = false;
            this.questionUpdateButton.Click += new System.EventHandler(this.questionUpdateButton_Click);
            // 
            // cancelUpdateButton
            // 
            this.cancelUpdateButton.ActiveBorderThickness = 1;
            this.cancelUpdateButton.ActiveCornerRadius = 20;
            this.cancelUpdateButton.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.cancelUpdateButton.ActiveForecolor = System.Drawing.Color.White;
            this.cancelUpdateButton.ActiveLineColor = System.Drawing.Color.DarkRed;
            this.cancelUpdateButton.BackColor = System.Drawing.Color.White;
            this.cancelUpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelUpdateButton.BackgroundImage")));
            this.cancelUpdateButton.ButtonText = "İptal";
            this.cancelUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelUpdateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelUpdateButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelUpdateButton.IdleBorderThickness = 1;
            this.cancelUpdateButton.IdleCornerRadius = 20;
            this.cancelUpdateButton.IdleFillColor = System.Drawing.Color.White;
            this.cancelUpdateButton.IdleForecolor = System.Drawing.Color.DarkRed;
            this.cancelUpdateButton.IdleLineColor = System.Drawing.Color.DarkRed;
            this.cancelUpdateButton.Location = new System.Drawing.Point(470, 217);
            this.cancelUpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelUpdateButton.Name = "cancelUpdateButton";
            this.cancelUpdateButton.Size = new System.Drawing.Size(102, 33);
            this.cancelUpdateButton.TabIndex = 54;
            this.cancelUpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelUpdateButton.Click += new System.EventHandler(this.cancelUpdateButton_Click);
            // 
            // replyTBox1
            // 
            this.replyTBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.replyTBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.replyTBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.replyTBox1.HintForeColor = System.Drawing.Color.Empty;
            this.replyTBox1.HintText = "Yanlış cevabı yazınız";
            this.replyTBox1.isPassword = false;
            this.replyTBox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.replyTBox1.LineIdleColor = System.Drawing.Color.Gray;
            this.replyTBox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.replyTBox1.LineThickness = 3;
            this.replyTBox1.Location = new System.Drawing.Point(520, 40);
            this.replyTBox1.Margin = new System.Windows.Forms.Padding(4);
            this.replyTBox1.Name = "replyTBox1";
            this.replyTBox1.Size = new System.Drawing.Size(131, 28);
            this.replyTBox1.TabIndex = 55;
            this.replyTBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.replyTBox1.OnValueChanged += new System.EventHandler(this.replyTBox1_OnValueChanged);
            // 
            // replyTBox2
            // 
            this.replyTBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.replyTBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.replyTBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.replyTBox2.HintForeColor = System.Drawing.Color.Empty;
            this.replyTBox2.HintText = "Yanlış cevabı yazınız";
            this.replyTBox2.isPassword = false;
            this.replyTBox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.replyTBox2.LineIdleColor = System.Drawing.Color.Gray;
            this.replyTBox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.replyTBox2.LineThickness = 3;
            this.replyTBox2.Location = new System.Drawing.Point(383, 71);
            this.replyTBox2.Margin = new System.Windows.Forms.Padding(4);
            this.replyTBox2.Name = "replyTBox2";
            this.replyTBox2.Size = new System.Drawing.Size(131, 28);
            this.replyTBox2.TabIndex = 56;
            this.replyTBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.replyTBox2.OnValueChanged += new System.EventHandler(this.replyTBox2_OnValueChanged);
            // 
            // replyTBox3
            // 
            this.replyTBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.replyTBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.replyTBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.replyTBox3.HintForeColor = System.Drawing.Color.Empty;
            this.replyTBox3.HintText = "Yanlış cevabı yazınız";
            this.replyTBox3.isPassword = false;
            this.replyTBox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.replyTBox3.LineIdleColor = System.Drawing.Color.Gray;
            this.replyTBox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.replyTBox3.LineThickness = 3;
            this.replyTBox3.Location = new System.Drawing.Point(522, 71);
            this.replyTBox3.Margin = new System.Windows.Forms.Padding(4);
            this.replyTBox3.Name = "replyTBox3";
            this.replyTBox3.Size = new System.Drawing.Size(131, 28);
            this.replyTBox3.TabIndex = 57;
            this.replyTBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.replyTBox3.OnValueChanged += new System.EventHandler(this.replyTBox3_OnValueChanged);
            // 
            // replyTBox4
            // 
            this.replyTBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.replyTBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.replyTBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.replyTBox4.HintForeColor = System.Drawing.Color.Empty;
            this.replyTBox4.HintText = "Yanlış cevabı yazınız";
            this.replyTBox4.isPassword = false;
            this.replyTBox4.LineFocusedColor = System.Drawing.Color.Blue;
            this.replyTBox4.LineIdleColor = System.Drawing.Color.Gray;
            this.replyTBox4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.replyTBox4.LineThickness = 3;
            this.replyTBox4.Location = new System.Drawing.Point(383, 102);
            this.replyTBox4.Margin = new System.Windows.Forms.Padding(4);
            this.replyTBox4.Name = "replyTBox4";
            this.replyTBox4.Size = new System.Drawing.Size(131, 28);
            this.replyTBox4.TabIndex = 58;
            this.replyTBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.replyTBox4.OnValueChanged += new System.EventHandler(this.replyTBox4_OnValueChanged);
            // 
            // questionProvider
            // 
            this.questionProvider.ContainerControl = this;
            // 
            // replyProvider
            // 
            this.replyProvider.ContainerControl = this;
            // 
            // reply1Provider
            // 
            this.reply1Provider.ContainerControl = this;
            // 
            // reply3Provider
            // 
            this.reply3Provider.ContainerControl = this;
            // 
            // reply2Provider
            // 
            this.reply2Provider.ContainerControl = this;
            // 
            // reply4Provider
            // 
            this.reply4Provider.ContainerControl = this;
            // 
            // QuestionOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.replyTBox4);
            this.Controls.Add(this.replyTBox3);
            this.Controls.Add(this.replyTBox2);
            this.Controls.Add(this.replyTBox1);
            this.Controls.Add(this.cancelUpdateButton);
            this.Controls.Add(this.questionUpdateButton);
            this.Controls.Add(this.questionTbox);
            this.Controls.Add(this.colorChangeButton);
            this.Controls.Add(this.fontChangeButton);
            this.Controls.Add(this.alignRight);
            this.Controls.Add(this.alignCenter);
            this.Controls.Add(this.alignLeft);
            this.Controls.Add(this.picUrlTBox);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.updateQuestionButton);
            this.Controls.Add(this.questionListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectPhoto);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.categoryTypeCombo);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.replyTBox);
            this.Name = "QuestionOp";
            this.Size = new System.Drawing.Size(686, 599);
            this.Load += new System.EventHandler(this.QuestionOp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alignLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontChangeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorChangeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replyProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply1Provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply3Provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply2Provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reply4Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox picUrlTBox;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteQuestionButton;
        private Bunifu.Framework.UI.BunifuThinButton2 updateQuestionButton;
        private System.Windows.Forms.ListBox questionListBox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 selectPhoto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox categoryTypeCombo;
        private Bunifu.Framework.UI.BunifuThinButton2 addQuestionButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox replyTBox;
        private System.Windows.Forms.PictureBox alignLeft;
        private System.Windows.Forms.PictureBox alignCenter;
        private System.Windows.Forms.PictureBox alignRight;
        private System.Windows.Forms.PictureBox fontChangeButton;
        private System.Windows.Forms.PictureBox colorChangeButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox questionTbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuThinButton2 questionUpdateButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelUpdateButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox replyTBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox replyTBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox replyTBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox replyTBox4;
        private System.Windows.Forms.ErrorProvider questionProvider;
        private System.Windows.Forms.ErrorProvider replyProvider;
        private System.Windows.Forms.ErrorProvider reply1Provider;
        private System.Windows.Forms.ErrorProvider reply3Provider;
        private System.Windows.Forms.ErrorProvider reply2Provider;
        private System.Windows.Forms.ErrorProvider reply4Provider;
    }
}
