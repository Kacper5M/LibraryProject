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
    public partial class BorrowABook : Form
    {
        public BorrowABook()
        {
            InitializeComponent();
        }
        void RefershGridUsers()
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.Columns.Clear();
            dataGridViewUsers.Columns.Add("name", "Name");
            dataGridViewUsers.Columns.Add("surname", "Surname");
            dataGridViewUsers.Columns.Add("IDUser", "IDUser");
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        void RefershGridBooks()
        {
            dataGridViewBooks.Rows.Clear();
            dataGridViewBooks.Columns.Clear();
            dataGridViewBooks.Columns.Add("title", "Title");
            dataGridViewBooks.Columns.Add("author", "Author");
            dataGridViewBooks.Columns.Add("stock", "Stock");
            dataGridViewBooks.Columns.Add("IDBook", "IDBook");
            dataGridViewBooks.Columns.Add("genre", "Genre");
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BorrowABook_Load(object sender, EventArgs e)
        {
            RefershGridUsers();
            RefershGridBooks();
            DatabaseConnect dbconnect = new DatabaseConnect();
            var BookData = from DatabaseConnect in dbconnect.books select DatabaseConnect;
            var UserData  = from DatabaseConnect in dbconnect.users select DatabaseConnect;
            foreach (var rowBook in BookData)
            {
                if (rowBook.stock > 0)
                {
                    dataGridViewBooks.Rows.Add(rowBook.name, rowBook.author,rowBook.stock,rowBook.BookId,rowBook.genre);
                }
            }
            foreach (var rowUser in UserData)
            {
                dataGridViewUsers.Rows.Add(rowUser.name, rowUser.surname, rowUser.UserId);
            }
        }


        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.ClearSelection();
            string searchName = textBoxUserName.Text;
            string searchSurname = textBoxUserSurname.Text;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewUsers.Rows)
                {
                    if (((row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(searchName))) ||
                        ((row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(searchSurname))))
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

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.ClearSelection();
            string searchBookTitle = textBoxBookTitle.Text;
            string searchBookAuthor = textBoxBookAuthor.Text;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewBooks.Rows)
                {
                    if (((row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(searchBookTitle))) ||
                        ((row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(searchBookAuthor))))
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

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dataGridViewUsers.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < count - 1)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridViewUsers.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                labelSelName.Text = row.Cells[0].Value.ToString();
                labelSelSurname.Text = row.Cells[1].Value.ToString();
                labelUserID.Text = row.Cells[2].Value.ToString();
            }
            else
            {

            }
        }
        string genrecell;
        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dataGridViewBooks.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < count - 1)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridViewBooks.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                labelSelTitle.Text = row.Cells[0].Value.ToString();
                labelSelAuthor.Text = row.Cells[1].Value.ToString();
                labelStock.Text = row.Cells[2].Value.ToString();
                labelBookID.Text = row.Cells[3].Value.ToString();
                genrecell = row.Cells[4].Value.ToString();
            }
            else
            {

            }
        }

        private void buttonBorrowBook_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(labelSelName.Text) == false && String.IsNullOrEmpty(labelSelSurname.Text) == false &&
                String.IsNullOrEmpty(labelSelTitle.Text) == false && String.IsNullOrEmpty(labelSelAuthor.Text) == false)
            {
                using (var dbConnect = new DatabaseConnect())
                {
                    var rental = new rentals()
                    {
                        BookId = Int32.Parse(labelBookID.Text.ToString()),
                        UserId = Int32.Parse(labelUserID.Text.ToString())
                    };

                    dbConnect.Entry(rental).State = EntityState.Added;
                    dbConnect.SaveChanges();
                }
                
                using (var updateStock = new DatabaseConnect())
                {
                    int Bid = Int32.Parse(labelBookID.Text.ToString());
                    int stockb = Int32.Parse(labelStock.Text.ToString());
                    string authorc = labelSelAuthor.Text.ToString();
                    string namec = labelSelTitle.Text.ToString();
                    books _books = new books() { BookId = Bid, stock = stockb-1, name= namec, author= authorc, genre= genrecell };
                    updateStock.Entry(_books).State = EntityState.Modified;
                    updateStock.SaveChanges();
                    MessageBox.Show("Borrowed!");
                }

            }
            else
            {
                MessageBox.Show("Chose user and book!");
            }
        }

        private void buttonReferesh_Click(object sender, EventArgs e)
        {
            RefershGridUsers();
            RefershGridBooks();
            DatabaseConnect dbconnect = new DatabaseConnect();
            var BookData = from DatabaseConnect in dbconnect.books select DatabaseConnect;
            var UserData = from DatabaseConnect in dbconnect.users select DatabaseConnect;
            foreach (var rowBook in BookData)
            {
                if (rowBook.stock > 0)
                {
                    dataGridViewBooks.Rows.Add(rowBook.name, rowBook.author, rowBook.stock, rowBook.BookId, rowBook.genre);
                }
            }
            foreach (var rowUser in UserData)
            {
                dataGridViewUsers.Rows.Add(rowUser.name, rowUser.surname, rowUser.UserId);
            }
        }
    }
}
