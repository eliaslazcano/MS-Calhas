using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows;
using System.Windows.Media;

namespace MS_Calhas.View
{
    public partial class Resumo : UserControl
    {
        public Resumo()
        {
            InitializeComponent();
            ContruirGraficoPU();
            ConstruirGraficoCheque();
            this.Top = 60;
            this.Left = 206;
        }

        private void Resumo_Load(object sender, EventArgs e)
        {
            graficoPU.BackColor = System.Drawing.Color.White;//para nao bugar o grafico na cor preta, definimos primeiro Red e dps White
            graficoCheque.BackColor = System.Drawing.Color.White;
        }

        private void ContruirGraficoPU()
        {
            graficoPU.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Retorno de PU e Silicone",
                    Values = new ChartValues<double> {2, 3, 2, 1, 8}
                },
                new LineSeries
                {
                    Title = "Saída de PU e Silicone",
                    Values = new ChartValues<double> {4, 6, 5, 2, 7}
                }
            };
            graficoPU.AxisX.Add(new Axis
            {
                Title = "Mês",
                Labels = new[] { "Jan", "Feb", "Mar", "Abr", "Mai" }
            });
            graficoPU.LegendLocation = LegendLocation.Right;
            graficoPU.BackColor = System.Drawing.Color.Red;
        }
        private void ConstruirGraficoCheque()
        {
            graficoCheque.From = 30;
            graficoCheque.To = 0;
            graficoCheque.Value = 8;
            graficoCheque.Base.LabelsVisibility = Visibility.Hidden;
            graficoCheque.Base.GaugeActiveFill = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
             {
                 new GradientStop(Colors.Yellow, 0),
                 new GradientStop(Colors.Orange, .5),
                 new GradientStop(Colors.Red, 1)
             }
            };
            graficoCheque.BackColor = System.Drawing.Color.Red;
        }
        private void graficoPU_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            graficoCheque.BackColor = System.Drawing.Color.White;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            graficoCheque.BackColor = System.Drawing.Color.Red;
        }
    }
}
