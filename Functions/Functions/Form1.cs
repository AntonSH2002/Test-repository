using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }

        private void Functions_Load(object sender, EventArgs e)
        {

        }

        public double Function1(double x) //Первая тестируемая функция
        {
            double result = 0;
            result = Math.Pow(Math.Sin(x), 2);
            return result;
        }

        public double Function2(double x) //Вторая тестируемая функция
        {
            double result = 0;
            result = 2 * Math.Pow(x, 3) - 2;
            return result;
        }

        public double Function3(double x) //Третья тестируемая функция
        {
            double result = 0;
            result = (2 * x + 4) * x;
            return result;
        }

        public double DoubleResutlt(double result) //Функция для удвоения результата
        {
            return result *= 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double result = 0;
                double x = double.Parse(textBox1.Text);
                if (x <= 2)
                {
                    radioButton1.Checked = true;
                    result = Function1(x);

                }
                else if (x < 3)
                {
                    radioButton2.Checked = true;
                    result = Function2(x);
                }
                else
                {
                    radioButton3.Checked = true;
                    result = Function3(x);
                }
                if (checkBox1.Checked)
                {
                    result = DoubleResutlt(result);
                }
                label1.Text = "Результат: " + result.ToString();
            }
            catch
            {
                MessageBox.Show("Неправильный ввод, повторите попытку!", "Ошибка");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double result = 0;
                double x = double.Parse(textBox1.Text);
                if (radioButton1.Checked)
                {
                    result = Function1(x);
                }
                else if (radioButton2.Checked)
                {
                    result = Function2(x);
                }
                else
                {
                    result = Function3(x);
                }
                if (checkBox1.Checked)
                {
                    result *= 2;
                }
                label1.Text = "Результат: " + result.ToString();
            }
            catch
            {
                MessageBox.Show("Неправильный ввод, повторите попытку!", "Ошибка");
            }
        }
    }
}