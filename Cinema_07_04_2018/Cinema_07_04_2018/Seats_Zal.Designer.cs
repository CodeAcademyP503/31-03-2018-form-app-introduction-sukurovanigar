namespace Cinema_07_04_2018
{
    partial class Seats_Zal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Exitbtn2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "ZAL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(1219, 133);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(22, 97);
            this.Exitbtn.TabIndex = 1;
            this.Exitbtn.Text = "EXIT";
            this.Exitbtn.UseVisualStyleBackColor = true;
            // 
            // Exitbtn2
            // 
            this.Exitbtn2.Location = new System.Drawing.Point(12, 133);
            this.Exitbtn2.Name = "Exitbtn2";
            this.Exitbtn2.Size = new System.Drawing.Size(22, 97);
            this.Exitbtn2.TabIndex = 1;
            this.Exitbtn2.Text = "EXIT";
            this.Exitbtn2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Exitbtn2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rezerv Et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Seats_Zal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_07_04_2018.Properties.Resources.ZAL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1253, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Exitbtn2);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.button1);
            this.Name = "Seats_Zal";
            this.Text = "Seats_Zal";
            this.Load += new System.EventHandler(this.Seats_Zal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Exitbtn2;
        private System.Windows.Forms.Button button2;
    }
}