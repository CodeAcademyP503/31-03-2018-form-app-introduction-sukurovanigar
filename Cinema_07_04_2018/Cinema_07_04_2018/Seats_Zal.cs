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
    public partial class Seats_Zal : Form
    {
        

        public int RowCount = 6;
        public int ColumnCount = 9;
        public int LeftPos = 420;
        public int TopPos = 150;
        public int SeatNumber = 1;
        public static List<Button> Selecteds = new List<Button>();

        public Seats_Zal()
        {
            InitializeComponent();


            for (int row = 0; row < RowCount; row++)
            {
                for (int column = 0; column < ColumnCount;  column++)
                {
                    var seat = new Button();
                    seat.FlatStyle = FlatStyle.Flat;
                    seat.FlatAppearance.BorderSize=1;
                    seat.FlatAppearance.BorderColor=Color.White;
                    seat.FlatAppearance.CheckedBackColor = Color.PaleGoldenrod;
                    seat.Width = 50;
                    seat.Height = 50;
                    seat.Left = LeftPos+5;
                    seat.Top = TopPos+5;
                    seat.Text = SeatNumber.ToString();
                    seat.ForeColor = Color.White;
                    SeatNumber++;
                    Controls.Add(seat);
                    seat.Click += new EventHandler(SelectSeat); 
                    LeftPos += 50;
                   
                }
                LeftPos = 420;
                TopPos += 50;
            }
           
        }
 
       public void SelectSeat(object obj, EventArgs e)
            {
            var btn = obj as Button;
            btn.BackColor = Color.Green;
            btn.Enabled = false;
            Selecteds.Add(btn);
        }

        private void Seats_Zal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkGreen;
            var reserve = new Netice();
            reserve.Show();


        }
    }
}
