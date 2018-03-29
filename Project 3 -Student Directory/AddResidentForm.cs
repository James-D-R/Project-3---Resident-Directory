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
            warningLabel.Hide();
            warningFloor.Hide();
            IdCheckLabel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            warningFloor.Hide();
            IdCheckLabel.Hide();

            //read file
            FileStream file = new FileStream("Students.csv", FileMode.Open, FileAccess.Read);
             StreamReader reader = new StreamReader(file);


            string[] IDList = { };
            string line = reader.ReadLine();
            while (line != null) //Create a list of all IDs for checking later
            {
                char delimeter = ',';
                string[] row = line.Split(delimeter);
                string[] temp = { row[4] };
                IDList = IDList.Concat(temp).ToArray();
                line = reader.ReadLine();
            }
            reader.Close();
            file.Close();

            //writng to the file
            FileStream add = new FileStream("Students.csv", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(add);

            string firstname = firstnameBox.Text;
            string lastname = lastnameBox.Text;
            string studentType = studentTypeBox.Text;
            string floorNumber = floorBox.Text;
            string studentID = idBox.Text;
            string hoursWorked = hoursBox.Text;
            string[] residentInfo = { };


            //Start of defensive programming section
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
                warningFloor.Show();
                warningFloor.Text = "*Invalid floor number.";
            }
            else
            {
                warningFloor.Text = "*";
                floor = Int32.Parse(floorNumber);
            }


            if (firstname == "" || lastname == "")
            {
                warningLabel.Show();
                warningLabel.Text = "*Please enter a first and last name.";
            }
            

            else if (studentType != "Athlete" && studentType != "Scholarship" && studentType != "Worker")
            {
                warningLabel.Show();
                warningLabel.Text = "*Invalid student type entered";
            }

            else if (studentType == "Worker" && floor > 3)
            {
                warningLabel.Show();
                warningLabel.Text = "*Student Workers can only be placed on floors 1-3.";   
            }

            else if (studentType == "Athlete" && floor >= 7 || studentType == "Athlete" && floor <= 3)
            {
                warningLabel.Show();
                warningLabel.Text = "*Student Athletes can only be placed on floors 4-6.";   
            }

            else if (studentType == "Scholarship" && floor < 7)
            {
                warningLabel.Show();
                warningLabel.Text = "*Scholarship Students can only be placed on floors 7-8.";
            }

            else if (studentType == "Worker" && hoursWorked == "0")
            {
                warningLabel.Show();
                warningLabel.Text = "*Please enter the weekly hours for the student worker.";
            }

            else if (studentType == "Athlete" && hoursWorked != "0" || studentType == "Scholarship" && hoursWorked != "0")
            {
                warningLabel.Show();
                warningLabel.Text = "*Only student workers may have weekly hours.";
                hoursBox.Text = "0";
            }

            else if (studentID.Length != 4)
            {
                warningLabel.Show();
                warningLabel.Text = "*Student ID must be 4 numbers long.";
            }

            else if (check == true)
            {
                IdCheckLabel.Show();
                IdCheckLabel.Text = "*Entered ID was already taken.";
                idBox.Text = "";
            }
            //end of defensive programming

            else //If no incorrect user input, information is written to the csv file
            {
                IdCheckLabel.Text = "*";
                warningLabel.Text = "*New Resident was successfully added!";

                writer.WriteLine("{0},{1},{2},{3},{4},{5}", firstname, lastname, studentType, floorNumber, studentID, hoursWorked);
                firstnameBox.Text = "";
                lastnameBox.Text = "";
                idBox.Text = "";

            }

            //close files
            writer.Close();
            add.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Return button
        {
            this.Close();
        }

        private void hoursBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void floorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void studentTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentTypeBox.Text == "Worker")
            {
                floorBox.Items.Clear();
                string[] a = { "1", "2", "3" };
                floorBox.Items.AddRange(a);
            }

            if (studentTypeBox.Text == "Athlete")
            {
                floorBox.Items.Clear();
                string[] b = { "4", "5", "6" };
                floorBox.Items.AddRange(b);
            }

            if (studentTypeBox.Text == "Scholarship")
            {
                floorBox.Items.Clear();
                string[] c = { "7", "8" };
                floorBox.Items.AddRange(c);
            }
        }
    }
}
