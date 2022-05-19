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
    public partial class AddRecord2 : Form
    {
        public AddRecord2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PartId = textBoxArticle2.Text;
            string PartName = textBoxName2.Text;
            string PartAmount = textBoxAmount2.Text;
            string PartPrice = textBoxPrice2.Text;
            PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
            StorageClass.Storage.PartList.Add(NewPart);
            MessageBox.Show("Товар успешно добавлен!", "Успех!");
        }

        private void textBoxArticle2_Enter(object sender, EventArgs e)
        {
            if (textBoxArticle2.Text == "Артикул")
            {
                textBoxArticle2.Text = "";
                textBoxArticle2.ForeColor = Color.Black;
            }
        }

        private void textBoxArticle2_Leave(object sender, EventArgs e)
        {
            if (textBoxArticle2.Text == "")
            {
                textBoxArticle2.Text = "Артикул";
                textBoxArticle2.ForeColor = Color.Silver;
            }
        }

        private void textBoxName2_Enter(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "Название")
            {
                textBoxName2.Text = "";
                textBoxName2.ForeColor = Color.Black;
            }
        }

        private void textBoxName2_Leave(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "")
            {
                textBoxName2.Text = "Название";
                textBoxName2.ForeColor = Color.Silver;
            }
        }

        private void textBoxAmount2_Enter(object sender, EventArgs e)
        {
            if (textBoxAmount2.Text == "Количество")
            {
                textBoxAmount2.Text = "";
                textBoxAmount2.ForeColor = Color.Black;
            }
        }

        private void textBoxAmount2_Leave(object sender, EventArgs e)
        {
            if (textBoxAmount2.Text == "")
            {
                textBoxAmount2.Text = "Количество";
                textBoxAmount2.ForeColor = Color.Silver;
            }
        }

        private void textBoxPrice2_Enter(object sender, EventArgs e)
        {
            if (textBoxPrice2.Text == "Цена")
            {
                textBoxPrice2.Text = "";
                textBoxPrice2.ForeColor = Color.Black;
            }
        }

        private void textBoxPrice2_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice2.Text == "")
            {
                textBoxPrice2.Text = "Цена";
                textBoxPrice2.ForeColor = Color.Silver;
            }
        }
    }
}
