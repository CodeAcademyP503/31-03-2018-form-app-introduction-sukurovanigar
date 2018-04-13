using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cinema_TaskHomeWork
{
    public partial class Cinema : Form
    {
        public Cinema()

        {
            Thread t = new Thread( new ThreadStart(Startap));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
             t.Abort();
            this.pictureBox2.Click += new EventHandler(pictureBox2_Click);
            this.pictureBox3.Click += new EventHandler(pictureBox3_Click);
            this.pictureBox4.Click += new EventHandler(pictureBox4_Click);
            this.pictureBox5.Click += new EventHandler(pictureBox5_Click);
            this.button2.Click += new EventHandler(button2_Click);
            this.button3.Click += new EventHandler(button3_Click);
            this.button4.Click += new EventHandler(button4_Click);
            this.button5.Click += new EventHandler(button5_Click);

        }
        public void Startap()
        {
            Application.Run(new Start());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var picture = new Zal();
            picture.Show();
           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var picture1 = new Zal();
            picture1.Show();
            
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var picture2 = new Zal();
            picture2.Show();
           
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var picture3 = new Zal();
            picture3.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var picture4 = new Zal();
            picture4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pricebtn = new Zal();
            pricebtn.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var pricebtn1 = new Zal();
            pricebtn1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var pricebtn2 = new Zal();
            pricebtn2.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var pricebtn3 = new Zal();
            pricebtn3.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var pricebtn4 = new Zal();
            pricebtn4.Show();
        }
    }
}
