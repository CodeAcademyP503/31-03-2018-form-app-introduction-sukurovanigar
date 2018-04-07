using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_07_04_2018
{
    public partial class Netice : Form
    {
        public Netice()
        {
            InitializeComponent();
            foreach (Button item in Seats_Zal.Selecteds)
            {
                bilets.Text += item.Text + ", ";
               

            }
            var mblg = "Mebleg " + Seats_Zal.Selecteds.Count * 7 + " AZN";
                bilets.Text += mblg;
        }

        private void Netice_Load(object sender, EventArgs e)
        {

        }
    }
}
