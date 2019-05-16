using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        bool showPassword = true;

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//кнопка ок
        {

            //здесь должна быть проверка на правильность логина и пароля, используя if 
            //и базы данных(скорее всего будет таблица, в которрой хранятся логин и соответсвующий ему пароль)
            //+должны быть определенный логин и пароль для администратора и программа в первую очередь должна проверять 
            //администратор это или нет
            Form form2 = new Form2();
            form2.Show();//форма, в которой выбираем, в качестве кого мы заходим
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//кнопка отмена
        {
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)//кнопка, которая скрывает и открывает пароль
        {
            if (showPassword)
            {
                textBox2.UseSystemPasswordChar = false;
                showPassword = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                showPassword = true;
            }

        }
        private void button4_Click(object sender, EventArgs e)//кнопка выхода
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void Пользователь_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
