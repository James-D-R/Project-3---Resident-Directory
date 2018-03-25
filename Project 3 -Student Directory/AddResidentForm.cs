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

            FileStream add = new FileStream("Students.csv", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(add);

            string firstname = firstnameBox.Text;
            string lastname = lastnameBox.Text;
            string studentType = studentTypeBox.Text;
            string floorNumber = floorBox.Text;
            string studnetID = idBox.Text;
            string hoursWorked = hoursBox.Text;

            if (firstname == "" || lastname == "")
            {

            }

        }
    }
}
