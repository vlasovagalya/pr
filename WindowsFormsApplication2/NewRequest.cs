using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Request;

namespace WindowsFormsApplication2
{
    public partial class NewRequest : Form
    {
        public string Price { get; private set; }
        public string Description { get; private set; }
        public string Conveniences { get; private set; }
        public object NumberRooms { get; private set; }

        public NewRequest()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new CreateRequest();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form6();
            form1.Show();
            this.Hide();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                var sfd = new SaveFileDialog() { Filter = "Заявка|*.request" };

                if (sfd.ShowDialog(this) != DialogResult.OK)
                    return;
                var request = new NewRequest()
                {
                    Location = listBox1.Items.OfType<Locations>().ToList(),
                    Price = textBox2.Text,
                    Description = textBox3.Text,
                    Conveniences = textBox4.Text,
                    NumberRooms = textBox1.Text,
                };
                

                var xs = new XmlSerializer(typeof(NewRequest));

                var file = File.Create(sfd.FileName);

                xs.Serialize(file, request);
                file.Close();
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Заявка|*.request" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(NewRequest));
            var file = File.OpenRead(ofd.FileName);
            var request = (NewRequest)xs.Deserialize(file);
            file.Close();
            Location = ListBox1.Items.OfType<Locations>().ToList();
            textBox2.Text = request.Price;
            textBox3.Text = request.Description;
            textBox4.Text = request.Conveniences;
            textBox1.Text = request.NumberRooms;
           
            listBox1.Items.Clear();
            foreach (var flight in request.Locations)
            {
                listBox1.Items.Add(flight);
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
