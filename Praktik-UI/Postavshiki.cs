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
    public partial class Postavshiki : Form
    {
        public Postavshiki()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suppliers SMenu = new Suppliers();
            SMenu.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suppliers1 SMenu = new Suppliers1();
            SMenu.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suppliers2 SMenu = new Suppliers2();
            SMenu.Show();
            
        }

        private void Postavshiki_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            ManagerMenu MM = new ManagerMenu();
            MM.Show();
            

        }
    }
}
