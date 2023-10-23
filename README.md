В соответствии с этим установите необходимое количество окон TextBox, тексты заголовков на форме, размеры шрифтов, а также типы переменных и функции преобразования при вводе и выводе результатов. Для проверки правильности 28 программы после задания приведен контрольный пример: тестовые значения переменных, используемых в выражении, и результат, который при этом получается
==============================================
```C#

 public partial class Form1 : Form
 {
     public Form1()
     {
         InitializeComponent();
     }

     private void Form1_Load(object sender, EventArgs e)
     {
         double test1 = 0.4 * Math.Pow(10,4) ;
         textBox1.Text = test1.ToString();
         textBox2.Text = "-0,875";
         double test2 = -0.475 * Math.Pow(10,-3 );
         textBox3.Text = test2.ToString();
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
```
![3](https://github.com/Nick09917/Lab2ver1/assets/115313324/127382c0-2ebe-447a-a47d-53dc834720cc)
![1](https://github.com/Nick09917/Lab2ver1/assets/115313324/f977310a-80e6-41c9-ae27-9e3a048e8362)
![2](https://github.com/Nick09917/Lab2ver1/assets/115313324/f314d643-a3ff-43f4-9a3d-251c5f2b3b12)
