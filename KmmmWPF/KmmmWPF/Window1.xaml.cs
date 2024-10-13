using OxyPlot.Series;
using OxyPlot.Wpf;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OxyPlot.Axes;


namespace KmmmWPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            double a = 0.2; // Начальная точка интервала
            double b = 1;   // Конечная точка интервала
            double epsilon = 0.0001; // Точность

            double x = BisectionMethod(a, b, epsilon);

            ResultTextBlock.Text = $"x = {x}";

            PlotModel model = new PlotModel { Title = "График уравнения и касательных" };
            LineSeries functionSeries = new LineSeries { Title = "Функция" };

          //  double step = 0.0001;
          //  for (double xValue = a; xValue <= b; xValue += step)
          //  {
           ///     functionSeries.Points.Add(new DataPoint(xValue, xValue * Math.Tan(xValue) - 1.0 / 3.0));
          //  }

          //  model.Series.Add(functionSeries);
            // Установка масштаба для осей X и Y
          //  model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = a, Maximum = b }); // Ось X
           // model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -10, Maximum = 10 }); // Ось Y

            // Отображение графика
           // MyPlotView.Model = model;
        }
        private double Function(double x)
        {
            return x * Math.Tan(x) - 1.0 / 3.0;
        }

        private double BisectionMethod(double a, double b, double epsilon)
        {
            if (Function(a) * Function(b) >= 0)
                throw new ArgumentException("На концах отрезка функция должна иметь разные знаки.");

            double c = a;
            while ((b - a) >= epsilon)
            {
                c = (a + b) / 2;
                if (Function(c) == 0.0)
                    break;
                else if (Function(c) * Function(a) < 0)
                    b = c;
                else
                    a = c;
            }
            return c;
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            double a = 1; // Начальная точка интервала
            double b = 2; // Конечная точка интервала
            double epsilon = 0.0001; // Точность

          //  PlotModel model = new PlotModel { Title = "График уравнения методом хорд" };
          //  LineSeries functionSeries = new LineSeries { Title = "Функция" };

            // Вычисление значений функции методом хорд
           double x = ChordMethod(a, b, epsilon);
            ResultTextBlock.Text = $"x = {x.ToString("0.0000")}"; // Вывод найденного значения x с точностью до десятитысячных
          //  double step = 0.01;
          //  for (double xValue = a; xValue <= b; xValue += step)
          //  {
         //       functionSeries.Points.Add(new DataPoint(xValue, Math.Tan(xValue / 2) - 1 / Math.Tan(xValue / 2) + xValue));
         //   }

         //   model.Series.Add(functionSeries);

            // Отображение графика
          //  MyPlotView.Model = model;

        }

        private double ChordMethod(double a, double b, double epsilon)
        {
            double x0 = a;
            double x1 = b;
            double fx0 = Math.Tan(a / 2) - 1 / Math.Tan(a / 2) + a;
            double fx1 = Math.Tan(b / 2) - 1 / Math.Tan(b / 2) + b;

            while (Math.Abs(fx1) > epsilon)
            {
                double x = x1 - (fx1 * (x1 - x0)) / (fx1 - fx0);
                double fx = Math.Tan(x / 2) - 1 / Math.Tan(x / 2) + x;

                x0 = x1;
                x1 = x;
                fx0 = fx1;
                fx1 = fx;
            }

            return x1;
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            double a = 1; // Начальная точка интервала
            double b = 2; // Конечная точка интервала
            double epsilon = 0.0001; // Точность

            // Построение графика функции
           // PlotModel model = new PlotModel { Title = "График уравнения методом касательных" };
            //LineSeries functionSeries = new LineSeries { Title = "Функция" };

            // Вычисление значений функции методом Ньютона
            double x = NewtonsMethod(a, epsilon);
            ResultTextBlock.Text = $"x = {x.ToString("0.0000")}"; // Вывод найденного значения x с точностью до десятитысячных

            // Добавление точек на график
           // double step = 0.01;
          //  for (double xValue = a; xValue <= b; xValue += step)
          //  {
          //     functionSeries.Points.Add(new DataPoint(xValue, 0.4 + Math.Atan(Math.Sqrt(xValue)) - xValue));
          ///  }

          //  model.Series.Add(functionSeries);

          //  // Отображение графика
           // MyPlotView.Model = model;
        }
        private double NewtonsMethod(double a, double epsilon)
        {
            double x = a;
            double fx = 0.4 + Math.Atan(Math.Sqrt(x)) - x;

            // Пока значение функции больше заданной точности, продолжаем итерации
            while (Math.Abs(fx) > epsilon)
            {
                double derivative = (0.4 + Math.Atan(Math.Sqrt(x + epsilon)) - (x + epsilon) - fx) / epsilon; // Приближенное вычисление производной
                x = x - fx / derivative; // Пересчет значения x
                fx = 0.4 + Math.Atan(Math.Sqrt(x)) - x; // Пересчет значения функции в новой точке
            }

            return x;
        }

        private void grafic1_Click(object sender, RoutedEventArgs e)
        {
            PlotModel plotModel = new PlotModel { Title = "x * Tan(x) - 1.0 / 3.0" };

            // Создаем ось Y и устанавливаем границы
            LinearAxis yAxis = new LinearAxis { Position = AxisPosition.Bottom, Minimum = -150, Maximum = 150 };
            plotModel.Axes.Add(yAxis);

            // Создаем ось X
            LinearAxis xAxis = new LinearAxis { Position = AxisPosition.Left };
            plotModel.Axes.Add(xAxis);

            LineSeries series = new LineSeries();
            for (double y = -10; y <= 10; y += 0.1)
            {
                double x = y * Math.Tan(y) - 1.0 / 3.0;
                //double x=y-(1/(3+Math.Sin(3.6*y)));
                // double x = y * Math.Sqrt(y) + Math.Cbrt(y) - 2.5;
                //double x = Math.Tan(y / 2) - (1 / (Math.Tan(y / 2))) + y;
                series.Points.Add(new DataPoint(x, y));
            }
            plotModel.Series.Add(series);
            PlotView.Model = plotModel;
        }

        private void grafic2_Click(object sender, RoutedEventArgs e)
        {
            PlotModel plotModel = new PlotModel { Title = "tan(x/2) - cot(x/2) + x" };

            
            LinearAxis xAxis = new LinearAxis { Position = AxisPosition.Bottom, Minimum = -10, Maximum = 10 };
            plotModel.Axes.Add(xAxis);

           
           LinearAxis yAxis = new LinearAxis { Position = AxisPosition.Left };
            plotModel.Axes.Add(yAxis);

            LineSeries series = new LineSeries();
            for (double x = 0; x <= 20; x += 0.1)
            {
                double y = Math.Tan(x / 2) - (1 / Math.Atan(x / 2)) + x;
                series.Points.Add(new DataPoint(x, y));
            }
            plotModel.Series.Add(series);
            PlotView.Model = plotModel;
           
            








        }

        private void grafic3_Click(object sender, RoutedEventArgs e)
        {
            PlotModel plotModel = new PlotModel { Title = "0.4 + arctan(sqrt(x)) - x" };

            // Создаем ось X и устанавливаем границы
            LinearAxis xAxis = new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 10 };
            plotModel.Axes.Add(xAxis);

            // Создаем ось Y
            LinearAxis yAxis = new LinearAxis { Position = AxisPosition.Left };
            plotModel.Axes.Add(yAxis);

            LineSeries series = new LineSeries();
            for (double x = 0; x <= 10; x += 0.1)
            {
                double y = 0.4 + Math.Atan(Math.Sqrt(x)) - x;
                series.Points.Add(new DataPoint(x, y));
            }
            plotModel.Series.Add(series);
            PlotView.Model = plotModel;
        }
    }
 }