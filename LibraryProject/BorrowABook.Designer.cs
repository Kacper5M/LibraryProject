
namespace LibraryProject
{
    partial class BorrowABook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.buttonBorrowBook = new System.Windows.Forms.Button();
            this.labelUSers = new System.Windows.Forms.Label();
            this.labelBooks = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserSurname = new System.Windows.Forms.TextBox();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.labelSelName = new System.Windows.Forms.Label();
            this.labelSelSurname = new System.Windows.Forms.Label();
            this.labelSelTitle = new System.Windows.Forms.Label();
            this.labelSelAuthor = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelBookID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.buttonReferesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(355, 345);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(373, 133);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(369, 345);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // buttonBorrowBook
            // 
            this.buttonBorrowBook.Location = new System.Drawing.Point(748, 400);
            this.buttonBorrowBook.Name = "buttonBorrowBook";
            this.buttonBorrowBook.Size = new System.Drawing.Size(166, 78);
            this.buttonBorrowBook.TabIndex = 2;
            this.buttonBorrowBook.Text = "Borrow";
            this.buttonBorrowBook.UseVisualStyleBackColor = true;
            this.buttonBorrowBook.Click += new System.EventHandler(this.buttonBorrowBook_Click);
            // 
            // labelUSers
            // 
            this.labelUSers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelUSers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUSers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUSers.Location = new System.Drawing.Point(12, 94);
            this.labelUSers.Name = "labelUSers";
            this.labelUSers.Size = new System.Drawing.Size(355, 36);
            this.labelUSers.TabIndex = 3;
            this.labelUSers.Text = "USERS";
            this.labelUSers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBooks
            // 
            this.labelBooks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBooks.Location = new System.Drawing.Point(373, 94);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(369, 36);
            this.labelBooks.TabIndex = 5;
            this.labelBooks.Text = "BOOKS";
            this.labelBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(158, 20);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(209, 20);
            this.textBoxUserName.TabIndex = 6;
            // 
            // textBoxUserSurname
            // 
            this.textBoxUserSurname.Location = new System.Drawing.Point(158, 46);
            this.textBoxUserSurname.Name = "textBoxUserSurname";
            this.textBoxUserSurname.Size = new System.Drawing.Size(209, 20);
            this.textBoxUserSurname.TabIndex = 7;
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.Location = new System.Drawing.Point(12, 68);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(355, 23);
            this.buttonSearchUser.TabIndex = 8;
            this.buttonSearchUser.Text = "Search";
            this.buttonSearchUser.UseVisualStyleBackColor = true;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Location = new System.Drawing.Point(373, 68);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(369, 23);
            this.buttonSearchBook.TabIndex = 11;
            this.buttonSearchBook.Text = "Search";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(500, 46);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(242, 20);
            this.textBoxBookAuthor.TabIndex = 10;
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(500, 20);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(242, 20);
            this.textBoxBookTitle.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Author";
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(742, 179);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(150, 13);
            this.labelSelected.TabIndex = 16;
            this.labelSelected.Text = "Selected data to borrow book:";
            // 
            // labelSelName
            // 
            this.labelSelName.AutoSize = true;
            this.labelSelName.Location = new System.Drawing.Point(742, 230);
            this.labelSelName.Name = "labelSelName";
            this.labelSelName.Size = new System.Drawing.Size(0, 13);
            this.labelSelName.TabIndex = 17;
            // 
            // labelSelSurname
            // 
            this.labelSelSurname.AutoSize = true;
            this.labelSelSurname.Location = new System.Drawing.Point(742, 256);
            this.labelSelSurname.Name = "labelSelSurname";
            this.labelSelSurname.Size = new System.Drawing.Size(0, 13);
            this.labelSelSurname.TabIndex = 18;
            // 
            // labelSelTitle
            // 
            this.labelSelTitle.AutoSize = true;
            this.labelSelTitle.Location = new System.Drawing.Point(742, 286);
            this.labelSelTitle.Name = "labelSelTitle";
            this.labelSelTitle.Size = new System.Drawing.Size(0, 13);
            this.labelSelTitle.TabIndex = 19;
            // 
            // labelSelAuthor
            // 
            this.labelSelAuthor.AutoSize = true;
            this.labelSelAuthor.Location = new System.Drawing.Point(742, 319);
            this.labelSelAuthor.Name = "labelSelAuthor";
            this.labelSelAuthor.Size = new System.Drawing.Size(0, 13);
            this.labelSelAuthor.TabIndex = 20;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(344, 480);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(0, 13);
            this.labelUserID.TabIndex = 21;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(707, 480);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(0, 13);
            this.labelBookID.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(683, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stock:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(793, 381);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(0, 13);
            this.labelStock.TabIndex = 26;
            // 
            // buttonReferesh
            // 
            this.buttonReferesh.Location = new System.Drawing.Point(751, 94);
            this.buttonReferesh.Name = "buttonReferesh";
            this.buttonReferesh.Size = new System.Drawing.Size(177, 36);
            this.buttonReferesh.TabIndex = 27;
            this.buttonReferesh.Text = "Referesh";
            this.buttonReferesh.UseVisualStyleBackColor = true;
            this.buttonReferesh.Click += new System.EventHandler(this.buttonReferesh_Click);
            // 
            // BorrowABook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 502);
            this.Controls.Add(this.buttonReferesh);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelSelAuthor);
            this.Controls.Add(this.labelSelTitle);
            this.Controls.Add(this.labelSelSurname);
            this.Controls.Add(this.labelSelName);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.textBoxBookAuthor);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.buttonSearchUser);
            this.Controls.Add(this.textBoxUserSurname);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.labelUSers);
            this.Controls.Add(this.buttonBorrowBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "BorrowABook";
            this.Text = "BorrowABook";
            this.Load += new System.EventHandler(this.BorrowABook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonBorrowBook;
        private System.Windows.Forms.Label labelUSers;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserSurname;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.Label labelSelName;
        private System.Windows.Forms.Label labelSelSurname;
        private System.Windows.Forms.Label labelSelTitle;
        private System.Windows.Forms.Label labelSelAuthor;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Button buttonReferesh;
    }
}