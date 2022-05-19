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
    public partial class DeleteRecord1 : Form
    {
        public DeleteRecord1()
        {
            InitializeComponent();
        }

        private void deleteBox1_Enter(object sender, EventArgs e)
        {
            if (deleteBox1.Text == "Номер")
            {
                deleteBox1.Text = "";
                deleteBox1.ForeColor = Color.Black;
            }
        }

        private void deleteBox1_Leave(object sender, EventArgs e)
        {
            if (deleteBox1.Text == "")
            {
                deleteBox1.Text = "Номер";
                deleteBox1.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(deleteBox1.Text);
            StorageClass.Storage.PartList.RemoveAt(number - 1);
            MessageBox.Show("Товар удален из списка!", "Успех!");
        }
    }
}
