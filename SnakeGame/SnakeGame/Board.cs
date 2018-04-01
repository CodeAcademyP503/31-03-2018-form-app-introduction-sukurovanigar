using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Board : Form
    {
        public Button LeftButton = new Button();
        public Button RightButton = new Button();
        public Button UpButton = new Button();
        public Button DownButton = new Button();

        public Button Snake = new Button();

        public int LeftPos = 0;
        public int TopPos = 0;
        public Board()
        {
            InitializeComponent();


            this.Width = 800;
            this.Height = 800;

            Snake.Width = 40;
            Snake.Height = 40;

            Snake.Left = LeftPos;
            Snake.Top = TopPos;

            LeftButton.Text = "Move Left";
            RightButton.Text = "Move Right";
            UpButton.Text = "Move Up";
            DownButton.Text = "Move Down";

            LeftButton.Left = this.Width - LeftButton.Width*3- 17;
            RightButton.Left = this.Width - RightButton.Width * 1 - 17;
            UpButton.Left = this.Width - UpButton.Width * 2 - 17;
            DownButton.Left = this.Width - DownButton.Width*2 - 17;

            LeftButton.Top = this.Height - LeftButton.Height * 2 - 40;
            RightButton.Top = this.Height - RightButton.Height * 2 - 40;
            UpButton.Top = this.Height - UpButton.Height * 3 - 40;
            DownButton.Top = this.Height - DownButton.Height * 1 - 40;



            Controls.Add(Snake);
            Controls.Add(LeftButton);
            Controls.Add(RightButton);
            Controls.Add(UpButton);
            Controls.Add(DownButton);


            LeftButton.Click += new EventHandler(MoveLeft);
            RightButton.Click += new EventHandler(MoveRight);
            UpButton.Click += new EventHandler(MoveUp);
            DownButton.Click += new EventHandler(MoveDown);
        }

        public void MoveLeft(object arrow,EventArgs m)
        {

            LeftPos -= Snake.Width;
            Snake.Left = LeftPos;

            if (LeftPos < 0)
            {
                LeftPos = this.Width - Snake.Width + 17;
            }
        }

        public void MoveRight(object arrow, EventArgs m)
        {
            
            
            LeftPos += Snake.Width;
            Snake.Left = LeftPos;
            if (LeftPos > this.Width - Snake.Width + 17)
            {
                LeftPos = 0;
            }
        }

        public void MoveUp(object arrow, EventArgs m)
        {
            
           
            TopPos -= Snake.Height;
            Snake.Top = TopPos;
            if (TopPos < 0)
            {
                TopPos = this.Height - Snake.Height - 40;
            }

        }

        public void MoveDown(object arrow, EventArgs m)
        {
           
            TopPos += Snake.Height;
            Snake.Top = TopPos;
            if (TopPos > this.Height - Snake.Height - 40)
            {
                TopPos = 0;
            }
        }

    }
}
