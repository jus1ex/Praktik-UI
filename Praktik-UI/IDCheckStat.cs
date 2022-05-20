using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktik_UI
{
    public partial class IDCheckStat : Form
    {
        int IAmount = 0;
        int IPrice = 0;
        public IDCheckStat()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
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

        private void IDCheckStat_Load(object sender, EventArgs e)
        {
            if (textBoxArticle.Text == "")
            {
                textBoxArticle.Text = "Артикул";
                textBoxArticle.ForeColor = Color.Silver;
            }
            ApplyButton.Select();
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

        private void Load_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (string.IsNullOrEmpty(openFileDialog1.FileName)||openFileDialog1.FileName=="openFileDialog1")
            {
                return;
            }
            openFileDialog1.DefaultExt = ".txt";
            FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);
            if (!File.Exists(openFileDialog1.FileName) || fileInfo.Extension != ".txt")
            {
                return;
            }
            StorageClass.Storage.PartList.Clear();
            StreamReader reader = new StreamReader(openFileDialog1.FileName);
            string StringToRead;
            while ((StringToRead = reader.ReadLine()) != null)
            {
                string[] PartsInfo = StringToRead.Split(' ');
                string PartName = PartsInfo[1];
                string PartId = PartsInfo[0];
                string PartAmount = PartsInfo[5];
                string PartPrice = PartsInfo[3];
                PartClass.Part NewPart = new PartClass.Part(PartName, PartAmount, PartPrice, PartId);
                StorageClass.Storage.IDCheck.Add(NewPart);
            }
            reader.Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int TempIAmount=0;
            int TempIPrice=0;
            if (textBoxArticle.Text == "Артикул")
            {
                return;
            }
            string ID = textBoxArticle.Text;
            if (CheckID(ID))
            {
                MessageBox.Show("Неверный формат артикула!", "Ошибка!");
                return;
            }    
            for (int i = 0; i < StorageClass.Storage.IDCheck.Count; i++)
            {
                if (StorageClass.Storage.IDCheck[i]._getid() == ID)
                {
                    TempIAmount = System.Convert.ToInt32(StorageClass.Storage.IDCheck[i]._getamount());
                    TempIPrice = System.Convert.ToInt32(StorageClass.Storage.IDCheck[i]._getprice());
                    IAmount += TempIAmount;
                    IPrice += TempIAmount * TempIPrice;
                }
            }
            MessageBox.Show($"Итоговая доходность товара: {IPrice}\nИтоговое количество проданных товаров: {IAmount}", "Итог");
            StorageClass.Storage.IDCheck.Clear();
            IAmount = 0;
            IPrice = 0;
        }
    }
}
