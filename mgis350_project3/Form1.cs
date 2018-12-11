using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mgis350_project3
{
    public partial class Form1 : Form
    {
        Database db = new Database();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnStrawberry_Click(object sender, EventArgs e)
        {
            db.UpdateInv("strawberries", 32);
        }

        private void btnBanana_Click(object sender, EventArgs e)
        {
            db.UpdateInv("bananas", 16);
        }

        private void btnHoney_Click(object sender, EventArgs e)
        {
            db.UpdateInv("honey", 16);
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            db.UpdateInv("milk", 128);
        }

        private void btnSmallCups_Click(object sender, EventArgs e)
        {
            db.UpdateInv("smallcups", 250);
        }

        private void btnLargeCups_Click(object sender, EventArgs e)
        {
            db.UpdateInv("largecups", 250);
        }
    }
}
