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
    public partial class Cborn : Form
    {
        public Cborn()
        {
            InitializeComponent();
            int x = 10;
            int y = 10;
            foreach (Fanfik fanfik in Form1.moyVybor)
            {
                Button b1 = new Button(); 
                b1.Size = new Size(100, 70);
                //fanfiki[i].b1.Click += new EventHandler(Button4_Click);
                b1.BackgroundImage = fanfik.b1.BackgroundImage;
                b1.Size = new Size(100, 70);
                b1.Location = new Point(x, y);
                b1.BackgroundImageLayout = ImageLayout.Stretch;
                Controls.Add(b1);

                Label l1 = new Label();
                l1.Location = new Point(x, y + 70);
                l1.Size = new Size(100, 30);
                l1.Text = fanfik.zagolovok;
                Controls.Add(l1);

                    x = x + 100;
                    if (x + 100 > Width)
                    {
                        x = 10;
                        y = y + 100;
                    }
                
            }
        }

        private void Cborn_Load(object sender, EventArgs e)
        {

        }
    }
}
