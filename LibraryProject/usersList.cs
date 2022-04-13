using LibraryProject.dataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class usersList : Form
    {
        public usersList()
        {
            InitializeComponent();
        }

        void clearGrid()
        {
            dataGridViewListOfUsers.Rows.Clear();
            dataGridViewListOfUsers.Columns.Clear();
            dataGridViewListOfUsers.Columns.Add("name","name");
            dataGridViewListOfUsers.Columns.Add("surname", "surname");
            dataGridViewListOfUsers.Columns.Add("phone", "phone");
            dataGridViewListOfUsers.Columns.Add("pesel", "pesel");
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            clearGrid();
            DatabaseConnect dbconnect = new DatabaseConnect();
            var UserData = from DatabaseConnect in dbconnect.users select DatabaseConnect;
            foreach(var row in UserData)
            {
                dataGridViewListOfUsers.Rows.Add(row.name, row.surname, row.phoneNumber, row.PESEL);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewListOfUsers.ClearSelection();
            string searchName = textBoxSearchName.Text;
            string serachSurname = textBoxSearchSurname.Text;
            dataGridViewListOfUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewListOfUsers.Rows)
                { 
                    if ((row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(searchName)) && 
                        (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(serachSurname)))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}
