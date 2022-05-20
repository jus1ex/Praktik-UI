using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            amountbox.Text = "Количество";
            amountbox.ForeColor = Color.Silver;
            numberbox.Text = "Номер";
            numberbox.ForeColor = Color.Silver;
            byubutton.Select();

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

        private void byubutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numberbox.Text))
            {
                return;
            }
            if(string.IsNullOrEmpty(amountbox.Text))
            {
                return ;
            }
            string snumber=numberbox.Text;
            if (CheckID(snumber)==false)
            {
                MessageBox.Show("Неверный формат номера!", "Ошибка!");
            }
            int number = System.Convert.ToInt32(numberbox.Text);
            string samount =amountbox.Text;
            if (CheckAmount(samount)==false)
            {
                MessageBox.Show("Неверный формат количества!", "Ошибка!");
            }
            int amount = System.Convert.ToInt32(amountbox.Text);
            if (number > StorageClass.Storage.PartList.Count())
            {
                MessageBox.Show("Нет такого товара!", "Неудача!");
                return;
            }
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
                    StorageClass.Storage.Cart[i]._setdate(DateTime.Now);
                    for(int j = 0; j < StorageClass.Storage.PartList.Count(); j++)
                    {
                        if (StorageClass.Storage.PartList[j]._getid()==StorageClass.Storage.Cart[i]._getid())
                        {
                            int newamount = System.Convert.ToInt32(StorageClass.Storage.PartList[j]._getamount()) - System.Convert.ToInt32(StorageClass.Storage.Cart[i]._getamountcart());
                            StorageClass.Storage.PartList[j]._setamount(System.Convert.ToString(newamount));
                        }
                    }
                    MessageBox.Show("Товар успешно добавлен!", "Успех!");
                }
            }
            for (int i = 0; i < StorageClass.Storage.PartList.Count(); i++)
            {
                if (StorageClass.Storage.PartList[i]._getamount() == "0")
                {
                    StorageClass.Storage.PartList.RemoveAt(i);
                }
            }
        }

        private void numberbox_Enter(object sender, EventArgs e)
        {
            if (numberbox.Text == "Номер")
            {
                numberbox.Text = "";
                numberbox.ForeColor = Color.Black;
            }
        }

        private void numberbox_Leave(object sender, EventArgs e)
        {
            if (numberbox.Text == "")
            {
                numberbox.Text = "Номер";
                numberbox.ForeColor = Color.Silver;
            }
        }

        private void amountbox_Enter(object sender, EventArgs e)
        {
            if (amountbox.Text == "Количество")
            {
                amountbox.Text = "";
                amountbox.ForeColor = Color.Black;
            }
        }

        private void amountbox_Leave(object sender, EventArgs e)
        {
            if (amountbox.Text == "")
            {
                amountbox.Text = "Количество";
                amountbox.ForeColor = Color.Silver;
            }
        }
    }
}
