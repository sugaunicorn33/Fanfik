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
        public Button b1;

        public Fanfik(string zag, string rat, string nap)
        {
            zagolovok = zag;
            rating = rat;
            naprav = nap;
            b1 = new Button();
        }
    };

    public partial class Form1 : Form
    {
        Fanfik[] fanfiki = new Fanfik[100];
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


            int x = 66;

            for (int i = 0; i < 12; i++)
            {
                fanfiki[i].b1.Location = new Point(x,250);
                fanfiki[i].b1.Size = new Size(100, 48);
                fanfiki[i].b1.Text = fanfiki[i].zagolovok;
                fanfiki[i].b1.Click += new EventHandler(Button4_Click);
                Controls.Add(fanfiki[i].b1);
                x = x + 100; 

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

            int x = 66;
            for (int i = 0; i < 12; i++)
            {
                if (fanfiki[i].rating != ratingComboBox.Text &&
                    ratingComboBox.Text != "Любой рейтинг")
                {
                    fanfiki[i].b1.Visible = false;
                }
                else if (fanfiki[i].naprav != napravlennostComboBox.Text &&
                    napravlennostComboBox.Text != "Любая направленность")
                {
                    fanfiki[i].b1.Visible = false;
                }
                else if (fanfiki[i].rating != ratingComboBox.Text &&
                    ratingComboBox.Text != "Любой рейтинг")
                {
                    //fanfiki[i].b1.Visible = false;
                }
                else
                {
                    fanfiki[i].b1.Visible = true;
                    fanfiki[i].b1.Text = fanfiki[i].zagolovok;
                    fanfiki[i].b1.Tag = fanfiki[i].rating + " " + fanfiki[i].naprav;
                    fanfiki[i].b1.Location = new Point(x, 250);
                    x = x + 100;

                }
            }

            /*if (ratingComboBox.Text == "NC-17" && napravlennostComboBox.Text == "Гет")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Хвост феи", "");
                newForm.Show();
            }
            else if (ratingComboBox.Text == "NC-17" && napravlennostComboBox.Text == "Слэш")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Херня", "");
                newForm.Show();
            }
            else if (ratingComboBox.Text == "PG-13" && napravlennostComboBox.Text == "Гет")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Стар", "");
                newForm.Show();
            }
            else if (ratingComboBox.Text == "NC-21" && napravlennostComboBox.Text == "Слэш")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Арми", "");
                newForm.Show();
            }
            else if (ratingComboBox.Text == "G" && napravlennostComboBox.Text == "Джен")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Йода", folder);
                newForm.Show();
            }
            else if (ratingComboBox.Text == "G" && napravlennostComboBox.Text == "Гет")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Силачка", folder);
                newForm.Show();
            }
            else if (ratingComboBox.Text == "G" && napravlennostComboBox.Text == "Слэш")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Чимин и Шуга", folder);
                newForm.Show();
            }
            else if (ratingComboBox.Text == "G" && napravlennostComboBox.Text == "Гет")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Стар Марко", folder);
                newForm.Show();
            }
            else if (ratingComboBox.Text == "G" && napravlennostComboBox.Text == "Гет")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Хвост Клуб", folder);
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Нет статей по фильтру");
            }*/
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
            Button butto4 = (Button)sender;
            ReadFanfikForm newForm = new ReadFanfikForm(butto4.Text, butto4.Tag.ToString());
            newForm.Show();
        }
    }
}
