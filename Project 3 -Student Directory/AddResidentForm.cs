using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3__Student_Directory
{
    public partial class AddResidentForm : Form
    {
           


        public AddResidentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             FileStream file = new FileStream("Students.csv", FileMode.Open, FileAccess.Read);
             StreamReader reader = new StreamReader(file);

            int x = 0;
            int y = 0;
            int z = 0;

            string line = reader.ReadLine();
            while (line != null)
            {
                
                char delimeter = ',';
                string[] row = line.Split(delimeter);
                if (row[2] == "Athlete")
                {
                    x = x + 1;
                }
                if (row[2] == "Scholarship")
                {
                    y = y + 1;
                }
                if (row[2] == "Worker")
                {
                    z = z + 1;
                }
                line = reader.ReadLine();
            }
            reader.Close();
            file.Close();
            Athlete[] athletes = new Athlete[x];
            Scholarship[] scholarships = new Scholarship[y];
            Worker[] workers = new Worker[z];

            FileStream file2 = new FileStream("Students.csv", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(file2); //Read through the lines again

            int length = x + y + z;
            line = reader2.ReadLine();
            int b = 0;
            int c = 0;
            int d = 0;
            string[] IDList = { };
            for (var a = 0; a < length; a++) //Assign information to each object
            {
                line = reader2.ReadLine();
                string[] row = line.Split(',');

                if (row[2] == "Athlete")
                {
                    athletes[b] = new Athlete(row[0], row[1], row[2], row[3], row[4], row[5]);
                    b = b + 1;
                }
                if (row[2] == "Scholarship")
                {
                    scholarships[c] = new Scholarship(row[0], row[1], row[2], row[3], row[4], row[5]);
                    c = c + 1;
                }
                if (row[2] == "Worker")
                {
                    workers[d] = new Worker(row[0], row[1], row[2], row[3], row[4], row[5]);
                    d = d + 1;
                }
                string[] temp = { row[4] };
                IDList = IDList.Concat(temp).ToArray();

            }
            reader2.Close();
            file2.Close();

            FileStream add = new FileStream("Students.csv", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(add);

            string firstname = firstnameBox.Text;
            string lastname = lastnameBox.Text;
            string studentType = studentTypeBox.Text;
            string floorNumber = floorBox.Text;
            string studentID = idBox.Text;
            string hoursWorked = hoursBox.Text;
            string[] residentInfo = { };

            bool check = false;
            for (var i = 0; i < IDList.Length; i++)
            {
                if (studentID == IDList[i])
                {
                    check = true;
                }
            }

            int floor = 0;

            if (floorNumber != "1" && floorNumber != "2" && floorNumber != "3" && floorNumber != "4" && floorNumber != "5" && floorNumber != "6" && floorNumber != "7" && floorNumber != "8" && floorNumber != "9")
            {
                warningFloor.Text = "*Invalid floor number.";
            }
            else
            {
                warningFloor.Text = "*";
                floor = Int32.Parse(floorNumber);
            }


            if (firstname == "" || lastname == "")
            {
                warningLabel.Text = "*Please enter a first and last name.";
            }
            

            else if (studentType != "Athlete" && studentType != "Scholarship" && studentType != "Worker")
            {
                warningLabel.Text = "*Invalid student type entered";
            }

            else if (studentType == "Worker" && floor > 3)
            {   
                warningLabel.Text = "*Student Workers can only be placed on floors 1-3.";   
            }

            else if (studentType == "Athlete" && floor >= 7 || studentType == "Athlete" && floor <= 3)
            {
                warningLabel.Text = "*Student Athletes can only be placed on floors 4-6.";   
            }

            else if (studentType == "Scholarship" && floor < 7)
            {
                warningLabel.Text = "*Scholarship Students can only be placed on floors 7-8.";
            }

            else if (studentType == "Worker" && hoursWorked == "0")
            {
                warningLabel.Text = "*Please enter the weekly hours for the student worker.";
            }

            else if (studentType == "Athlete" && hoursWorked != "0" || studentType == "Scholarship" && hoursWorked != "0")
            {
                warningLabel.Text = "*Only student workers may have weekly hours.";
                hoursBox.Text = "0";
            }

            else if (studentID.Length != 4)
            {
                warningLabel.Text = "*Student ID must be 4 numbers long.";
            }
            else if (check == true)
            {
                IdCheckLabel.Text = "*Entered ID was already taken.";
                idBox.Text = "";
            }
            else
            {
                IdCheckLabel.Text = "*";
                warningLabel.Text = "*New Resident was successfully added!";

                writer.WriteLine("{0},{1},{2},{3},{4},{5}", firstname, lastname, studentType, floorNumber, studentID, hoursWorked);
                

            }

            

            writer.Close();
            add.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
