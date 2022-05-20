using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Praktik_UI
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string PartId = textBoxArticle.Text;
            if (CheckID(PartId)==false)
            {
                MessageBox.Show("Неверный формат артикула!", "Ошибка!");
                return;
            }
            string PartName = textBoxName.Text;
            if (CheckName(PartName)==false)
            {
                MessageBox.Show("Неверный формат названия!", "Ошибка!");
                return;
            }
            string PartAmount = textBoxAmount.Text;
            if (CheckAmount(PartAmount) == false)
            {
                MessageBox.Show("Неверный формат количества!", "Ошибка!");
                return;
            }
            string PartPrice = textBoxPrice.Text;
            if (CheckPrice(PartPrice) == false)
            {
                MessageBox.Show("Неверный формат цены!", "Ошибка!");
                return;
            }
            PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
            StorageClass.Storage.PartList.Add(NewPart);
            MessageBox.Show("Товар успешно добавлен!", "Успех!");
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
        private bool CheckAmount(string amount)
        {
            Regex regex = new Regex(@"[\d]+");
            if (regex.IsMatch(amount))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckPrice(string price)
        {
            Regex regex = new Regex(@"[\d]+");
            if (regex.IsMatch(price))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        private bool CheckName(string Name)
        {
            Regex regex = new Regex(@"[\p{IsCyrillic}]+");
            if ((Name == "Название") || (string.IsNullOrEmpty(Name)))
            {
                return false;
            }
            else if (regex.IsMatch(Name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void textBoxArticle_Enter(object sender, EventArgs e)
        {
            if (textBoxArticle.Text == "Артикул")
            {
                textBoxArticle.Text = "";
                textBoxArticle.ForeColor = Color.Black;
            }
        }

        private void textBoxArticle_Leave(object sender, EventArgs e)
        {
            if (textBoxArticle.Text == "")
            {
                textBoxArticle.Text = "Артикул";
                textBoxArticle.ForeColor = Color.Silver;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Название")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Название";
                textBoxName.ForeColor = Color.Silver;
            }
        }

        private void textBoxAmount_Enter(object sender, EventArgs e)
        {
            if (textBoxAmount.Text == "Количество")
            {
                textBoxAmount.Text = "";
                textBoxAmount.ForeColor = Color.Black;
            }
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            if (textBoxAmount.Text == "")
            {
                textBoxAmount.Text = "Количество";
                textBoxAmount.ForeColor = Color.Silver;
            }
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "Цена")
            {
                textBoxPrice.Text = "";
                textBoxPrice.ForeColor = Color.Black;
            }
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "")
            {
                textBoxPrice.Text = "Цена";
                textBoxPrice.ForeColor = Color.Silver;
            }
        }
    }
}
