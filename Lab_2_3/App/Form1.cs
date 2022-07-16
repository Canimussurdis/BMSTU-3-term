using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using _2lab;

namespace App
{
    public partial class Form1 : Form
    {
        private DataGetter _dataGetter = new DataGetter();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            bool ok = false;
            while (!ok)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                    if (filename.Substring(filename.Length - 8) == "iris.csv")
                    {
                        _dataGetter.GetVectors(filename);
                        ShowCharts();
                        ShowPieChart();
                        ok = true;
                    }
                    else
                        MessageBox.Show("Выбранный вами файл имеет название, отличное от \"iris.csv\". Попробуйте выбрать файл ещё раз");
                }
                else
                {
                    MessageBox.Show("Файл не открылся. Попробуйте выбрать файл ещё раз");
                    ok = true;
                }

            }
        }

        /*
         * public partial class Form1 : Form
    {
        BusinessLogic businessLogic;
        public Form1()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
            chart1.Series.Clear();
            chart2.Series.Clear();
        }

        private void FileSelect_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV files (*.csv)|*.csv";
            if(fileDialog.ShowDialog() != DialogResult.Cancel)
            {
                //businessLogic._fileName = "C:\\Users\\vdv30\\Downloads\\iris.csv";
                businessLogic._fileName = fileDialog.FileName;
              FileName.Text = System.IO.Path.GetFileName(fileDialog.FileName);
            }
            try
            {
                businessLogic.ReadFile();
                paintGraphic();
                paintPie();
            }
            catch (Exception eror)
            {
                MessageBox.Show(
                    eror.Message,
                    "Сообщение");
                //chart1.Series.Clear();
                //chart2.Series.Clear();
            }
        }
*/


        /// <summary>Отобразить 4 гистограммы.</summary>
        private void ShowCharts()
        {
            List<Chart> charts = new List<Chart>(){chart1, chart2, chart3, chart4 };
            List<string> namesVectors = new List<string>() {"Setosa", "Versicolor", "Virginica"};
            int countColumns = 3;
            int a = charts.Count;
            for (int i = 0; i < charts.Count; i++)
            {
                charts[i].Series.Clear();
                charts[i].Titles.Add((i + 1).ToString() + " coordinate");
                for (int j = 0; j < countColumns; j++)
                {
                    Series series = charts[i].Series.Add(namesVectors[j]);
                    series.Points.Add(_dataGetter.GetConverter().GetValueOfAveragedVector(j, i));
                }
            }
        }

        /// <summary>Отобразить круговую диаграмму.</summary>
        private void ShowPieChart()
        {
            DataConverter converter = _dataGetter.GetConverter();
            MathVector Setosa = new MathVector(converter.GetAveragedVector(0));
            MathVector Versicolor = new MathVector(converter.GetAveragedVector(1));
            MathVector Virginica = new MathVector(converter.GetAveragedVector(2));
            chart5.Series[0].Points.Clear();
            chart5.Series[0].ChartType = SeriesChartType.Pie;
            chart5.Titles.Add("Euclidean distance");
            double a1 = Setosa.CalcDistance(Versicolor);
            double a2 = Setosa.CalcDistance(Virginica);
            double a3 = Versicolor.CalcDistance(Virginica);
            chart5.Series[0].Points.AddXY("S&Ve", Setosa.CalcDistance(Versicolor));
            chart5.Series[0].Points.AddXY("S&Vi", Setosa.CalcDistance(Virginica));
            chart5.Series[0].Points.AddXY("V&V", Versicolor.CalcDistance(Virginica));
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataConverter converter = _dataGetter.GetConverter();
            MathVector Setosa = new MathVector(converter.GetAveragedVector(0));
            MathVector Versicolor = new MathVector(converter.GetAveragedVector(1));
            MathVector Virginica = new MathVector(converter.GetAveragedVector(2));
            double a1 = Setosa.CalcDistance(Versicolor);
            double a2 = Setosa.CalcDistance(Virginica);
            double a3 = Versicolor.CalcDistance(Virginica);


           label1.Text = a1.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
