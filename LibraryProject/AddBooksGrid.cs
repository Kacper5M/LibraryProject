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
    public partial class AddBooksGrid : Form
    {
        public AddBooksGrid()
        {
            InitializeComponent();
        }
        void RefershGrid()
        {
            dataGridViewListOfBooks.Rows.Clear();
            dataGridViewListOfBooks.Columns.Clear();
            dataGridViewListOfBooks.Columns.Add("id", "id");
            dataGridViewListOfBooks.Columns.Add("title", "title");
            dataGridViewListOfBooks.Columns.Add("author", "author");
            dataGridViewListOfBooks.Columns.Add("genre", "genre");
            dataGridViewListOfBooks.Columns.Add("stock", "stock");
            dataGridViewListOfBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        DatabaseConnect dbconnect = new DatabaseConnect();
        void LoadAllData()
        {
            DatabaseConnect dbconnect = new DatabaseConnect();
            RefershGrid();
            var BookData = from DatabaseConnect in dbconnect.books select DatabaseConnect;
            foreach (var row in BookData)
            {
                dataGridViewListOfBooks.Rows.Add(row.BookId,row.name, row.author, row.genre, row.stock);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddBookPanel addBook = new AddBookPanel();
            addBook.Show();
        }

        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTitle.Text) == false && String.IsNullOrEmpty(textBoxAuthor.Text) == false &&
                String.IsNullOrEmpty(textBoxStock.Text) == false && String.IsNullOrEmpty(textBoxID.Text) == false)
            {
                using (var updateDate = new DatabaseConnect())
                {
                    string Uname = textBoxTitle.Text.ToString();
                    string Uauthor = textBoxAuthor.Text.ToString();
                    string UGenre = textBoxGenre.Text.ToString();
                    int Uid = Int32.Parse(textBoxID.Text.ToString());
                    int Stocks = Int32.Parse(textBoxStock.Text.ToString());
                    books _books = new books() {BookId = Uid ,author = Uauthor, name = Uname, stock = Stocks, genre = UGenre};
                    updateDate.Entry(_books).State = EntityState.Modified;
                    updateDate.SaveChanges();
                    MessageBox.Show("UPDATED!");
                }
            }
            else
            {
                MessageBox.Show("Select book!");
            }
        }

        private void AddBooksGrid_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void dataGridViewListOfBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = dataGridViewListOfBooks.Rows.Count;
            if (e.RowIndex >= 0 && e.RowIndex < count-1)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridViewListOfBooks.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxTitle.Text = row.Cells[1].Value.ToString();
                textBoxAuthor.Text = row.Cells[2].Value.ToString();
                textBoxGenre.Text = row.Cells[3].Value.ToString();
            }
            else
            {
                
            }
        }

        private void buttonReferesh_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }


        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxID.Text) == false)
            {
                using (var updateDate = new DatabaseConnect())
                {
                    int Uid = Int32.Parse(textBoxID.Text.ToString());
                    books _books = new books() { BookId = Uid };
                    updateDate.Entry(_books).State = EntityState.Deleted;
                    updateDate.SaveChanges();
                    MessageBox.Show("DELETED!");
                }
            }
            else
            {
                MessageBox.Show("Select book!");
            }
        }
    }
}
