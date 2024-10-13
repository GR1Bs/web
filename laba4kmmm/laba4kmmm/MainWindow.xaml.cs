using OxyPlot;
using System.Windows;
//using OxyPlot;
using OxyPlot.Series;


namespace laba4kmmm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlotModel PlotModel { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            InitializePlotModel();
        }

        private void InitializePlotModel()
        {
            PlotModel = new PlotModel { Title = "График" };
            plotView.Model = PlotModel;
        }

        private void UpdatePlot(double a, double b, double h)
        {
            PlotModel.Series.Clear();
            var series = new LineSeries { Title = "Функция" };

            for (double x = a; x <= b; x += h)
            {
                double y = Function(x);
                series.Points.Add(new DataPoint(x, y));
            }

            PlotModel.Series.Add(series);
            PlotModel.InvalidatePlot(true);
        }

        private double Function(double x)
        {
            return 3 * Math.Sin(0.06 * Math.Pow(x, 3));
        }

        private double Trapezoidal(double a, double b, double h)
        {
            double n = (double)((b - a) / h);
            double sum = 0.5 * (Function(a) + Function(b));

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += Function(x);
            }

            return sum * h;
        }

        private double Simpson(double a, double b, double h)
        {
         
            h = (b - a) / h;
            if (h % 2 == 1) h++; // n должно быть четным
            double n = (b - a) / h;
            double sum = Function(a) + Function(b); // f(x0) + f(xn)

            for (int i = 1; i < h; i++)
            {
                double x = a + i * n;
                sum += (i % 2 == 0) ? 2 * Function(x) : 4 * Function(x); // 2*f(x2), 4*f(x1), 2*f(x4), 4*f(x3), ...
            }

            return (n / 3) * sum; // (h/3) * (f(x0) + 4*f(x1) + 2*f(x2) + 4*f(x3) + ... + f(xn))

        }
        private void metod1_Click(object sender, RoutedEventArgs e)
        {
            try {
                double a = Convert.ToDouble(chag1.Text);
                double b = Convert.ToDouble(chag2.Text);
                double h = Convert.ToDouble(chag3.Text);
                double result = Trapezoidal(a, b, h);
               // double resultH2 = Trapezoidal(a, b, h / 2);
                //double error = Math.Abs(result - resultH2);
                //MessageBox.Show($"The integral is approximately {result}", "Trapezoidal Method Result");
                result1.Text=result.ToString();
                //abs.Text=error.ToString();
                UpdatePlot(a, b, h);
            }
            catch 
            {
                MessageBox.Show("Введите значения");
            }
            

        }

        private void metod2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(chag1.Text);
                double b = Convert.ToDouble(chag2.Text);
                double h = Convert.ToDouble(chag3.Text);
                double result = Simpson(a, b, h);
                // MessageBox.Show($"The integral is approximately {result}", "Trapezoidal Method Result");
                result1.Text = result.ToString();
                UpdatePlot(a, b, h);
            }
            catch
            {
                MessageBox.Show("Введите значения");
            }
        }
    }
}