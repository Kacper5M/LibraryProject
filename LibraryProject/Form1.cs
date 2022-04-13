using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.dataBase;
using LibraryProject.GUI;

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region GUI
            
            buttonListOfBooks.Text = buttonsDesc.buttonSearchBooks;
            buttonListOfUsers.Text = buttonsDesc.buttonListOfUsers;
            buttonFindUser.Text = buttonsDesc.buttonFindUser;
            buttonRegisterUser.Text = buttonsDesc.buttonRegisterUser;
            buttonAddNewBook.Text = buttonsDesc.buttonAddBook;
            buttonListOfBorrowed.Text = buttonsDesc.buttonListOfBorrowed;
            buttonBorrow.Text = buttonsDesc.buttonBorrow;
            

            labelNameUser.Text = buttonsDesc.labelUserName;
            labelPesel.Text = buttonsDesc.labelPesel;
            labelBorrow.Text = buttonsDesc.labelBorrow;
            #endregion
        }


        //Check if user exist by name and PESEL
        private void buttonFindUser_Click(object sender, EventArgs e)
        {
            //Checking if all fields are filled
            if (String.IsNullOrEmpty(textBoxUserName.Text) == false && String.IsNullOrEmpty(textBoxPesel.Text) == false)
            {
                using (var dbConnect = new DatabaseConnect())
                //Searching in database
                if (dbConnect.users.Any(o => o.name == textBoxUserName.Text && o.PESEL == Int64.Parse(textBoxPesel.Text)))
                {
                    MessageBox.Show($"Account: {textBoxUserName.Text}, with PESEL:{textBoxPesel.Text} exist!");

                }
                else
                {
                    MessageBox.Show("Can't find this account. Create!");
                }  
            }
            else
            {
                MessageBox.Show("Fill in all fields !");
            }

        }

        //User registration panel
        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            createUser crUser = new createUser();
            crUser.Show();
        }

        //User List
        private void buttonListOfUsers_Click(object sender, EventArgs e)
        {
            usersList uList = new usersList();
            uList.Show();
        }

        private void buttonListOfBooks_Click(object sender, EventArgs e)
        {
            ListOfBooks lBooks = new ListOfBooks();
            lBooks.Show();
        }

        private void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            AddBooksGrid AddGrid = new AddBooksGrid();
            AddGrid.Show();
        }

        private void buttonListOfBorrowed_Click(object sender, EventArgs e)
        {
            ListOfBorrowedBooks listBorrowed = new ListOfBorrowedBooks();
            listBorrowed.Show();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            BorrowABook brBook = new BorrowABook();
            brBook.Show();
        }
    }
}
