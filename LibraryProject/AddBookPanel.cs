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
    public partial class AddBookPanel : Form
    {
        public AddBookPanel()
        {
            InitializeComponent();
        }

        public void CloseNow()
        {
            this.Close();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxAuthor.Text) == false && String.IsNullOrEmpty(textBoxTitle.Text) == false &&
                String.IsNullOrEmpty(textBoxQuantity.Text) == false && String.IsNullOrEmpty(textBoxGenre.Text) == false)
            {
                using (var dbConnect = new DatabaseConnect())
                    //Searching in database
                    if (dbConnect.books.Any(o => o.name == textBoxTitle.Text && o.author == textBoxAuthor.Text))
                    {
                        MessageBox.Show($"Book: {textBoxTitle.Text}, author:{textBoxAuthor.Text} exist! Can't add !");
                    }
                    else
                    {
                        var book = new books()
                        {
                            name = textBoxTitle.Text,
                            author = textBoxAuthor.Text,
                            genre = textBoxGenre.Text,
                            stock = Int32.Parse(textBoxQuantity.Text)
                        };

                        dbConnect.Entry(book).State = EntityState.Added;
                        dbConnect.SaveChanges();
                        MessageBox.Show("Book added !");
                        CloseNow();
                    }
            }
            else
            {
                MessageBox.Show("Fill all fields to search !");
            }
            
        }
    }
}
