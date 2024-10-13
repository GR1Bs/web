using OxyPlot.Series;
using OxyPlot;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot.Axes;

namespace KmmmWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //PlotModel plotModel = new PlotModel { Title = "x * Tan(x) - 1.0 / 3.0" };

            //// Создаем ось X и устанавливаем границы для области [0.2, 1]
            //LinearAxis xAxis = new LinearAxis
            //{
            //    Position = AxisPosition.Bottom,
            //    Minimum = 0.2,
            //    Maximum = 1,
            //    MajorStep = (1 - 0.2) / 2 // Шаг делений - половина интервала
            //};
            //plotModel.Axes.Add(xAxis);

            //// Создаем ось Y
            //LinearAxis yAxis = new LinearAxis { Position = AxisPosition.Left };
            //plotModel.Axes.Add(yAxis);

            //LineSeries series = new LineSeries();
            //for (double x = 0.2; x <= 1; x += 0.01)
            //{
            //    double y = x * Math.Tan(x) - 1.0 / 3.0;
            //    series.Points.Add(new DataPoint(x, y));
            //}
            //plotModel.Series.Add(series);
            //plotView.Model = plotModel;
        }

        private void btn_laba2_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}