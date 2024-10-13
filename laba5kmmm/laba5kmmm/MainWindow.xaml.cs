using OxyPlot;
using OxyPlot.Wpf;
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

namespace laba5kmmm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    
        private double Function(double t, double y)
        {
            return y/(t+1)+Math.Exp(t)*(t+1);
        }

        private void RungeKutta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t0 = Convert.ToDouble(t.Text);
                double T = Convert.ToDouble(tt.Text);
                double y0 = Convert.ToDouble(y.Text);
                double h = Convert.ToDouble(h1.Text);

               double result= RungeKuttaMethod(t0, T, y0, h);
                rez.Text= result.ToString();

                PlotResults(t0, T, y0, h, result);
            }
            catch 
            {
                MessageBox.Show("Введите коректные данные");
            }
        }

        private void Euler_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t0 = Convert.ToDouble(t.Text);
                double T = Convert.ToDouble(tt.Text);
                double y0 = Convert.ToDouble(y.Text);
                double h = Convert.ToDouble(h1.Text);

                double result = EulerMethod(t0, T, y0, h);
                rez.Text = result.ToString();

                PlotResults(t0, T, y0, h, result);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных.");
            }
        }

        private double RungeKuttaMethod(double t0, double T, double y0, double h)
        {
            int N = (int)((T - t0) / h);
            double[] x = new double[N + 1];
            double[] y = new double[N + 1];
            x[0] = t0;
            y[0] = y0;

            for (int i = 0; i < N; i++)
            {
                double k1 = h * Function(x[i], y[i]);
                double k2 = h * Function(x[i] + h / 2, y[i] + k1 / 2);
                double k3 = h * Function(x[i] + h / 2, y[i] + k2 / 2);
                double k4 = h * Function(x[i] + h, y[i] + k3);

                y[i + 1] = y[i] + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                x[i + 1] = x[i] + h;
            }

            return y[N];
        }
        private double EulerMethod(double t0, double T, double y0, double h)
        {
            int N = (int)((T - t0) / h);
            double[] x = new double[N + 1];
            double[] y = new double[N + 1];
            x[0] = t0;
            y[0] = y0;

            for (int i = 0; i < N; i++)
            {
                y[i + 1] = y[i] + h * Function(x[i], y[i]);
                x[i + 1] = x[i] + h;
            }

            // Returning the result instead of printing it
            return y[N];
        }
        private void PlotResults(double t0, double T, double y0, double h, double rungeKuttaResult)
        {
            // Creating plot model
            var plotModel = new PlotModel { Title = "Графики решений" };

            // Adding exact solution series
            var exactSeries = new OxyPlot.Series.LineSeries
            {
                Title = "Точное решение",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Blue,
                MarkerFill = OxyColors.White
            };

            // Adding approximate solution series
            var approximationSeries = new OxyPlot.Series.LineSeries
            {
                Title = "Приближенное решение",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Red,
                MarkerFill = OxyColors.White
            };

            // Adding points to series
            for (double t = t0; t <= T; t += h)
            {
                exactSeries.Points.Add(new OxyPlot.DataPoint(t, ExactSolution(t)));
                approximationSeries.Points.Add(new OxyPlot.DataPoint(t, EulerMethod(t0, t, y0, h)));
            }

            // Adding series to plot model
            plotModel.Series.Add(exactSeries);
            plotModel.Series.Add(approximationSeries);

            // Setting plot model to plot view
            plotView.Model = plotModel;

            // Displaying the result
            rez.Text = rungeKuttaResult.ToString();
        }

        // Exact solution function
        private double ExactSolution(double t)
        {
            return (Math.Exp(t) * (t + 1)) + (2 * Math.Exp(-t)) - (t + 1);
        }
    }



}
