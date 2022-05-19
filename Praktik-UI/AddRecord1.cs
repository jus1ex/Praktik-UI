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
    public partial class AddRecord1 : Form
    {
        public AddRecord1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PartId = textBoxArticle1.Text;
            string PartName = textBoxName1.Text;
            string PartAmount = textBoxAmount1.Text;
            string PartPrice = textBoxPrice1.Text;
            PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
            StorageClass.Storage.PartList.Add(NewPart);
            MessageBox.Show("Товар успешно добавлен!", "Успех!");
        }

        private void textBoxArticle1_Enter(object sender, EventArgs e)
        {
            if (textBoxArticle1.Text == "Артикул")
            {
                textBoxArticle1.Text = "";
                textBoxArticle1.ForeColor = Color.Black;
            }
        }

        private void textBoxArticle1_Leave(object sender, EventArgs e)
        {
            if (textBoxArticle1.Text == "")
            {
                textBoxArticle1.Text = "Артикул";
                textBoxArticle1.ForeColor = Color.Silver;
            }
        }

        private void textBoxName1_Enter(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "Название")
            {
                textBoxName1.Text = "";
                textBoxName1.ForeColor = Color.Black;
            }
        }

        private void textBoxName1_Leave(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "")
            {
                textBoxName1.Text = "Название";
                textBoxName1.ForeColor = Color.Silver;
            }
        }

        private void textBoxAmount1_Enter(object sender, EventArgs e)
        {
            if (textBoxAmount1.Text == "Количество")
            {
                textBoxAmount1.Text = "";
                textBoxAmount1.ForeColor = Color.Black;
            }
        }

        private void textBoxAmount1_Leave(object sender, EventArgs e)
        {
            if (textBoxAmount1.Text == "")
            {
                textBoxAmount1.Text = "Количество";
                textBoxAmount1.ForeColor = Color.Silver;
            }
        }

        private void textBoxPrice1_Enter(object sender, EventArgs e)
        {
            if (textBoxPrice1.Text == "Цена")
            {
                textBoxPrice1.Text = "";
                textBoxPrice1.ForeColor = Color.Black;
            }
        }

        private void textBoxPrice1_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice1.Text == "")
            {
                textBoxPrice1.Text = "Цена";
                textBoxPrice1.ForeColor = Color.Silver;
            }
        }
    }
}
