using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechConnect
{
    public partial class HomePageScreen : UserControl
    {
        Task taskExec;

        public HomePageScreen()
        {
            InitializeComponent();

            _ = LoadCardsValue();

            BuildChartAccessByHour();
        }

        private async Task LoadCardsValue()
        {
            try
            {
                if (this.Visible && DataBaseRequest.TestConnection())
                {
                    this.Invoke((MethodInvoker)async delegate
                    {
                        QtdCurrentAccess.Text = await DataBaseRequest.GetCurrentAccess();
                        QtdTrainingToLost.Text = await DataBaseRequest.GetTrainingToLost();
                        PercentMonthFrequence.Text = string.Concat(await DataBaseRequest.GetMonthFrequencePercent(), "%");
                    });
                }
            }
            catch
            {
            }
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

        private void TimerLoadCards_Tick(object sender, EventArgs e)
        {
            if (taskExec is null)
                taskExec = Task.Run(() => LoadCardsValue());
            else if (taskExec.IsCompleted)
                taskExec = Task.Run(() => LoadCardsValue());
        }
    }
}
