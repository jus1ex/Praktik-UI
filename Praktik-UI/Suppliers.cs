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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\AutoDoc.txt"; ;


            
                for (int i = 0; i < StorageClass.Storage.PartList.Count(); i++)
                {
                       string s =StorageClass.Storage.PartList[i]._getid() + " " + StorageClass.Storage.PartList[i]._getname() + " " + StorageClass.Storage.PartList[i]._getamount() + " " + StorageClass.Storage.PartList[i]._getprice()+'\n';
                       File.AppendAllText(path,s);
                }
                
                MessageBox.Show("Информация выведена в файл!", "Успех!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRecord add = new AddRecord();
            add.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.ShowDialog();
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
                string PartAmount = PartsInfo[2];
                string PartPrice = PartsInfo[3];
                PartClass.Part NewPart=new PartClass.Part(PartName,PartAmount,PartPrice,PartId);
                StorageClass.Storage.PartList.Add(NewPart);
            }
            reader.Close();
            MessageBox.Show("Успешно считано!", "Успех!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuppliersGrid.Rows.Clear();
            SuppliersGrid.RowCount = 0;
            for(int i=0;i<StorageClass.Storage.PartList.Count();i++)
            {
                SuppliersGrid.Rows.Add(i+1,StorageClass.Storage.PartList[i]._getid(), StorageClass.Storage.PartList[i]._getname(), StorageClass.Storage.PartList[i]._getamount(), StorageClass.Storage.PartList[i]._getprice());
            }
        }

        private void SuppliersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buy1_Click(object sender, EventArgs e)
        {
            BuyMenu buy = new BuyMenu();
            buy.Show();
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            Postavshiki post = new Postavshiki();
            post.Show();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteRecord dr = new DeleteRecord();
            dr.Show();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            StorageClass.Storage.PartList.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
