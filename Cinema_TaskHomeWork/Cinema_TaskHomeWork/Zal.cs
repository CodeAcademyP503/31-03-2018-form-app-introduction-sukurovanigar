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
    public partial class Zal : Form
    {
        public static string seansCheck;
        public int Row=4;
        public int Column;
        public int SeatsCount = 1;
        public static List<Button> List = new List<Button>();
       
        public Zal()
        {
            InitializeComponent();
            this.ExitBtn2.Click += new EventHandler(ExitBtn2_Click);
            int LeftPos;
            int seatlenght = 17;//bu eslinde rowun uzunlugudu
            for (int row = 1; row <= Row; row++)
            {
                if (row == 1)//bu ise rowun sirasi
                {
                    seatlenght = 11;//yeni 1 ci setrde 11 dene btn qoy
                }
                if (row == 2)// 2ci sirada
                {
                    seatlenght = 12;//  12 btn qoy
                }
                if (row == 3)
                {
                    seatlenght = 14;
                }
                if (row == 4)
                {
                    seatlenght = 17;
                }
                for (int col = 0; col < seatlenght; col++)// bu ise btnlerin dizayn gorunusunu tamamlayir. Sagdan nece btn mesafede oldugunu gosterir..
                {
                    LeftPos = 0;
                    if (row == 1)
                    {
                        LeftPos = 8;//piramida gorunusu ucun sagdan 8 btn mesafe
                    }
                    if (row == 2)
                    {
                        LeftPos = 7;//piramida gorunusu ucun sagdan 7 btn mesafe
                    }
                    if (row == 3)
                    {
                        LeftPos = 5;//piramida gorunusu ucun sagdan 5 btn mesafe
                    }
                    if (row == 4)
                    {
                        LeftPos = 2;//piramida gorunusu ucun sagdan 2 btn mesafe
                    }
                    var btn = new Button();
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Left = (((btn.Width+1) * col) + (20 * LeftPos) - 10); // "btnleri oz enine (widthine) gore leftden mesafe qoy" sonra ise "setire uygun leftPosu 20 ye vur 10 u cix simmetriya ucun." ve bu ikisini topla
                    btn.Top = 130 + (44* row);//rowlar arasindaki mesafe
                    btn.Text = SeatsCount.ToString();
                    btn.Click += new EventHandler(SelectedSeat);// btnlaraa click olunanda SelectedSeat metodu ise dusecek.
                    SeatsCount++;
                    Controls.Add(btn);
              
                }
                
            }
        }
        public void SelectedSeat(object obj, EventArgs e)// bu metod btnlari secende is gorur
        {
            var selected_btn = obj as Button;
            selected_btn.BackColor = Color.DarkRed;// btn rengi deisir
            List.Add(selected_btn); // secilen btnleri liste elave edir.

        }
    
        private void ExitBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rezerveBtn_Click(object sender, EventArgs e)
        {
            foreach (Button item in List)
            {
                item.Enabled = false;
            }
            if (sns12.Checked)
            {
                seansCheck = "12:00";
            }
            if (sns14.Checked)
            {
                seansCheck = "14:30";
            }
            if (sns17.Checked)
            {
                seansCheck = "17:00";
            }
            if (sns19.Checked)
            {
                seansCheck = "19:30";
            }
            if (sns21.Checked)
            {
                seansCheck = "21:00";
            }
            if (sns23.Checked)
            {
                seansCheck = "23:00";
            }
            var ShowTickets = new MyTicket();
            ShowTickets.Show();

           
        }
     
        private void sns12_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (RadioButton item in Zal.)
            //{

            //}
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
