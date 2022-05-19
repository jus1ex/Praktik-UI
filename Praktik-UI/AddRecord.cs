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
            string PartName = textBoxName.Text;
            string PartAmount = textBoxAmount.Text;
            string PartPrice = textBoxPrice.Text;
            PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
            StorageClass.Storage.PartList.Add(NewPart);
            MessageBox.Show("Товар успешно добавлен!", "Успех!");
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
