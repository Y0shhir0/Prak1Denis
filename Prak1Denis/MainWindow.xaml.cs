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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prak1Denis
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double numberA = double.Parse(textBoxA.Text);
                double numberB = double.Parse(textBoxB.Text);

                // Вычисление суммы квадратов
                double sum = Math.Pow(numberA, 2) + Math.Pow(numberB, 2);
                sumTextBox.Text = sum.ToString();

                // Вычисление разности квадратов
                double difference = Math.Pow(numberA, 2) - Math.Pow(numberB, 2);
                differenceTextBox.Text = difference.ToString();

                // Вычисление произведения квадратов
                double product = Math.Pow(numberA, 2) * Math.Pow(numberB, 2);
                productTextBox.Text = product.ToString();

                // Проверка деления на ноль
                if (numberB == 0)
                {
                    quotientTextBox.Text = "Ошибка: деление на ноль!";
                }
                else
                {
                    // Вычисление частного квадратов
                    double quotient = Math.Pow(numberA, 2) / Math.Pow(numberB, 2);
                    quotientTextBox.Text = quotient.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }
    }
}
