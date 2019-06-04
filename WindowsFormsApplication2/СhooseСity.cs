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
    public partial class СhooseСity : Form
    {
        public СhooseСity()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "")
            {
                Form form = new СhooseСity();
                form.Show();
                this.Hide();          
            }

            if (comboBox1.SelectedItem.ToString() == "Москва")
            {
                Form form = new Moscow();
                form.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem.ToString() == "Санкт-Петербург")
            {
                Form form = new Petersburg();
                form.Show();
                this.Hide();
            }
            if (comboBox1.SelectedItem.ToString() == "Казань")
            {
                Form form = new Kazan();
                form.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form1 = new Authorization();
            form1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
