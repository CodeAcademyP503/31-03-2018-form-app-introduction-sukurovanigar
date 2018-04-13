namespace Cinema_TaskHomeWork
{
    partial class Zal
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
            this.ExitBtn1 = new System.Windows.Forms.Button();
            this.ExitBtn2 = new System.Windows.Forms.Button();
            this.Zalbtn = new System.Windows.Forms.Button();
            this.rezerveBtn = new System.Windows.Forms.Button();
            this.sns17 = new System.Windows.Forms.RadioButton();
            this.sns23 = new System.Windows.Forms.RadioButton();
            this.process1 = new System.Diagnostics.Process();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sns19 = new System.Windows.Forms.RadioButton();
            this.sns12 = new System.Windows.Forms.RadioButton();
            this.sns21 = new System.Windows.Forms.RadioButton();
            this.sns14 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn1
            // 
            this.ExitBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn1.Location = new System.Drawing.Point(3, 93);
            this.ExitBtn1.Name = "ExitBtn1";
            this.ExitBtn1.Size = new System.Drawing.Size(21, 86);
            this.ExitBtn1.TabIndex = 0;
            this.ExitBtn1.Text = "EXIT";
            this.ExitBtn1.UseVisualStyleBackColor = true;
            this.ExitBtn1.Click += new System.EventHandler(this.ExitBtn1_Click);
            // 
            // ExitBtn2
            // 
            this.ExitBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn2.Location = new System.Drawing.Point(767, 93);
            this.ExitBtn2.Name = "ExitBtn2";
            this.ExitBtn2.Size = new System.Drawing.Size(21, 86);
            this.ExitBtn2.TabIndex = 0;
            this.ExitBtn2.Text = "EXIT";
            this.ExitBtn2.UseVisualStyleBackColor = true;
            // 
            // Zalbtn
            // 
            this.Zalbtn.AllowDrop = true;
            this.Zalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zalbtn.Location = new System.Drawing.Point(219, 12);
            this.Zalbtn.Name = "Zalbtn";
            this.Zalbtn.Size = new System.Drawing.Size(328, 44);
            this.Zalbtn.TabIndex = 0;
            this.Zalbtn.Text = "ZAL";
            this.Zalbtn.UseVisualStyleBackColor = true;
            // 
            // rezerveBtn
            // 
            this.rezerveBtn.AllowDrop = true;
            this.rezerveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rezerveBtn.ForeColor = System.Drawing.Color.Maroon;
            this.rezerveBtn.Location = new System.Drawing.Point(513, 417);
            this.rezerveBtn.Name = "rezerveBtn";
            this.rezerveBtn.Size = new System.Drawing.Size(236, 27);
            this.rezerveBtn.TabIndex = 0;
            this.rezerveBtn.Text = "REZERV ET";
            this.rezerveBtn.UseVisualStyleBackColor = true;
            this.rezerveBtn.Click += new System.EventHandler(this.rezerveBtn_Click);
            // 
            // sns17
            // 
            this.sns17.AutoSize = true;
            this.sns17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sns17.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.sns17.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.sns17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.sns17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.sns17.Location = new System.Drawing.Point(6, 67);
            this.sns17.Name = "sns17";
            this.sns17.Size = new System.Drawing.Size(85, 17);
            this.sns17.TabIndex = 1;
            this.sns17.TabStop = true;
            this.sns17.Text = "Seans 17:00";
            this.sns17.UseVisualStyleBackColor = true;
            this.sns17.CheckedChanged += new System.EventHandler(this.sns12_CheckedChanged);
            // 
            // sns23
            // 
            this.sns23.AutoSize = true;
            this.sns23.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.sns23.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.sns23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.sns23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.sns23.Location = new System.Drawing.Point(109, 67);
            this.sns23.Name = "sns23";
            this.sns23.Size = new System.Drawing.Size(85, 17);
            this.sns23.TabIndex = 2;
            this.sns23.TabStop = true;
            this.sns23.Text = "Seans 23:00";
            this.sns23.UseVisualStyleBackColor = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.sns14);
            this.groupBox1.Controls.Add(this.sns21);
            this.groupBox1.Controls.Add(this.sns12);
            this.groupBox1.Controls.Add(this.sns19);
            this.groupBox1.Controls.Add(this.sns17);
            this.groupBox1.Controls.Add(this.sns23);
            this.groupBox1.Location = new System.Drawing.Point(12, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // sns19
            // 
            this.sns19.AutoSize = true;
            this.sns19.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.sns19.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.sns19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.sns19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.sns19.Location = new System.Drawing.Point(109, 19);
            this.sns19.Name = "sns19";
            this.sns19.Size = new System.Drawing.Size(85, 17);
            this.sns19.TabIndex = 2;
            this.sns19.TabStop = true;
            this.sns19.Text = "Seans 19:30";
            this.sns19.UseVisualStyleBackColor = true;
            // 
            // sns12
            // 
            this.sns12.AutoSize = true;
            this.sns12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sns12.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.sns12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.sns12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.sns12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.sns12.Location = new System.Drawing.Point(6, 19);
            this.sns12.Name = "sns12";
            this.sns12.Size = new System.Drawing.Size(85, 17);
            this.sns12.TabIndex = 1;
            this.sns12.TabStop = true;
            this.sns12.Text = "Seans 12:00";
            this.sns12.UseVisualStyleBackColor = true;
            this.sns12.CheckedChanged += new System.EventHandler(this.sns12_CheckedChanged);
            // 
            // sns21
            // 
            this.sns21.AutoSize = true;
            this.sns21.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.sns21.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.sns21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.sns21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.sns21.Location = new System.Drawing.Point(109, 42);
            this.sns21.Name = "sns21";
            this.sns21.Size = new System.Drawing.Size(85, 17);
            this.sns21.TabIndex = 2;
            this.sns21.TabStop = true;
            this.sns21.Text = "Seans 21:00";
            this.sns21.UseVisualStyleBackColor = true;
            this.sns21.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // sns14
            // 
            this.sns14.AutoSize = true;
            this.sns14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sns14.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.sns14.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.sns14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.sns14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.sns14.Location = new System.Drawing.Point(6, 42);
            this.sns14.Name = "sns14";
            this.sns14.Size = new System.Drawing.Size(85, 17);
            this.sns14.TabIndex = 1;
            this.sns14.TabStop = true;
            this.sns14.Text = "Seans 14:30";
            this.sns14.UseVisualStyleBackColor = true;
            this.sns14.CheckedChanged += new System.EventHandler(this.sns12_CheckedChanged);
            // 
            // Zal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(791, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn2);
            this.Controls.Add(this.rezerveBtn);
            this.Controls.Add(this.Zalbtn);
            this.Controls.Add(this.ExitBtn1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Zal";
            this.Text = "Zal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn1;
        private System.Windows.Forms.Button ExitBtn2;
        private System.Windows.Forms.Button Zalbtn;
        private System.Windows.Forms.Button rezerveBtn;
        private System.Windows.Forms.RadioButton sns17;
        private System.Windows.Forms.RadioButton sns23;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sns14;
        private System.Windows.Forms.RadioButton sns21;
        private System.Windows.Forms.RadioButton sns12;
        private System.Windows.Forms.RadioButton sns19;
    }
}