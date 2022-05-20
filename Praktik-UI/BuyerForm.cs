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
    public partial class BuyerForm : Form
    {
        public BuyerForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuppliersOrder NewForm=new SuppliersOrder();
            NewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuppliersOrder2 NewForm=new SuppliersOrder2();
            NewForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuppliersOrder3 NewForm=new SuppliersOrder3();
            NewForm.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu NewForm = new MainMenu();
            NewForm.Show();
        }
    }
}
