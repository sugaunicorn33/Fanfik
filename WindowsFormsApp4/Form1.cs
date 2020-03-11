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
    public struct Fanfik
    {
        public string zagolovok;
        public string rating;
        public string naprav;
        public int likes;
        public Button b1;
        public Label l1;

        public Fanfik(string zag, string rat, string nap)
        {
            likes = 0;
            zagolovok = zag;
            rating = rat;
            naprav = nap;
            b1 = new Button();
            l1 = new Label();

            try
            {
                b1.BackgroundImage = Image.FromFile("../../Resources/" + rat + " " + nap + "/" + zag + ".jpg");
                b1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception) { }
        }
    };

    public partial class Form1 : Form
    {
        Fanfik[] fanfiki = new Fanfik[12];
        public static List<Fanfik> moyVybor = new List<Fanfik>();
        public Form1()
        {
            InitializeComponent();

            //fanfiki[0] = 
            fanfiki[0] = new Fanfik("Силачка", "G", "Гет");
            fanfiki[1] = new Fanfik("Теперь ты боишься меня", "G", "Гет");
            fanfiki[2] = new Fanfik("Группа Bad Girls", "G", "Гет");
            fanfiki[3] = new Fanfik("Чимин и Шуга", "G", "Слэш");
            fanfiki[4] = new Fanfik("Dee", "G", "Слэш");
            fanfiki[5] = new Fanfik("ЛГБТ", "G", "Фемслэш");
            fanfiki[6] = new Fanfik("Лесби", "G", "Фемслэш");
            fanfiki[7] = new Fanfik("Лесби2", "G", "Фемслэш");
            fanfiki[8] = new Fanfik("Класс убийц", "G", "Слэш");
            fanfiki[9] = new Fanfik("Моя туса", "G", "Джен");
            fanfiki[10] = new Fanfik("Йода", "G", "Джен");
            fanfiki[11] = new Fanfik("Кот", "G", "Джен");


            int x = 10;
            int y = 10;

            for (int i = 0; i < fanfiki.Length; i++)
            {
                fanfiki[i].b1.Size = new Size(100, 70);
                fanfiki[i].b1.Click += new EventHandler(Button4_Click);
                panel1.Controls.Add(fanfiki[i].b1);

                fanfiki[i].l1.Location = new Point(x, y + 70);
                fanfiki[i].l1.Size = new Size(100, 30);
                fanfiki[i].l1.Text = fanfiki[i].zagolovok;
                panel1.Controls.Add(fanfiki[i].l1);
                
                fanfiki[i].b1.Location = new Point(x, y);
                fanfiki[i].l1.Location = new Point(x, y + 70);
                x = x + 100;
                if (x + 100 > Width)
                {
                    x = 10;
                    y = y + 100;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ratingComboBox.SelectedIndex = 0;
            napravlennostComboBox.SelectedIndex = 0;
            sizeComboBox.SelectedIndex = 0;
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            //Все картинки лежат в папках типа @G Слэш@
            string folder = ratingComboBox.Text + " " + napravlennostComboBox.Text;

            int x = 10;
            int y = 10;
            for (int i = 0; i < fanfiki.Length; i++)
            {
                if (fanfiki[i].rating != ratingComboBox.Text &&
                    ratingComboBox.Text != "Любой рейтинг")
                {
                    fanfiki[i].b1.Visible = false;
                    fanfiki[i].l1.Visible = false;
                }
                else if (fanfiki[i].naprav != napravlennostComboBox.Text &&
                    napravlennostComboBox.Text != "Любая направленность")
                {
                    fanfiki[i].b1.Visible = false;
                    fanfiki[i].l1.Visible = false;
                }
                else if (fanfiki[i].rating != ratingComboBox.Text &&
                    ratingComboBox.Text != "Любой рейтинг")
                {
                    //fanfiki[i].b1.Visible = false;
                }
                else
                {
                    fanfiki[i].b1.Visible = true;
                    fanfiki[i].l1.Visible = true;
                    fanfiki[i].b1.Tag = fanfiki[i].rating + " " + fanfiki[i].naprav;

                    fanfiki[i].b1.Location = new Point(x, y);
                    fanfiki[i].l1.Location = new Point(x, y + 70);
                    x = x + 100;
                    if (x + 100 > Width)
                    {
                        x = 10;
                        y = y + 100;
                    }
                }
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm newForm = new HelpForm();
            newForm.ShowDialog();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            dopNov2 newForm = new dopNov2();
            newForm.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fanfiki.Length; i++)
            {
                if (sender == fanfiki[i].b1)
                {
                    ReadFanfikForm newForm = new ReadFanfikForm(fanfiki[i]);
                    newForm.ShowDialog();
                    fanfiki[i] = newForm.fanfik;
                }
            }
        }
    }
}
