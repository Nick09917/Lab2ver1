using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2ver1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                textBox4.Clear();
                textBox4.Text = "Лаб.Работа № 2 Осипов Николай Вар 4 ";
                double x = double.Parse(textBox1.Text);
                textBox4.Text += Environment.NewLine +
                    "X = " + x.ToString();


                double y = double.Parse(textBox2.Text);
                textBox4.Text += Environment.NewLine +
                    "Y = " + y.ToString();

                double z = double.Parse(textBox3.Text);
                if(z == 0)
                {
                    MessageBox.Show(" На 0 делить нельзя!!!");

                    Environment.Exit(0);
                }
                textBox4.Text += Environment.NewLine +
                    "Z = " + z.ToString();
                double answer1 = (Math.Abs(Math.Cos (x) - Math.Cos(y)));
                double answer2 = 1 + (2 * Math.Pow(Math.Sin(y), 2));
                double answer3 = Math.Pow(answer1, answer2);
                double answerd1 = (1 + z )+ ((Math.Pow(z, 2)) / 2) + ((Math.Pow(z, 3)) / 3) + ((Math.Pow(z, 4)) / 4);
                double answerfinl = answer3*answerd1;
                textBox4.Text += Environment.NewLine +
                    "Решение = " + answerfinl.ToString();


            }
            catch { MessageBox.Show("Произошла ошибка друг, проверь данные"); }
            }

        }
    }

