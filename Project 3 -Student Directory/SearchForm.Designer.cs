namespace Project_3__Student_Directory
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ResFirstname = new System.Windows.Forms.Label();
            this.ResLastname = new System.Windows.Forms.Label();
            this.ResType = new System.Windows.Forms.Label();
            this.ResFloor = new System.Windows.Forms.Label();
            this.ResHours = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ResFee = new System.Windows.Forms.Label();
            this.notFoundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resident Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(144, 84);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 22);
            this.idBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resident ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Floor No.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Weekly Hours (if applicable):";
            // 
            // ResFirstname
            // 
            this.ResFirstname.AutoSize = true;
            this.ResFirstname.Location = new System.Drawing.Point(143, 195);
            this.ResFirstname.Name = "ResFirstname";
            this.ResFirstname.Size = new System.Drawing.Size(38, 17);
            this.ResFirstname.TabIndex = 10;
            this.ResFirstname.Text = "------";
            // 
            // ResLastname
            // 
            this.ResLastname.AutoSize = true;
            this.ResLastname.Location = new System.Drawing.Point(141, 251);
            this.ResLastname.Name = "ResLastname";
            this.ResLastname.Size = new System.Drawing.Size(38, 17);
            this.ResLastname.TabIndex = 11;
            this.ResLastname.Text = "------";
            // 
            // ResType
            // 
            this.ResType.AutoSize = true;
            this.ResType.Location = new System.Drawing.Point(363, 195);
            this.ResType.Name = "ResType";
            this.ResType.Size = new System.Drawing.Size(38, 17);
            this.ResType.TabIndex = 12;
            this.ResType.Text = "------";
            // 
            // ResFloor
            // 
            this.ResFloor.AutoSize = true;
            this.ResFloor.Location = new System.Drawing.Point(333, 251);
            this.ResFloor.Name = "ResFloor";
            this.ResFloor.Size = new System.Drawing.Size(38, 17);
            this.ResFloor.TabIndex = 13;
            this.ResFloor.Text = "------";
            // 
            // ResHours
            // 
            this.ResHours.AutoSize = true;
            this.ResHours.Location = new System.Drawing.Point(271, 302);
            this.ResHours.Name = "ResHours";
            this.ResHours.Size = new System.Drawing.Size(38, 17);
            this.ResHours.TabIndex = 14;
            this.ResHours.Text = "------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Monthly Fee:";
            // 
            // ResFee
            // 
            this.ResFee.AutoSize = true;
            this.ResFee.Location = new System.Drawing.Point(157, 354);
            this.ResFee.Name = "ResFee";
            this.ResFee.Size = new System.Drawing.Size(38, 17);
            this.ResFee.TabIndex = 16;
            this.ResFee.Text = "------";
            // 
            // notFoundLabel
            // 
            this.notFoundLabel.AutoSize = true;
            this.notFoundLabel.ForeColor = System.Drawing.Color.Red;
            this.notFoundLabel.Location = new System.Drawing.Point(144, 122);
            this.notFoundLabel.Name = "notFoundLabel";
            this.notFoundLabel.Size = new System.Drawing.Size(13, 17);
            this.notFoundLabel.TabIndex = 17;
            this.notFoundLabel.Text = "*";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 449);
            this.Controls.Add(this.notFoundLabel);
            this.Controls.Add(this.ResFee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ResHours);
            this.Controls.Add(this.ResFloor);
            this.Controls.Add(this.ResType);
            this.Controls.Add(this.ResLastname);
            this.Controls.Add(this.ResFirstname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Resident Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ResFirstname;
        private System.Windows.Forms.Label ResLastname;
        private System.Windows.Forms.Label ResType;
        private System.Windows.Forms.Label ResFloor;
        private System.Windows.Forms.Label ResHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ResFee;
        private System.Windows.Forms.Label notFoundLabel;
    }
}