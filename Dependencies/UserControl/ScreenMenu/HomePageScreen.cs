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

namespace TechConnect
{
    public partial class HomePageScreen : UserControl
    {
        public HomePageScreen()
        {
            InitializeComponent();

            //// Criar uma série de dados de exemplo
            //Series series = new Series("Dados de Exemplo");
            //series.ChartType = SeriesChartType.Line;
            //chart1.Series.Add(series);

            //// Adicionar alguns pontos de dados de exemplo
            //series.Points.AddXY(1, 5);
            //series.Points.AddXY(2, 10);
            //series.Points.AddXY(3, 8);

            //// Definir o intervalo fixo no eixo X
            //chart1.ChartAreas[0].AxisX.Minimum = 1; // Valor mínimo
            //chart1.ChartAreas[0].AxisX.Maximum = 4; // Valor máximo
            BuildChartAccessByHour();
        }

        private void BuildChartAccessByHour()
        {
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = 23;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            chart1.Series.Clear();

            Random randomColor = new Random();

            chart1.Series.Add("AccessByHour");
            chart1.Series["AccessByHour"].Color = Color.FromArgb(randomColor.Next(256),
                                                                 randomColor.Next(256),
                                                                 randomColor.Next(256));
            chart1.Series["AccessByHour"].Legend = "Legend1";
            chart1.Series["AccessByHour"].ChartArea = "ChartArea1";
            chart1.Series["AccessByHour"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            for (int hour = 0; hour < 23; hour++)
            {
                if (hour >= 6 &&
                    hour <= 22)
                    chart1.Series["AccessByHour"].Points.AddXY(hour, randomColor.Next(1, 50));
                else
                    chart1.Series["AccessByHour"].Points.AddXY(hour, 0);
            }
        }
    }
}
