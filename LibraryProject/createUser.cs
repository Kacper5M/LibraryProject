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
using LibraryProject.dataModel;
using LibraryProject.GUI;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject
{
    public partial class createUser : Form
    {
        public createUser()
        {
            InitializeComponent();
        }

        private void createUser_Load(object sender, EventArgs e)
        {
            #region GUI
            buttonRegister.Text = buttonsDesc.buttonRegister;
            labelCreatePanel.Text = buttonsDesc.LabelCreatePanel;
            labelEnterInfo.Text = buttonsDesc.LabelEnterInfo;
            labelEnterName.Text = buttonsDesc.LabelEnterName;
            labelEnterSurname.Text = buttonsDesc.LabelEnterSurname;
            labelEnterPesel.Text = buttonsDesc.LabelEnterPesel;
            labelEnterPhone.Text = buttonsDesc.LabelEnterPhoneNumber;
            #endregion
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEnterName.Text) == false && String.IsNullOrEmpty(textBoxEnterSurname.Text) == false &&
                String.IsNullOrEmpty(textBoxEnterPhone.Text) == false && String.IsNullOrEmpty(textBoxEnterPesel.Text) == false)
            {
                using (var dbConnect = new DatabaseConnect())
                {
                    var user = new users()
                    {
                        name = textBoxEnterName.Text,
                        surname = textBoxEnterSurname.Text,
                        phoneNumber = Int32.Parse(textBoxEnterPhone.Text),
                        PESEL = Int32.Parse(textBoxEnterPesel.Text)
                    };

                    dbConnect.Entry(user).State = EntityState.Added;
                    dbConnect.SaveChanges();
                    MessageBox.Show("Added !");
                }
            }
            else
            {
                MessageBox.Show("Fill all fields to complete the registration !");
            }
        }
    }
}
