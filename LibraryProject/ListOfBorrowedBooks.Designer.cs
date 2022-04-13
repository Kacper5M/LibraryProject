
namespace LibraryProject
{
    partial class ListOfBorrowedBooks
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
            this.dataGridViewBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.buttonReferesh = new System.Windows.Forms.Button();
            this.labelPick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserSurname = new System.Windows.Forms.TextBox();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.buttonDeleteBorrow = new System.Windows.Forms.Button();
            this.textBoxRentalID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrowedBooks
            // 
            this.dataGridViewBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowedBooks.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewBorrowedBooks.Name = "dataGridViewBorrowedBooks";
            this.dataGridViewBorrowedBooks.Size = new System.Drawing.Size(563, 376);
            this.dataGridViewBorrowedBooks.TabIndex = 0;
            this.dataGridViewBorrowedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBorrowedBooks_CellClick);
            // 
            // buttonReferesh
            // 
            this.buttonReferesh.Location = new System.Drawing.Point(12, 12);
            this.buttonReferesh.Name = "buttonReferesh";
            this.buttonReferesh.Size = new System.Drawing.Size(563, 44);
            this.buttonReferesh.TabIndex = 1;
            this.buttonReferesh.Text = "Referesh";
            this.buttonReferesh.UseVisualStyleBackColor = true;
            this.buttonReferesh.Click += new System.EventHandler(this.buttonReferesh_Click);
            // 
            // labelPick
            // 
            this.labelPick.AutoSize = true;
            this.labelPick.Location = new System.Drawing.Point(581, 62);
            this.labelPick.Name = "labelPick";
            this.labelPick.Size = new System.Drawing.Size(143, 13);
            this.labelPick.TabIndex = 2;
            this.labelPick.Text = "Pick user and book to delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Author";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(584, 103);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(140, 20);
            this.textBoxUserName.TabIndex = 7;
            // 
            // textBoxUserSurname
            // 
            this.textBoxUserSurname.Location = new System.Drawing.Point(584, 145);
            this.textBoxUserSurname.Name = "textBoxUserSurname";
            this.textBoxUserSurname.Size = new System.Drawing.Size(140, 20);
            this.textBoxUserSurname.TabIndex = 8;
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(584, 184);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(140, 20);
            this.textBoxBookTitle.TabIndex = 9;
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(584, 232);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(140, 20);
            this.textBoxBookAuthor.TabIndex = 10;
            // 
            // buttonDeleteBorrow
            // 
            this.buttonDeleteBorrow.Location = new System.Drawing.Point(584, 258);
            this.buttonDeleteBorrow.Name = "buttonDeleteBorrow";
            this.buttonDeleteBorrow.Size = new System.Drawing.Size(140, 23);
            this.buttonDeleteBorrow.TabIndex = 11;
            this.buttonDeleteBorrow.Text = "Delete";
            this.buttonDeleteBorrow.UseVisualStyleBackColor = true;
            this.buttonDeleteBorrow.Click += new System.EventHandler(this.buttonDeleteBorrow_Click);
            // 
            // textBoxRentalID
            // 
            this.textBoxRentalID.Location = new System.Drawing.Point(730, 261);
            this.textBoxRentalID.Name = "textBoxRentalID";
            this.textBoxRentalID.Size = new System.Drawing.Size(25, 20);
            this.textBoxRentalID.TabIndex = 12;
            // 
            // ListOfBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRentalID);
            this.Controls.Add(this.buttonDeleteBorrow);
            this.Controls.Add(this.textBoxBookAuthor);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.textBoxUserSurname);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPick);
            this.Controls.Add(this.buttonReferesh);
            this.Controls.Add(this.dataGridViewBorrowedBooks);
            this.Name = "ListOfBorrowedBooks";
            this.Text = "ListOfBorrowedBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrowedBooks;
        private System.Windows.Forms.Button buttonReferesh;
        private System.Windows.Forms.Label labelPick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserSurname;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.Button buttonDeleteBorrow;
        private System.Windows.Forms.TextBox textBoxRentalID;
    }
}