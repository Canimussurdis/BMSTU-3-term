
namespace ChartsVisualisation
{
    partial class Irises
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.FileSelect = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sepalLengthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sepalWidthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petalLengthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petalWidthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepalLengthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepalWidthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petalLengthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petalWidthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // FileSelect
            // 
            this.FileSelect.Location = new System.Drawing.Point(8, 50);
            this.FileSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileSelect.Name = "FileSelect";
            this.FileSelect.Size = new System.Drawing.Size(118, 42);
            this.FileSelect.TabIndex = 0;
            this.FileSelect.Text = "SelectFile";
            this.FileSelect.UseVisualStyleBackColor = true;
            this.FileSelect.Click += new System.EventHandler(this.FileSelect_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(8, 15);
            this.FileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(118, 26);
            this.FileName.TabIndex = 1;
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(815, 117);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(628, 773);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // sepalLengthChart
            // 
            chartArea7.Name = "ChartArea1";
            this.sepalLengthChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.sepalLengthChart.Legends.Add(legend7);
            this.sepalLengthChart.Location = new System.Drawing.Point(68, 117);
            this.sepalLengthChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sepalLengthChart.Name = "sepalLengthChart";
            this.sepalLengthChart.Size = new System.Drawing.Size(271, 326);
            this.sepalLengthChart.TabIndex = 9;
            this.sepalLengthChart.Text = "chart1";
            // 
            // sepalWidthChart
            // 
            chartArea8.Name = "ChartArea1";
            this.sepalWidthChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.sepalWidthChart.Legends.Add(legend8);
            this.sepalWidthChart.Location = new System.Drawing.Point(478, 117);
            this.sepalWidthChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sepalWidthChart.Name = "sepalWidthChart";
            this.sepalWidthChart.Size = new System.Drawing.Size(285, 326);
            this.sepalWidthChart.TabIndex = 10;
            this.sepalWidthChart.Text = "chart1";
            // 
            // petalLengthChart
            // 
            chartArea9.Name = "ChartArea1";
            this.petalLengthChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.petalLengthChart.Legends.Add(legend9);
            this.petalLengthChart.Location = new System.Drawing.Point(69, 465);
            this.petalLengthChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.petalLengthChart.Name = "petalLengthChart";
            this.petalLengthChart.Size = new System.Drawing.Size(270, 393);
            this.petalLengthChart.TabIndex = 11;
            this.petalLengthChart.Text = "chart1";
            // 
            // petalWidthChart
            // 
            chartArea10.Name = "ChartArea1";
            this.petalWidthChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.petalWidthChart.Legends.Add(legend10);
            this.petalWidthChart.Location = new System.Drawing.Point(478, 465);
            this.petalWidthChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.petalWidthChart.Name = "petalWidthChart";
            this.petalWidthChart.Size = new System.Drawing.Size(285, 393);
            this.petalWidthChart.TabIndex = 12;
            this.petalWidthChart.Text = "chart1";
            // 
            // Irises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1410, 903);
            this.Controls.Add(this.petalWidthChart);
            this.Controls.Add(this.petalLengthChart);
            this.Controls.Add(this.sepalWidthChart);
            this.Controls.Add(this.sepalLengthChart);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.FileSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Irises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Irises Visualization";
            this.Load += new System.EventHandler(this.Irises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepalLengthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepalWidthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petalLengthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petalWidthChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSelect;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart sepalLengthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sepalWidthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart petalLengthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart petalWidthChart;
    }
}

