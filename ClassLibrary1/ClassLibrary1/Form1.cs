using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            //Инициализируем элменты для списка
            comboBox1.Items.Add("Прямоугольник");
            comboBox1.Items.Add("Квадрат");

            //Проверка на пустые строки

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                button1.Enabled = false;

            }
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                button2.Enabled = false;

            }



        }

      //Инициализируем формы
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
     

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            label1.Text = Convert.ToString(round(Convert.ToDouble(textBox1.Text),Convert.ToDouble(textBox2.Text)));
           
        }


        //функция вычисления площадей , в функции  окружности я поставил условие , чтобы человек мог в любое поле написать значение пи
        //и получить ответ
        public static double round(double a , double b)
        {
            if (a == 3.14)
            {
                return a * b * b;
            }else
            {
                return b * a * a;
            }
        }

        public  double triangle(double a, double b,double c)
        {
            double p;
            double s;
             p = (a + b + c) / 2;
            //Проверка на прямоугольный треугольник
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                label2.Text= "Этот треугольник прямоугольный";
            }
            else
            {
                label2.Text="Этот треугольник не прямоугольный";
            }
            return s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)));
            
        }

        //Создаем список и с помощью switch и case выбираем элементы
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Прямоугольник":
                    //При нажатии мы меняем форму и закрываем предыдущую
                    f2.Show();
                    Close();
                    break;
                case "Квадрат":
                    f3.Show();
                    Close();
                    break;
             
            }
        }

      
        //Если человек не знает какую фигуру надо вычислить , программа поможет , она закрывает доступ к кнопкам если не выполнено условие

           
private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = false;

            }
            else
            {
                button1.Enabled = false ;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if ( textBox3.Text!="")
            {
                button2.Enabled = true;
            }else
            {
                button2.Enabled = false;
            }

        }

       
    }
  
}
