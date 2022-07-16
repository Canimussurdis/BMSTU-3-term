using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Demographic;
using Demographic.Exceptions;

namespace Demographic.WinForms
{
    public partial class Form1 : Form
    {
        private Engine _engine;

        public Form1()
        {
            InitializeComponent();
            _engine = new Engine();
        }

        private void runSimulationButton_Click(object sender, EventArgs e)
        {
            try
            {
                _engine.AssertDataIsCorrect();
            }
            catch (EngineException error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            // создание и запуск потока с выполняемым ниже кодом -
            // отрисовка модели в отдбельной потоке без остановки остальных процессов
            new Thread(() =>
            {
                // runSimulationButton.Enabled = false;
                SimulationResult result = _engine.RunSimulation(VisualizeSimulationResult);
                VisualizeSimulationResult(result);
                runSimulationButton.Enabled = true;
            })
            .Start();
        }

        private void VisualizeSimulationResult(SimulationResult result)
        {
            // invoke принимает делегат и выполняет его в том потоке, в котором был создан
            // элемент управления, у которого вызывается инвок
            // если обращаться не из того потока, может быть выброшено исключение
            Invoke((Action)(() => 
            { 
                var populationSeries = populationChart.Series[0];
                var malePopulationSeries = malePopulationChart.Series[0];
                var femalePopulationSeries = femalePopulationChart.Series[0];
                var maleAges = maleStructureChart.Series[0];
                var femaleAges = femaleStructureChart.Series[0];

                populationSeries.Points.Clear();
                malePopulationSeries.Points.Clear();
                femalePopulationSeries.Points.Clear();
                maleAges.Points.Clear();
                femaleAges.Points.Clear();

                foreach (var info in result.PopulationDynamics)
                    populationSeries.Points.AddXY(info.Year, info.Population);

                foreach (var info in result.MalePopulationDynamics)
                    malePopulationSeries.Points.AddXY(info.Year, info.Population);

                foreach (var info in result.FemalePopulationDynamics)
                    femalePopulationSeries.Points.AddXY(info.Year, info.Population);

                foreach (var structure in result.MaleAgeStructure)
                    maleAges.Points.AddXY($"{structure.Range.Min}-{structure.Range.Max}", structure.Count);

                foreach (var structure in result.FemaleAgeStructure)
                    femaleAges.Points.AddXY($"{structure.Range.Min}-{structure.Range.Max}", structure.Count);
            }));
        }

        private string OpenCSVFile()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }

        private void openAgesFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = OpenCSVFile();
                if (path.Length == 0)
                    return;

                _engine.LoadInitialAges(path);
                initialAgesCheckBox.Checked = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void openRulesFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = OpenCSVFile();
                if (path.Length == 0)
                    return;

                _engine.LoadDeathRules(path);
                deathRulesCheckBox.Checked = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void startingYearInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(startingYearInput.Text, out int number))
                _engine.StartingYear = number;
            else
                startingYearInput.Text = _engine.StartingYear.ToString();
        }

        private void endingYearInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(endingYearInput.Text, out int number))
                _engine.EndingYear= number;
            else
                endingYearInput.Text = _engine.EndingYear.ToString();
        }

        private void initialPopulationInput_TextChanged(object sender, EventArgs e)
        {
            if (uint.TryParse(initialPopulationInput.Text, out uint number))
                _engine.NumberOfPeople = number;
            else
                initialPopulationInput.Text = _engine.NumberOfPeople.ToString();
        }

        private void populationChart_Click(object sender, EventArgs e)
        {

        }
    }
}
