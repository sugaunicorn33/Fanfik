using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ReadFanfikForm : Form
    {
        public Fanfik fanfik;

        private void Button3_Click(object sender, EventArgs e)
        {
            
            if (!Form1.moyVybor.Contains(fanfik))
                 Form1.moyVybor.Add(fanfik);
        }

        public ReadFanfikForm(Fanfik _fanfik)
        {
            fanfik = _fanfik;
            InitializeComponent();

            Text = fanfik.zagolovok;
            label3.Text = fanfik.likes.ToString();
            textBox2.Text = fanfik.comment;
           
            try
            {
                pictureBox1.Load                    ("../../Resources/" + fanfik.rating + " " + fanfik.naprav + "/" + fanfik.zagolovok + ".jpg");
                textBox1.Lines = File.ReadAllLines("../../Resources/" + fanfik.rating + " " + fanfik.naprav + "/" + fanfik.zagolovok + ".txt");
            }
            catch (Exception) { }

            /*if (pictureName == "Хвост феи")
            {
                label1.Text = "Это аниме";
            }
            if (pictureName == "Херня")
            {
                label1.Text = "Это оно";
            }
            if (pictureName == "Арми")
            {
                label1.Text = "Это BTS!!!!!!!!!!";
            }
            if (pictureName == "Йода")
            {
                label1.Text = "Это милый йода";
            }
            if (pictureName == "Стар")
            {
                label1.Text = "Это Стар против сил зла";
            }*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fanfik.comment = textBox2.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            fanfik.likes = fanfik.likes + 1;
            label3.Text = fanfik.likes.ToString();
        }

        private void Label3_Click(object sender,  EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile("https://avidreaders.ru/download/vedmak.html?f=pdf",
                "C:\\Users\\" + Environment.UserName + "\\Download\\5.pdf");
            MessageBox.Show("Сохранено в 5.pdf");
        }
    }
}
