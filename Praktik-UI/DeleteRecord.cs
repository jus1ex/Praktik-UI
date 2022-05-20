using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktik_UI
{
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }
        private bool CheckID(string ID)
        {
            Regex regex = new Regex(@"[\d]+");
            if (regex.IsMatch(ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void deleteBox_Enter(object sender, EventArgs e)
        {
            if (deleteBox.Text == "Номер")
            {
                deleteBox.Text = "";
                deleteBox.ForeColor = Color.Black;
            }
        }

        private void deleteBox_Leave(object sender, EventArgs e)
        {
            if (deleteBox.Text == "")
            {
                deleteBox.Text = "Номер";
                deleteBox.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string snumber=deleteBox.Text;
            if (CheckID(snumber)==false)
            {
                MessageBox.Show("Неверный формат номера!", "Ошибка!");
                return;
            }
            int number = System.Convert.ToInt32(deleteBox.Text);
            StorageClass.Storage.PartList.RemoveAt(number-1);
            MessageBox.Show("Товар удален из списка!", "Успех!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
