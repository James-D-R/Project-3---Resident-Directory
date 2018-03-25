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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddResidentForm add = new AddResidentForm();
            add.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
