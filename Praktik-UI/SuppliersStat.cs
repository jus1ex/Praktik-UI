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
    public partial class SuppliersStat : Form
    {
        int IAmount = 0;
        int IPrice = 0;
        public SuppliersStat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IAmount = 0;
            int IPrice = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\AutoDocOrders.txt"; ;
            if (!File.Exists(path))
            {
                MessageBox.Show("У поставщика нет заказов!", "Неудача!");
                return;
            }
            StreamReader reader = new StreamReader(path);
            string StringToRead;
            while ((StringToRead = reader.ReadLine()) != null)
            {
                string[] PartsInfo = StringToRead.Split(' ');
                string PartName = PartsInfo[1];
                string PartId = PartsInfo[0];
                string PartAmount = PartsInfo[5];
                string PartPrice = PartsInfo[3];
                PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
                StorageClass.Storage.SupplierCheck.Add(NewPart);
            }
            reader.Close();
            for (int i=0;i<StorageClass.Storage.SupplierCheck.Count;i++)
            {
                IAmount+=System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getamount());
                IPrice+=System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getprice())* System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getamount());
            }
            MessageBox.Show($"Статиска AutoDoc\nОбщее количество проданных товаров: {IAmount}\nОбщая доходность: {IPrice}");
            StorageClass.Storage.SupplierCheck.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IAmount = 0;
            int IPrice = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\CarHelpOrders.txt"; ;
            if (!File.Exists(path))
            {
                MessageBox.Show("У поставщика нет заказов!", "Неудача!");
                return;
            }
            StreamReader reader = new StreamReader(path);
            string StringToRead;
            while ((StringToRead = reader.ReadLine()) != null)
            {
                string[] PartsInfo = StringToRead.Split(' ');
                string PartName = PartsInfo[1];
                string PartId = PartsInfo[0];
                string PartAmount = PartsInfo[5];
                string PartPrice = PartsInfo[3];
                PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
                StorageClass.Storage.SupplierCheck.Add(NewPart);
            }
            reader.Close();
            for (int i = 0; i < StorageClass.Storage.SupplierCheck.Count; i++)
            {
                IAmount += System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getamount());
                IPrice += System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getprice()) * System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getamount());
            }
            MessageBox.Show($"Статиска CarHelp\nОбщее количество проданных товаров: {IAmount}\nОбщая доходность: {IPrice}");
            StorageClass.Storage.SupplierCheck.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IAmount = 0;
            int IPrice = 0;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Vehicle-TuningOrders.txt"; ;
            if (!File.Exists(path))
            {
                MessageBox.Show("У поставщика нет заказов!", "Неудача!");
                return;
            }
            StreamReader reader = new StreamReader(path);
            string StringToRead;
            while ((StringToRead = reader.ReadLine()) != null)
            {
                string[] PartsInfo = StringToRead.Split(' ');
                string PartName = PartsInfo[1];
                string PartId = PartsInfo[0];
                string PartAmount = PartsInfo[5];
                string PartPrice = PartsInfo[3];
                PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
                StorageClass.Storage.SupplierCheck.Add(NewPart);
            }
            reader.Close();
            for (int i = 0; i < StorageClass.Storage.SupplierCheck.Count; i++)
            {
                IAmount += System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getamount());
                IPrice += System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getprice()) * System.Convert.ToInt32(StorageClass.Storage.SupplierCheck[i]._getamount());
            }
            MessageBox.Show($"Статиска Vehicle-Tuning\nОбщее количество проданных товаров: {IAmount}\nОбщая доходность: {IPrice}");
            StorageClass.Storage.SupplierCheck.Clear();

        }
    }
}

