using System;
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
        public ReadFanfikForm(string pictureName, string folder)
        {
            InitializeComponent();

            Text = pictureName;
            try
            {
                //../../Resources/рейтинг направленность/заголовок.jpg
                pictureBox1.Load("../../Resources/" + folder + "/" + pictureName + ".jpg");
                textBox1.Lines = File.ReadAllLines("../../Resources/" + folder + "/" + pictureName + ".txt");
            }
            catch (Exception) { }

            if (pictureName == "Хвост феи")
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
            }
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
    }
}
