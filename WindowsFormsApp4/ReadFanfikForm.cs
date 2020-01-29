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
    public partial class ReadFanfikForm : Form
    {
        public ReadFanfikForm(string pictureName)
        {
            InitializeComponent();

            Text = pictureName;
            if (pictureName == "Хвост феи")
            {
                pictureBox1.Load("../../Resources/Хвост феи.jpg");
                label1.Text = "Это аниме";
            }
            if (pictureName == "Херня")
            {
                pictureBox1.Load("../../Resources/Херня.jpg");
                label1.Text = "Это оно";
            }
            if (pictureName == "Арми")
            {
                pictureBox1.Load("../../Resources/Арми.jpg");
                label1.Text = "Это BTS!!!!!!!!!!";
            }
            if (pictureName == "Йода")
            {
                pictureBox1.Load("../../Resources/Йода.jpg");
                label1.Text = "Это милый йода";
            }
            if (pictureName == "Стар")
            {
                pictureBox1.Load("../../Resources/Стар.jpg");
                label1.Text = "Это Стар против сил зла";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
