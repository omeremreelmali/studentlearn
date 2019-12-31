namespace WindowsFormsApp6
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.subDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.monthDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.showSubMonthButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.showQuizDayButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.monthDropDown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dayDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.studentCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-25, 292);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Paragraf";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Dil Bilgisi";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Anlatım Bozukluğu";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Şiir Bilgisi";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Divan Edebiyatı";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(689, 249);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(-16, 53);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Ay";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(404, 219);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // subDropDown
            // 
            this.subDropDown.BackColor = System.Drawing.Color.Transparent;
            this.subDropDown.BorderRadius = 3;
            this.subDropDown.ForeColor = System.Drawing.Color.White;
            this.subDropDown.Items = new string[] {
        "Paragraf",
        "Dil Bilgisi",
        "Anlatım Bozukluğu",
        "Şiir Bilgisi",
        "Divan Edebiyatı"};
            this.subDropDown.Location = new System.Drawing.Point(3, 36);
            this.subDropDown.Name = "subDropDown";
            this.subDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.subDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.subDropDown.selectedIndex = -1;
            this.subDropDown.Size = new System.Drawing.Size(103, 26);
            this.subDropDown.TabIndex = 2;
            // 
            // monthDropDown
            // 
            this.monthDropDown.BackColor = System.Drawing.Color.Transparent;
            this.monthDropDown.BorderRadius = 3;
            this.monthDropDown.ForeColor = System.Drawing.Color.White;
            this.monthDropDown.Items = new string[] {
        "Ocak",
        "Şubat",
        "Mart",
        "Nisan",
        "Mayıs",
        "Haziran",
        "Temmuz",
        "Ağustos",
        "Eylül",
        "Ekim",
        "Kasım",
        "Aralık"};
            this.monthDropDown.Location = new System.Drawing.Point(112, 36);
            this.monthDropDown.Name = "monthDropDown";
            this.monthDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.monthDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.monthDropDown.selectedIndex = -1;
            this.monthDropDown.Size = new System.Drawing.Size(97, 26);
            this.monthDropDown.TabIndex = 3;
            // 
            // showSubMonthButton
            // 
            this.showSubMonthButton.ActiveBorderThickness = 1;
            this.showSubMonthButton.ActiveCornerRadius = 20;
            this.showSubMonthButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.showSubMonthButton.ActiveForecolor = System.Drawing.Color.White;
            this.showSubMonthButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.showSubMonthButton.BackColor = System.Drawing.Color.White;
            this.showSubMonthButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showSubMonthButton.BackgroundImage")));
            this.showSubMonthButton.ButtonText = "Göster";
            this.showSubMonthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showSubMonthButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSubMonthButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.showSubMonthButton.IdleBorderThickness = 1;
            this.showSubMonthButton.IdleCornerRadius = 20;
            this.showSubMonthButton.IdleFillColor = System.Drawing.Color.White;
            this.showSubMonthButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.showSubMonthButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.showSubMonthButton.Location = new System.Drawing.Point(214, 28);
            this.showSubMonthButton.Margin = new System.Windows.Forms.Padding(4);
            this.showSubMonthButton.Name = "showSubMonthButton";
            this.showSubMonthButton.Size = new System.Drawing.Size(87, 37);
            this.showSubMonthButton.TabIndex = 16;
            this.showSubMonthButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showSubMonthButton.Click += new System.EventHandler(this.showSubMonthButton_Click);
            // 
            // showQuizDayButton
            // 
            this.showQuizDayButton.ActiveBorderThickness = 1;
            this.showQuizDayButton.ActiveCornerRadius = 20;
            this.showQuizDayButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.showQuizDayButton.ActiveForecolor = System.Drawing.Color.White;
            this.showQuizDayButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.showQuizDayButton.BackColor = System.Drawing.Color.White;
            this.showQuizDayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showQuizDayButton.BackgroundImage")));
            this.showQuizDayButton.ButtonText = "Göster";
            this.showQuizDayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showQuizDayButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showQuizDayButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.showQuizDayButton.IdleBorderThickness = 1;
            this.showQuizDayButton.IdleCornerRadius = 20;
            this.showQuizDayButton.IdleFillColor = System.Drawing.Color.White;
            this.showQuizDayButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.showQuizDayButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.showQuizDayButton.Location = new System.Drawing.Point(599, 15);
            this.showQuizDayButton.Margin = new System.Windows.Forms.Padding(4);
            this.showQuizDayButton.Name = "showQuizDayButton";
            this.showQuizDayButton.Size = new System.Drawing.Size(87, 37);
            this.showQuizDayButton.TabIndex = 20;
            this.showQuizDayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showQuizDayButton.Click += new System.EventHandler(this.showQuizDayButton_Click);
            // 
            // monthDropDown1
            // 
            this.monthDropDown1.BackColor = System.Drawing.Color.Transparent;
            this.monthDropDown1.BorderRadius = 3;
            this.monthDropDown1.ForeColor = System.Drawing.Color.White;
            this.monthDropDown1.Items = new string[] {
        "Ocak",
        "Şubat",
        "Mart",
        "Nisan",
        "Mayıs",
        "Haziran",
        "Temmuz",
        "Ağustos",
        "Eylül",
        "Ekim",
        "Kasım",
        "Aralık"};
            this.monthDropDown1.Location = new System.Drawing.Point(368, 22);
            this.monthDropDown1.Name = "monthDropDown1";
            this.monthDropDown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.monthDropDown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.monthDropDown1.selectedIndex = -1;
            this.monthDropDown1.Size = new System.Drawing.Size(97, 26);
            this.monthDropDown1.TabIndex = 19;
            // 
            // dayDropDown
            // 
            this.dayDropDown.BackColor = System.Drawing.Color.Transparent;
            this.dayDropDown.BorderRadius = 3;
            this.dayDropDown.ForeColor = System.Drawing.Color.White;
            this.dayDropDown.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12",
        "13",
        "14",
        "15",
        "16",
        "17",
        "18",
        "19",
        "20",
        "21",
        "22",
        "23",
        "24",
        "25",
        "26",
        "27",
        "28",
        "19",
        "30",
        "31"};
            this.dayDropDown.Location = new System.Drawing.Point(471, 22);
            this.dayDropDown.Name = "dayDropDown";
            this.dayDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dayDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dayDropDown.selectedIndex = -1;
            this.dayDropDown.Size = new System.Drawing.Size(103, 26);
            this.dayDropDown.TabIndex = 18;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(315, 53);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Paragraf";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Dil Bilgisi";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Anlatım Bozukluğu";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Şiir Bilgisi";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Divan Edebiyatı";
            this.chart3.Series.Add(series7);
            this.chart3.Series.Add(series8);
            this.chart3.Series.Add(series9);
            this.chart3.Series.Add(series10);
            this.chart3.Series.Add(series11);
            this.chart3.Size = new System.Drawing.Size(396, 219);
            this.chart3.TabIndex = 21;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Genel Durum";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(5, 11);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(81, 13);
            this.studentLabel.TabIndex = 24;
            this.studentLabel.Text = "Öğrenci Seçiniz";
            this.studentLabel.Visible = false;
            // 
            // studentCombobox
            // 
            this.studentCombobox.FormattingEnabled = true;
            this.studentCombobox.Location = new System.Drawing.Point(92, 7);
            this.studentCombobox.Name = "studentCombobox";
            this.studentCombobox.Size = new System.Drawing.Size(152, 21);
            this.studentCombobox.TabIndex = 25;
            this.studentCombobox.Visible = false;
            this.studentCombobox.SelectedIndexChanged += new System.EventHandler(this.studentCombobox_SelectedIndexChanged);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.studentCombobox);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.showQuizDayButton);
            this.Controls.Add(this.monthDropDown1);
            this.Controls.Add(this.dayDropDown);
            this.Controls.Add(this.showSubMonthButton);
            this.Controls.Add(this.monthDropDown);
            this.Controls.Add(this.subDropDown);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size(686, 599);
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Bunifu.Framework.UI.BunifuDropdown subDropDown;
        private Bunifu.Framework.UI.BunifuDropdown monthDropDown;
        private Bunifu.Framework.UI.BunifuThinButton2 showSubMonthButton;
        private Bunifu.Framework.UI.BunifuThinButton2 showQuizDayButton;
        private Bunifu.Framework.UI.BunifuDropdown monthDropDown1;
        private Bunifu.Framework.UI.BunifuDropdown dayDropDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.ComboBox studentCombobox;
    }
}
