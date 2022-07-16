
namespace Demographic.WinForms
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.populationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.malePopulationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.femalePopulationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.maleStructureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.femaleStructureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openAgesFileButton = new System.Windows.Forms.Button();
            this.openRulesFileButton = new System.Windows.Forms.Button();
            this.runSimulationButton = new System.Windows.Forms.Button();
            this.startingYearInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endingYearInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.initialPopulationInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.initialAgesCheckBox = new System.Windows.Forms.CheckBox();
            this.deathRulesCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.populationChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malePopulationChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.femalePopulationChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maleStructureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.femaleStructureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // populationChart
            // 
            chartArea16.AxisX.Interval = 2D;
            chartArea16.Name = "ChartArea1";
            this.populationChart.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.populationChart.Legends.Add(legend16);
            this.populationChart.Location = new System.Drawing.Point(8, 12);
            this.populationChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.populationChart.Name = "populationChart";
            this.populationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series16.Legend = "Legend1";
            series16.MarkerBorderWidth = 2;
            series16.MarkerSize = 4;
            series16.Name = "Population";
            this.populationChart.Series.Add(series16);
            this.populationChart.Size = new System.Drawing.Size(473, 173);
            this.populationChart.TabIndex = 0;
            this.populationChart.Text = " ";
            this.populationChart.Click += new System.EventHandler(this.populationChart_Click);
            // 
            // malePopulationChart
            // 
            chartArea17.AxisX.Interval = 2D;
            chartArea17.Name = "ChartArea1";
            this.malePopulationChart.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.malePopulationChart.Legends.Add(legend17);
            this.malePopulationChart.Location = new System.Drawing.Point(7, 194);
            this.malePopulationChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.malePopulationChart.Name = "malePopulationChart";
            this.malePopulationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series17.Legend = "Legend1";
            series17.MarkerSize = 2;
            series17.Name = "Male Population";
            this.malePopulationChart.Series.Add(series17);
            this.malePopulationChart.Size = new System.Drawing.Size(474, 185);
            this.malePopulationChart.TabIndex = 0;
            this.malePopulationChart.Text = " ";
            // 
            // femalePopulationChart
            // 
            chartArea18.AxisX.Interval = 2D;
            chartArea18.Name = "ChartArea1";
            this.femalePopulationChart.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.femalePopulationChart.Legends.Add(legend18);
            this.femalePopulationChart.Location = new System.Drawing.Point(8, 385);
            this.femalePopulationChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.femalePopulationChart.Name = "femalePopulationChart";
            this.femalePopulationChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series18.Legend = "Legend1";
            series18.MarkerSize = 2;
            series18.Name = "Female Population";
            this.femalePopulationChart.Series.Add(series18);
            this.femalePopulationChart.Size = new System.Drawing.Size(473, 204);
            this.femalePopulationChart.TabIndex = 0;
            this.femalePopulationChart.Text = " ";
            // 
            // maleStructureChart
            // 
            chartArea19.Name = "ChartArea1";
            this.maleStructureChart.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.maleStructureChart.Legends.Add(legend19);
            this.maleStructureChart.Location = new System.Drawing.Point(503, 194);
            this.maleStructureChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maleStructureChart.Name = "maleStructureChart";
            this.maleStructureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series19.Legend = "Legend1";
            series19.Name = "Male Age Structure";
            this.maleStructureChart.Series.Add(series19);
            this.maleStructureChart.Size = new System.Drawing.Size(375, 185);
            this.maleStructureChart.TabIndex = 1;
            this.maleStructureChart.Text = "chart1";
            // 
            // femaleStructureChart
            // 
            chartArea20.Name = "ChartArea1";
            this.femaleStructureChart.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.femaleStructureChart.Legends.Add(legend20);
            this.femaleStructureChart.Location = new System.Drawing.Point(503, 385);
            this.femaleStructureChart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.femaleStructureChart.Name = "femaleStructureChart";
            this.femaleStructureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series20.Legend = "Legend1";
            series20.Name = "Female Age Structure";
            this.femaleStructureChart.Series.Add(series20);
            this.femaleStructureChart.Size = new System.Drawing.Size(375, 204);
            this.femaleStructureChart.TabIndex = 1;
            this.femaleStructureChart.Text = "chart1";
            // 
            // openAgesFileButton
            // 
            this.openAgesFileButton.Location = new System.Drawing.Point(774, 27);
            this.openAgesFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.openAgesFileButton.Name = "openAgesFileButton";
            this.openAgesFileButton.Size = new System.Drawing.Size(104, 23);
            this.openAgesFileButton.TabIndex = 2;
            this.openAgesFileButton.Text = "Load Ages";
            this.openAgesFileButton.UseVisualStyleBackColor = true;
            this.openAgesFileButton.Click += new System.EventHandler(this.openAgesFileButton_Click);
            // 
            // openRulesFileButton
            // 
            this.openRulesFileButton.Location = new System.Drawing.Point(774, 56);
            this.openRulesFileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.openRulesFileButton.Name = "openRulesFileButton";
            this.openRulesFileButton.Size = new System.Drawing.Size(104, 23);
            this.openRulesFileButton.TabIndex = 2;
            this.openRulesFileButton.Text = "Load Death Rules";
            this.openRulesFileButton.UseVisualStyleBackColor = true;
            this.openRulesFileButton.Click += new System.EventHandler(this.openRulesFileButton_Click);
            // 
            // runSimulationButton
            // 
            this.runSimulationButton.Location = new System.Drawing.Point(774, 138);
            this.runSimulationButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.runSimulationButton.Name = "runSimulationButton";
            this.runSimulationButton.Size = new System.Drawing.Size(104, 23);
            this.runSimulationButton.TabIndex = 2;
            this.runSimulationButton.Text = "Run";
            this.runSimulationButton.UseVisualStyleBackColor = true;
            this.runSimulationButton.Click += new System.EventHandler(this.runSimulationButton_Click);
            // 
            // startingYearInput
            // 
            this.startingYearInput.Location = new System.Drawing.Point(562, 33);
            this.startingYearInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startingYearInput.Name = "startingYearInput";
            this.startingYearInput.Size = new System.Drawing.Size(161, 20);
            this.startingYearInput.TabIndex = 3;
            this.startingYearInput.Text = "1970";
            this.startingYearInput.TextChanged += new System.EventHandler(this.startingYearInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Simulation first year";
            // 
            // endingYearInput
            // 
            this.endingYearInput.Location = new System.Drawing.Point(562, 86);
            this.endingYearInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.endingYearInput.Name = "endingYearInput";
            this.endingYearInput.Size = new System.Drawing.Size(161, 20);
            this.endingYearInput.TabIndex = 3;
            this.endingYearInput.Text = "2021";
            this.endingYearInput.TextChanged += new System.EventHandler(this.endingYearInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Simulation last year";
            // 
            // initialPopulationInput
            // 
            this.initialPopulationInput.Location = new System.Drawing.Point(563, 144);
            this.initialPopulationInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.initialPopulationInput.Name = "initialPopulationInput";
            this.initialPopulationInput.Size = new System.Drawing.Size(161, 20);
            this.initialPopulationInput.TabIndex = 3;
            this.initialPopulationInput.Text = "13000000";
            this.initialPopulationInput.TextChanged += new System.EventHandler(this.initialPopulationInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Initial population";
            // 
            // initialAgesCheckBox
            // 
            this.initialAgesCheckBox.AutoSize = true;
            this.initialAgesCheckBox.Enabled = false;
            this.initialAgesCheckBox.Location = new System.Drawing.Point(756, 33);
            this.initialAgesCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.initialAgesCheckBox.Name = "initialAgesCheckBox";
            this.initialAgesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.initialAgesCheckBox.TabIndex = 5;
            this.initialAgesCheckBox.UseVisualStyleBackColor = true;
            // 
            // deathRulesCheckBox
            // 
            this.deathRulesCheckBox.AutoSize = true;
            this.deathRulesCheckBox.Enabled = false;
            this.deathRulesCheckBox.Location = new System.Drawing.Point(756, 60);
            this.deathRulesCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deathRulesCheckBox.Name = "deathRulesCheckBox";
            this.deathRulesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.deathRulesCheckBox.TabIndex = 5;
            this.deathRulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(918, 601);
            this.Controls.Add(this.deathRulesCheckBox);
            this.Controls.Add(this.initialAgesCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initialPopulationInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endingYearInput);
            this.Controls.Add(this.startingYearInput);
            this.Controls.Add(this.runSimulationButton);
            this.Controls.Add(this.openRulesFileButton);
            this.Controls.Add(this.openAgesFileButton);
            this.Controls.Add(this.femaleStructureChart);
            this.Controls.Add(this.maleStructureChart);
            this.Controls.Add(this.femalePopulationChart);
            this.Controls.Add(this.malePopulationChart);
            this.Controls.Add(this.populationChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Demographic";
            ((System.ComponentModel.ISupportInitialize)(this.populationChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malePopulationChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.femalePopulationChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maleStructureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.femaleStructureChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart populationChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart malePopulationChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart femalePopulationChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart maleStructureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart femaleStructureChart;
        private System.Windows.Forms.Button openAgesFileButton;
        private System.Windows.Forms.Button openRulesFileButton;
        private System.Windows.Forms.Button runSimulationButton;
        private System.Windows.Forms.TextBox startingYearInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endingYearInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initialPopulationInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox initialAgesCheckBox;
        private System.Windows.Forms.CheckBox deathRulesCheckBox;
    }
}

