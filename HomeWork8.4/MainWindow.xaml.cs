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

namespace HomeWork8._4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double operand1, operand2;
            if (!double.TryParse(textBox1.Text, out operand1) || !double.TryParse(textBox2.Text, out operand2))
            {
                MessageBox.Show("Введіть коректні числові значення.");
                return;
            }

            // Виконання операції в залежності від обраного radioButton
            double result = 0;
            if (additionRadioButton.Checked)
            {
                result = operand1 + operand2;
            }
            else if (subtractionRadioButton.Checked)
            {
                result = operand1 - operand2;
            }
            else if (multiplicationRadioButton.Checked)
            {
                result = operand1 * operand2;
            }
            else if (divisionRadioButton.Checked)
            {
                // Перевірка ділення на 0
                if (operand2 == 0)
                {
                    MessageBox.Show("Ділення на нуль неможливе.");
                    return;
                }
                result = operand1 / operand2;
            }

            // Виведення результату
            textBox3.Text = result.ToString();
        }

       
    }
}
