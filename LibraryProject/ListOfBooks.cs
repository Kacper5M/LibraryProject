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
    public partial class ListOfBooks : Form
    {
        public ListOfBooks()
        {
            InitializeComponent();
        }
        DatabaseConnect dbconnect = new DatabaseConnect();
        void RefershGrid()
        {
            dataGridViewListOfBooks.Rows.Clear();
            dataGridViewListOfBooks.Columns.Clear();
            dataGridViewListOfBooks.Columns.Add("title", "title");
            dataGridViewListOfBooks.Columns.Add("author", "author");
            dataGridViewListOfBooks.Columns.Add("genre", "genre");
            dataGridViewListOfBooks.Columns.Add("stock", "stock");


        }
        void ComboBoxDeleteDuplicate()
        {
            List<object> list = new List<object>();
            foreach (object o in comboBoxGenre.Items)
            {
                if (!list.Contains(o))
                {
                    list.Add(o);
                }
            }
            comboBoxGenre.Items.Clear();
            comboBoxGenre.Items.AddRange(list.ToArray());
        }
        void LoadAllData()
        {
            RefershGrid();
            var BookData = from DatabaseConnect in dbconnect.books select DatabaseConnect;
            foreach (var row in BookData)
            {
                dataGridViewListOfBooks.Rows.Add(row.name, row.author, row.genre, row.stock);
                comboBoxGenre.Items.Add(row.genre);
                ComboBoxDeleteDuplicate();
            }
        }
        private void ListOfBooks_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }
        private void buttonReferesh_Click(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void buttonAvailableBooks_Click(object sender, EventArgs e)
        {
            if (comboBoxGenre.SelectedIndex >= 0)
            {
                RefershGrid();
                var BookData = from DatabaseConnect in dbconnect.books select DatabaseConnect;
                foreach (var row in BookData)
                {
                    if (row.genre == comboBoxGenre.SelectedItem.ToString() && row.stock > 0 )
                    {
                        dataGridViewListOfBooks.Rows.Add(row.name, row.author, row.genre, row.stock);
                    }
                }
            }
            else
            {
                RefershGrid();
                var BookData = from DatabaseConnect in dbconnect.books select DatabaseConnect;
                foreach (var row in BookData)
                {
                    if (row.stock > 0)
                    {
                        dataGridViewListOfBooks.Rows.Add(row.name, row.author, row.genre, row.stock);
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewListOfBooks.ClearSelection();
            string searchTitle = textBoxTitle.Text;
            string searchAuthor = textBoxAuthor.Text;
            string searchGenre = textBoxGenre.Text;
            dataGridViewListOfBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewListOfBooks.Rows)
                {
                    if (((row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(searchTitle))) ||
                        ((row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(searchAuthor))) ||
                        (row.Cells[2].Value != null && row.Cells[2].Value.ToString().Equals(searchGenre)))
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

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefershGrid();
            var BookData = from DatabaseConnect in dbconnect.books select DatabaseConnect;
            foreach (var row in BookData)
            {
                if (row.genre == comboBoxGenre.SelectedItem.ToString())
                {
                    dataGridViewListOfBooks.Rows.Add(row.name, row.author, row.genre, row.stock);
                }
            }
        }
    }
}
