using System;
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
    public partial class LoginForm : Form
    {
        string User;
        string Password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User = UsernameEntry.Text;
            Password = PasswordEntry.Text;
            if (User == "home" && Password == "1234") //Check for correct username and password
            {
                InfoLabel.Text = "Click Log in to continue.";
                SelectionForm select = new SelectionForm();
                UsernameEntry.Text = "";
                PasswordEntry.Text = "";
                select.ShowDialog();
            }
            else
            {
                UsernameEntry.Text = "";
                PasswordEntry.Text = "";
                InfoLabel.Text = "*Incorrect username or password entered!";
            }
            
        }
    }

    public abstract class Student //Parent Class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Floor { get; set; }
        public string ID { get; set; }
        public string WorkHours { get; set; }

    }

    public class Athlete : Student
    {
        public Athlete (string firstName, string lastName, string type, string floor, string id, string workHours)
        {
            FirstName = firstName;
            LastName = lastName;
            Type = type;
            Floor = floor;
            ID = id;
            WorkHours = workHours;
        }
    }

    public class Scholarship : Student
    {
        public Scholarship (string firstName, string lastName, string type, string floor, string id, string workHours)
        {
            FirstName = firstName;
            LastName = lastName;
            Type = type;
            Floor = floor;
            ID = id;
            WorkHours = workHours;
        }
    }

    public class Worker : Student
    {
        public Worker (string firstName, string lastName, string type, string floor, string id, string workHours)
        {
            FirstName = firstName;
            LastName = lastName;
            Type = type;
            Floor = floor;
            ID = id;
            WorkHours = workHours;
        }
    }
}
