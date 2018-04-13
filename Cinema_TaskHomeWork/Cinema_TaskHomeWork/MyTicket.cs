using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_TaskHomeWork
{
    public partial class MyTicket : Form
    {
        public MyTicket()
        {
            int count = 0;
            InitializeComponent();
            foreach (Button seats in Zal.List)
            { 
                rezervedSeatsBox.Text += seats.Text+", ";
                count++;
                var price = count * 7;
                PriceBox.Text = price.ToString();
                
            }
            SeasonBox.Text = Zal.seansCheck;
        
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var NewRezervation = new Zal();
            NewRezervation.Show();
            var mytkt = new MyTicket();
            mytkt.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var GoBack = new Cinema();
            GoBack.Show();
            this.Close();
        }
    }
}
