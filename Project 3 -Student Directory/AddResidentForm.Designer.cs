namespace Project_3__Student_Directory
{
    partial class AddResidentForm
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
            this.studentTypeBox = new System.Windows.Forms.ComboBox();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.floorBox = new System.Windows.Forms.ComboBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.firstLabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.warningFloor = new System.Windows.Forms.Label();
            this.IdCheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentTypeBox
            // 
            this.studentTypeBox.FormattingEnabled = true;
            this.studentTypeBox.Items.AddRange(new object[] {
            "Worker",
            "Athlete",
            "Scholarship"});
            this.studentTypeBox.Location = new System.Drawing.Point(145, 176);
            this.studentTypeBox.Name = "studentTypeBox";
            this.studentTypeBox.Size = new System.Drawing.Size(121, 24);
            this.studentTypeBox.TabIndex = 0;
            this.studentTypeBox.SelectedIndexChanged += new System.EventHandler(this.studentTypeBox_SelectedIndexChanged);
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(145, 92);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(100, 22);
            this.firstnameBox.TabIndex = 1;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(145, 132);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(100, 22);
            this.lastnameBox.TabIndex = 2;
            // 
            // floorBox
            // 
            this.floorBox.FormattingEnabled = true;
            this.floorBox.Location = new System.Drawing.Point(145, 223);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(121, 24);
            this.floorBox.TabIndex = 3;
            this.floorBox.SelectedIndexChanged += new System.EventHandler(this.floorBox_SelectedIndexChanged);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(279, 289);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 22);
            this.idBox.TabIndex = 4;
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(100, 92);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(39, 17);
            this.firstLabel.TabIndex = 5;
            this.firstLabel.Text = "First:";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(100, 132);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(39, 17);
            this.lastLabel.TabIndex = 6;
            this.lastLabel.Text = "Last:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(42, 179);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(97, 17);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Student Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Floor Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please Create a 4-digit Student ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Resident";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Weekly Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "(if studnet worker):";
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(448, 224);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(100, 22);
            this.hoursBox.TabIndex = 15;
            this.hoursBox.Text = "0";
            this.hoursBox.TextChanged += new System.EventHandler(this.hoursBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(98, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Add a New Resident";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(253, 363);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(13, 17);
            this.warningLabel.TabIndex = 17;
            this.warningLabel.Text = "*";
            // 
            // warningFloor
            // 
            this.warningFloor.AutoSize = true;
            this.warningFloor.ForeColor = System.Drawing.Color.Red;
            this.warningFloor.Location = new System.Drawing.Point(142, 254);
            this.warningFloor.Name = "warningFloor";
            this.warningFloor.Size = new System.Drawing.Size(13, 17);
            this.warningFloor.TabIndex = 18;
            this.warningFloor.Text = "*";
            // 
            // IdCheckLabel
            // 
            this.IdCheckLabel.AutoSize = true;
            this.IdCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.IdCheckLabel.Location = new System.Drawing.Point(386, 293);
            this.IdCheckLabel.Name = "IdCheckLabel";
            this.IdCheckLabel.Size = new System.Drawing.Size(13, 17);
            this.IdCheckLabel.TabIndex = 19;
            this.IdCheckLabel.Text = "*";
            // 
            // AddResidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 463);
            this.Controls.Add(this.IdCheckLabel);
            this.Controls.Add(this.warningFloor);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hoursBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.floorBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.studentTypeBox);
            this.Name = "AddResidentForm";
            this.Text = "Add a Resident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentTypeBox;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.ComboBox floorBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label warningFloor;
        private System.Windows.Forms.Label IdCheckLabel;
    }
}