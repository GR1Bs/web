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

namespace kmmm_laba51
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

        private void RungeKutta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t0 = Convert.ToDouble(t.Text);
                double T = Convert.ToDouble(tt.Text);
                double y0 = Convert.ToDouble(y.Text);
                double h = Convert.ToDouble(h1.Text);

               // double result = RungeKutta(t0, T, y0, h);

            }
            catch
            {
                MessageBox.Show("sdfsd");
            }
        }
       
       
        private double Function(double t, double y)
        {
            return y / (t + 1) + Math.Exp(t) * (t + 1);
        }
    }
}