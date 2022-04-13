using LibraryProject.dataBase;
using LibraryProject.dataModel;
using Microsoft.EntityFrameworkCore;
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
    public partial class ListOfBorrowedBooks : Form
    {
        public ListOfBorrowedBooks()
        {
            InitializeComponent();
        }

        void RefershGrid()
        {
            dataGridViewBorrowedBooks.Rows.Clear();
            dataGridViewBorrowedBooks.Columns.Clear();
            dataGridViewBorrowedBooks.Columns.Add("name", "Name");
            dataGridViewBorrowedBooks.Columns.Add("surname", "Surname");
            dataGridViewBorrowedBooks.Columns.Add("name", "Title");
            dataGridViewBorrowedBooks.Columns.Add("author", "Author");
            dataGridViewBorrowedBooks.Columns.Add("rentalid", "RentalID");
            dataGridViewBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void buttonReferesh_Click(object sender, EventArgs e)
        {
            RefershGrid();
            DatabaseConnect dbconnect = new DatabaseConnect();
            var BookData = from DatabaseConnect in dbconnect.books select DatabaseConnect;
            var UsersData = from DatabaseConnect in dbconnect.users select DatabaseConnect;
            var RentalData = from DatabaseConnect in dbconnect.rentals select DatabaseConnect;
            foreach(var rowRental in RentalData)
            {
                foreach(var rowBooks in BookData.Where(a => a.BookId == rowRental.BookId))
                {
                    foreach(var rowUsers in UsersData.Where(c => c.UserId == rowRental.UserId))
                    {
                        dataGridViewBorrowedBooks.Rows.Add(rowUsers.name, rowUsers.surname, rowBooks.name, rowBooks.author,rowRental.RentalId);
                    }
                }
            }
        }

        private void buttonDeleteBorrow_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRentalID.Text) == false)
            {
                using (var updateDate = new DatabaseConnect())
                {
                    int RID = Int32.Parse(textBoxRentalID.Text.ToString());
                    rentals _rental = new rentals() { RentalId = RID };
                    updateDate.Entry(_rental).State = EntityState.Deleted;
                    updateDate.SaveChanges();
                    MessageBox.Show("DELETED!");
                }
            }
            else
            {
                MessageBox.Show("Select book!");
            }

        }

        private void dataGridViewBorrowedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dataGridViewBorrowedBooks.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < count - 1)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridViewBorrowedBooks.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxUserName.Text = row.Cells[0].Value.ToString();
                textBoxUserSurname.Text = row.Cells[1].Value.ToString();
                textBoxBookTitle.Text = row.Cells[2].Value.ToString();
                textBoxBookAuthor.Text = row.Cells[3].Value.ToString();
                textBoxRentalID.Text = row.Cells[4].Value.ToString();
            }
            else
            {

            }
        }

    }
}
