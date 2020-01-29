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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ratingComboBox.SelectedIndex = 0;
            napravlennostComboBox.SelectedIndex = 0;
            sizeComboBox.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ratingComboBox.Text == "NC-17" && napravlennostComboBox.Text == "Гет")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Хвост феи");
                newForm.Show();
            }
            else if (ratingComboBox.Text == "NC-17" && napravlennostComboBox.Text == "Слэш")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Херня");
                newForm.Show();
            }
            else if (ratingComboBox.Text == "PG-13" && napravlennostComboBox.Text == "Гет")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Стар");
                newForm.Show();
            }
            else if (ratingComboBox.Text == "NC-21" && napravlennostComboBox.Text == "Слэш")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Арми");
                newForm.Show();
            }
            else if (ratingComboBox.Text == "G" && napravlennostComboBox.Text == "Джен")
            {
                ReadFanfikForm newForm = new ReadFanfikForm("Йода");
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Нет статей по фильтру");
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
    }
}
