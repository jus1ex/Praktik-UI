using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktik_UI
{
    public partial class SuppliersOrder2 : Form
    {
        public SuppliersOrder2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Suppliers2Grid.Rows.Clear();
            Suppliers2Grid.RowCount = 0;
            for (int i = 0; i < StorageClass.Storage.PartList.Count(); i++)
            {
                Suppliers2Grid.Rows.Add(i + 1, StorageClass.Storage.PartList[i]._getid(), StorageClass.Storage.PartList[i]._getname(), StorageClass.Storage.PartList[i]._getamount(), StorageClass.Storage.PartList[i]._getprice());
            }
        }

        private void buy1_Click(object sender, EventArgs e)
        {
            BuyMenu NewFoem = new BuyMenu();
            NewFoem.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (StorageClass.Storage.Cart.Count == 0)
            {
                MessageBox.Show("Корзина пуста!", "Неудача!");
                return;
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\CarHelpOrders.txt"; ;
            for (int i = 0; i < StorageClass.Storage.Cart.Count(); i++)
            {
                string s = StorageClass.Storage.Cart[i]._getid() + " " + StorageClass.Storage.Cart[i]._getname() + " Цена: " + StorageClass.Storage.Cart[i]._getprice() + " Количество: " + StorageClass.Storage.Cart[i]._getamountcart() + " Дата заказа: " + StorageClass.Storage.Cart[i]._getdate() + '\n';
                File.AppendAllText(path, s);
            }
            StorageClass.Storage.Cart.Clear();
            MessageBox.Show("Заказ оформлен!", "Успех!");
        }

        private void back_Click(object sender, EventArgs e)
        {
            BuyerForm NewForm = new BuyerForm();
            NewForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SuppliersOrder2_Load(object sender, EventArgs e)
        {
            StorageClass.Storage.PartList.Clear();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\CarHelp.txt"; ;
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                string StringToRead;
                while ((StringToRead = reader.ReadLine()) != null)
                {
                    string[] PartsInfo = StringToRead.Split(' ');
                    string PartName = PartsInfo[1];
                    string PartId = PartsInfo[0];
                    string PartAmount = PartsInfo[2];
                    string PartPrice = PartsInfo[3];
                    PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
                    StorageClass.Storage.PartList.Add(NewPart);
                }
                reader.Close();
            }
            Suppliers2Grid.Rows.Clear();
            Suppliers2Grid.RowCount = 0;
            for (int i = 0; i < StorageClass.Storage.PartList.Count(); i++)
            {
                Suppliers2Grid.Rows.Add(i + 1, StorageClass.Storage.PartList[i]._getid(), StorageClass.Storage.PartList[i]._getname(), StorageClass.Storage.PartList[i]._getamount(), StorageClass.Storage.PartList[i]._getprice());
            }

        }
    }
}
