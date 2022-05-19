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
    public partial class DeleteRecord2 : Form
    {
        public DeleteRecord2()
        {
            InitializeComponent();
        }

        private void deleteBox2_Enter(object sender, EventArgs e)
        {
            if (deleteBox2.Text == "Номер")
            {
                deleteBox2.Text = "";
                deleteBox2.ForeColor = Color.Black;
            }
        }

        private void deleteBox2_Leave(object sender, EventArgs e)
        {
            if (deleteBox2.Text == "")
            {
                deleteBox2.Text = "Номер";
                deleteBox2.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(deleteBox2.Text);
            StorageClass.Storage.PartList.RemoveAt(number - 1);
            MessageBox.Show("Товар удален из списка!", "Успех!");
        }
    }
}
