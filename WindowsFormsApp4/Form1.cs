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

        public Fanfik(string zag, string rat, string nap, Button b)
        {
            zagolovok = zag;
            rating = rat;
            naprav = nap;
            b1 = b;
        }
    };

    public partial class Form1 : Form
    {
        Fanfik[] fanfiki = new Fanfik[100];
        public Form1()
        {
            InitializeComponent();

            //fanfiki[0] = 
            fanfiki[0] = new Fanfik("Силачка", "G", "Гет", button4);
            fanfiki[1] = new Fanfik("Теперь ты боишься меня", "G", "Гет", button5);
            fanfiki[2] = new Fanfik("Группа Bad Girls", "G", "Гет", button6);
            fanfiki[3] = new Fanfik("Чимин и Шуга", "G", "Слэш", button7);
            fanfiki[4] = new Fanfik("Dee", "G", "Слэш", button8);

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

            for (int i = 0; i < 5; i++)
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

        private void RatingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ReadFanfikForm newForm = new ReadFanfikForm(button4.Text, button4.Tag.ToString());
            newForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ReadFanfikForm newForm = new ReadFanfikForm(button5.Text, button5.Tag.ToString());
            newForm.Show();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ReadFanfikForm newForm = new ReadFanfikForm(button6.Text, button6.Tag.ToString());
            newForm.Show();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ReadFanfikForm newForm = new ReadFanfikForm(button7.Text, button7.Tag.ToString());
            newForm.Show();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ReadFanfikForm newForm = new ReadFanfikForm(button8.Text, button8.Tag.ToString());
            newForm.Show();

        }
    }
}
