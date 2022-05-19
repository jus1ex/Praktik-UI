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
    public partial class BuyMenu : Form
    {
        public BuyMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuyMenu_Load(object sender, EventArgs e)
        {

        }

        private void byubutton_Click(object sender, EventArgs e)
        {
            int number = System.Convert.ToInt32(numberbox.Text);
            int amount = System.Convert.ToInt32(amountbox.Text);
            for (int i = 0; i < StorageClass.Storage.PartList.Count(); i++)
            {
                if (i==number-1)
                {
                    if (System.Convert.ToInt32(StorageClass.Storage.PartList[i]._getamount())<amount)
                    {
                        MessageBox.Show("Не хватет товара!", "Неудача!");
                        return;
                    }
                    if (number>StorageClass.Storage.PartList.Count())
                    {
                        MessageBox.Show("Нет такого товара!", "Неудача!");
                        return;
                    }
                    StorageClass.Storage.Cart.Add(StorageClass.Storage.PartList[i]);
                    StorageClass.Storage.Cart[i]._setamountcart(System.Convert.ToString(amount));
                    StorageClass
                    MessageBox.Show("Товар успешно добавлен!","Успех!");
                }
            }
        }
    }
}
