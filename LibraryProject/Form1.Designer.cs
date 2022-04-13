
namespace LibraryProject
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonListOfBooks = new System.Windows.Forms.Button();
            this.buttonListOfUsers = new System.Windows.Forms.Button();
            this.buttonFindUser = new System.Windows.Forms.Button();
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelPesel = new System.Windows.Forms.Label();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.buttonAddNewBook = new System.Windows.Forms.Button();
            this.buttonListOfBorrowed = new System.Windows.Forms.Button();
            this.pictureBoxBooks = new System.Windows.Forms.PictureBox();
            this.labelBorrow = new System.Windows.Forms.Label();
            this.buttonBorrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListOfBooks
            // 
            this.buttonListOfBooks.Location = new System.Drawing.Point(638, 392);
            this.buttonListOfBooks.Name = "buttonListOfBooks";
            this.buttonListOfBooks.Size = new System.Drawing.Size(72, 46);
            this.buttonListOfBooks.TabIndex = 0;
            this.buttonListOfBooks.Text = "button1";
            this.buttonListOfBooks.UseVisualStyleBackColor = true;
            this.buttonListOfBooks.Click += new System.EventHandler(this.buttonListOfBooks_Click);
            // 
            // buttonListOfUsers
            // 
            this.buttonListOfUsers.Location = new System.Drawing.Point(560, 392);
            this.buttonListOfUsers.Name = "buttonListOfUsers";
            this.buttonListOfUsers.Size = new System.Drawing.Size(72, 46);
            this.buttonListOfUsers.TabIndex = 1;
            this.buttonListOfUsers.Text = "button1";
            this.buttonListOfUsers.UseVisualStyleBackColor = true;
            this.buttonListOfUsers.Click += new System.EventHandler(this.buttonListOfUsers_Click);
            // 
            // buttonFindUser
            // 
            this.buttonFindUser.Location = new System.Drawing.Point(12, 392);
            this.buttonFindUser.Name = "buttonFindUser";
            this.buttonFindUser.Size = new System.Drawing.Size(72, 46);
            this.buttonFindUser.TabIndex = 2;
            this.buttonFindUser.Text = "button1";
            this.buttonFindUser.UseVisualStyleBackColor = true;
            this.buttonFindUser.Click += new System.EventHandler(this.buttonFindUser_Click);
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Location = new System.Drawing.Point(90, 392);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(72, 46);
            this.buttonRegisterUser.TabIndex = 3;
            this.buttonRegisterUser.Text = "button2";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            this.buttonRegisterUser.Click += new System.EventHandler(this.buttonRegisterUser_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(12, 317);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(150, 20);
            this.textBoxUserName.TabIndex = 4;
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Location = new System.Drawing.Point(9, 301);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(35, 13);
            this.labelNameUser.TabIndex = 5;
            this.labelNameUser.Text = "label1";
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(9, 340);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(35, 13);
            this.labelPesel.TabIndex = 6;
            this.labelPesel.Text = "label1";
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(12, 356);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(150, 20);
            this.textBoxPesel.TabIndex = 7;
            // 
            // buttonAddNewBook
            // 
            this.buttonAddNewBook.Location = new System.Drawing.Point(716, 392);
            this.buttonAddNewBook.Name = "buttonAddNewBook";
            this.buttonAddNewBook.Size = new System.Drawing.Size(72, 46);
            this.buttonAddNewBook.TabIndex = 9;
            this.buttonAddNewBook.Text = "button1";
            this.buttonAddNewBook.UseVisualStyleBackColor = true;
            this.buttonAddNewBook.Click += new System.EventHandler(this.buttonAddNewBook_Click);
            // 
            // buttonListOfBorrowed
            // 
            this.buttonListOfBorrowed.Location = new System.Drawing.Point(12, 12);
            this.buttonListOfBorrowed.Name = "buttonListOfBorrowed";
            this.buttonListOfBorrowed.Size = new System.Drawing.Size(142, 55);
            this.buttonListOfBorrowed.TabIndex = 10;
            this.buttonListOfBorrowed.Text = "button1";
            this.buttonListOfBorrowed.UseVisualStyleBackColor = true;
            this.buttonListOfBorrowed.Click += new System.EventHandler(this.buttonListOfBorrowed_Click);
            // 
            // pictureBoxBooks
            // 
            this.pictureBoxBooks.Image = global::LibraryProject.Properties.Resources.GettyImages_900301626_437925_t2i3bm;
            this.pictureBoxBooks.Location = new System.Drawing.Point(160, 12);
            this.pictureBoxBooks.Name = "pictureBoxBooks";
            this.pictureBoxBooks.Size = new System.Drawing.Size(628, 55);
            this.pictureBoxBooks.TabIndex = 8;
            this.pictureBoxBooks.TabStop = false;
            // 
            // labelBorrow
            // 
            this.labelBorrow.AutoSize = true;
            this.labelBorrow.Location = new System.Drawing.Point(12, 70);
            this.labelBorrow.Name = "labelBorrow";
            this.labelBorrow.Size = new System.Drawing.Size(35, 13);
            this.labelBorrow.TabIndex = 11;
            this.labelBorrow.Text = "label1";
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(12, 86);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(142, 55);
            this.buttonBorrow.TabIndex = 12;
            this.buttonBorrow.Text = "button1";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.labelBorrow);
            this.Controls.Add(this.buttonListOfBorrowed);
            this.Controls.Add(this.buttonAddNewBook);
            this.Controls.Add(this.pictureBoxBooks);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.labelPesel);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonRegisterUser);
            this.Controls.Add(this.buttonFindUser);
            this.Controls.Add(this.buttonListOfUsers);
            this.Controls.Add(this.buttonListOfBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListOfBooks;
        private System.Windows.Forms.Button buttonListOfUsers;
        private System.Windows.Forms.Button buttonFindUser;
        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.PictureBox pictureBoxBooks;
        private System.Windows.Forms.Button buttonAddNewBook;
        private System.Windows.Forms.Button buttonListOfBorrowed;
        private System.Windows.Forms.Label labelBorrow;
        private System.Windows.Forms.Button buttonBorrow;
    }
}

