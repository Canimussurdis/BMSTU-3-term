using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;


namespace ChartsVisualisation
{
    public partial class Irises : Form
    {
        BusinessLogic businessLogic;
        public Irises()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
            clearCharts();
        }

        private void FileSelect_Click(object sender, EventArgs e)
        {
            
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (fileDialog.ShowDialog() != DialogResult.Cancel && System.IO.File.Exists(fileDialog.FileName))
            {
            
                FileName.Text = System.IO.Path.GetFileName(fileDialog.FileName);
                try
                {
                    businessLogic.ReadFileAndDivide(fileDialog.FileName);
                    clearCharts();
                    Thread.Sleep(1000);
                    paintGraphic();
                    paintPie();
                }
                catch (Exception exception)
                {
                    clearCharts();
                    MessageBox.Show(
                     exception.Message, 
                     "Ошибка чтения файла",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                      );
                 }
                
            } 
            else
            {
                clearCharts();
                MessageBox.Show(
                    "Файл не выбран", 
                    "Ошибка чтения файла",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void paintPie()
        {
            Series series = chart2.Series.Add("");
            series.Points.Add(Math.Round(businessLogic.length("Setosa and Versicolor"), 2));
            series.Points.Add(Math.Round(businessLogic.length("Setosa and Virginica"), 2));
            series.Points.Add(Math.Round(businessLogic.length("Versicolor and Virginica"), 2));
            series.Points[0].LegendText = "Setosa and Versicolor";
            series.Points[1].LegendText = "Setosa and Virginica";
            series.Points[2].LegendText = "Versicolor and Virginica";
            series.Points[0].Label = (Math.Round(businessLogic.length("Setosa and Versicolor"), 2)).ToString();
            series.Points[1].Label = (Math.Round(businessLogic.length("Setosa and Virginica"), 2)).ToString();
            series.Points[2].Label = (Math.Round(businessLogic.length("Versicolor and Virginica"), 2)).ToString();
            series.ChartType = SeriesChartType.Pie;
        }

        private void paintGraphic()
        {
            //clearCharts();
            sepalLengthChart.Titles.Add("sepal_length");
            sepalLengthChart.Series.Add("Setosa").Points.Add(businessLogic.GetAverageVector("Setosa")[0]);
            sepalLengthChart.Series.Add("Versicolor").Points.Add(businessLogic.GetAverageVector("Versicolor")[0]);
            sepalLengthChart.Series.Add("Virginica").Points.Add(businessLogic.GetAverageVector("Virginica")[0]);

            sepalWidthChart.Titles.Add("sepal_width");
            sepalWidthChart.Series.Add("Setosa").Points.Add(businessLogic.GetAverageVector("Setosa")[1]);
            sepalWidthChart.Series.Add("Versicolor").Points.Add(businessLogic.GetAverageVector("Versicolor")[1]);
            sepalWidthChart.Series.Add("Virginica").Points.Add(businessLogic.GetAverageVector("Virginica")[1]);

            petalLengthChart.Titles.Add("petal_length");
            petalLengthChart.Series.Add("Setosa").Points.Add(businessLogic.GetAverageVector("Setosa")[2]);
            petalLengthChart.Series.Add("Versicolor").Points.Add(businessLogic.GetAverageVector("Versicolor")[2]);
            petalLengthChart.Series.Add("Virginica").Points.Add(businessLogic.GetAverageVector("Virginica")[2]);

            petalWidthChart.Titles.Add("petal_width");
            petalWidthChart.Series.Add("Setosa").Points.Add(businessLogic.GetAverageVector("Setosa")[3]);
            petalWidthChart.Series.Add("Versicolor").Points.Add(businessLogic.GetAverageVector("Versicolor")[3]);
            petalWidthChart.Series.Add("Virginica").Points.Add(businessLogic.GetAverageVector("Virginica")[3]);
        }

        private void clearCharts()
        {
            sepalLengthChart.Titles.Clear();
            sepalWidthChart.Titles.Clear();
            petalLengthChart.Titles.Clear();
            petalWidthChart.Titles.Clear();

            sepalLengthChart.Series.Clear();
            sepalWidthChart.Series.Clear();
            petalLengthChart.Series.Clear();
            petalWidthChart.Series.Clear();
            chart2.Series.Clear();
        }

        private void Irises_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show(
                "Это приложение принимает на вход только csv-файлы больше 0 и меньше 10 Кб",
                "Добрый день",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
