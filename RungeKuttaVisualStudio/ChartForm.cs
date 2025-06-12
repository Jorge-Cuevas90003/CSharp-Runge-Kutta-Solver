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

namespace RungeKuttaVisualStudio
{
    public partial class ChartForm : Form
    {
        public ChartForm(List<double> ts, List<double> ysRK, List<double> tsExact, List<double> ysExact)
        {
            InitializeComponent();

            var chart = new Chart();
            chart.Dock = DockStyle.Fill;

            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            var seriesRK = new Series("RK4");
            var seriesExact = new Series("Exact");

            // Configurar estilo de las series
            seriesRK.Color = System.Drawing.Color.Red;
            seriesRK.MarkerStyle = MarkerStyle.Circle;
            seriesRK.MarkerSize = 8;
            seriesRK.BorderWidth = 2;

            seriesExact.Color = System.Drawing.Color.Blue;
            seriesExact.BorderWidth = 2;

            for (int i = 0; i < ts.Count; i++)
            {
                seriesRK.Points.AddXY(ts[i], ysRK[i]);
            }

            for (int i = 0; i < tsExact.Count; i++)
            {
                seriesExact.Points.AddXY(tsExact[i], ysExact[i]);
            }

            chart.Series.Add(seriesRK);
            chart.Series.Add(seriesExact);

            Controls.Add(chart);
        }
        private void ChartForm_Load(object sender, EventArgs e)
        {

        }

        private void ChartForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
