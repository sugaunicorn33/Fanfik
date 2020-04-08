using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class dopNov2 : Form
    {
        public dopNov2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 
              Form1.fanfiki.Add(new Fanfik(textBox1.Text, comboBox1.Text, comboBox2.Text));

              Fanfik fanfik = Form1.fanfiki[Form1.fanfiki.Count - 1];
              fanfik.b1.Size = new Size(100, 70);
              fanfik.b1.Click += new EventHandler(Form1.Button4_Click);

              fanfik.l1.Size = new Size(100, 30);
              fanfik.l1.Text = fanfik.zagolovok;

              string zagolovok = textBox1.Text;
              string rating = comboBox1.Text;
              string naprav = comboBox2.Text;

              System.IO.File.Copy(openFileDialog1.FileName,
                "../../Resources/" + rating + " " + naprav + "/" + zagolovok + ".jpg");
                */
            System.IO.File.AppendAllText("Массив.txt",
                 Environment.NewLine + textBox2.Text + ", " + comboBox1.Text + ", " + comboBox2.Text + Environment.NewLine);
        }

        private void dopNov2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Load(openFileDialog1.FileName);

          
           
        }
    }
}
