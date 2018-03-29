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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            notFoundLabel.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("Students.csv", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            int x = 0;
            int y = 0;
            int z = 0;

            string line = reader.ReadLine();
            while (line != null) //Loop to find how many objects of each type to create
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
            }
            reader2.Close();
            file2.Close();

            string enteredID = idBox.Text;
            double hours;
            double totalHours;
            double pay;
            double totalFee;
            string displayFee;

            //Checking for any IDs that match the user inputed ID
            // then display the corresponding data from the object
            for (var i = 0; i < athletes.Length; i++)
            {
                
                if ( enteredID == athletes[i].ID)
                {
                    ResFirstname.Text = athletes[i].FirstName;
                    ResLastname.Text = athletes[i].LastName;
                    ResType.Text = athletes[i].Type;
                    ResFloor.Text = athletes[i].Floor;
                    ResHours.Text = athletes[i].WorkHours;
                    ResFee.Text = "$1200";
                }
                
            }

            for (var i = 0; i < scholarships.Length; i++)
            {
                
                if (enteredID == scholarships[i].ID)
                {
                    ResFirstname.Text = scholarships[i].FirstName;
                    ResLastname.Text = scholarships[i].LastName;
                    ResType.Text = scholarships[i].Type;
                    ResFloor.Text = scholarships[i].Floor;
                    ResHours.Text = scholarships[i].WorkHours;
                    ResFee.Text = "$100";

                }
               
            }

            for (var i = 0; i < workers.Length; i++)
            {
                
                if (enteredID == workers[i].ID)
                {
                    ResFirstname.Text = workers[i].FirstName;
                    ResLastname.Text = workers[i].LastName;
                    ResType.Text = workers[i].Type;
                    ResFloor.Text = workers[i].Floor;
                    ResHours.Text = workers[i].WorkHours;

                    hours = double.Parse(workers[i].WorkHours);
                    totalHours = hours * 4.00;
                    pay = totalHours * 0.5 * 14.00;
                    totalFee = 1245.00 - pay;
                    totalFee = Math.Round(totalFee, 2);
                    displayFee = totalFee.ToString();

                    ResFee.Text = "$" + displayFee;
                }
                
                
            }
            notFoundLabel.Hide();

            
        }

        private void button1_Click(object sender, EventArgs e) //Return button
        {
            this.Close();
        }
    }
}
