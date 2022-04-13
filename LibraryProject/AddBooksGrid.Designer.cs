
namespace LibraryProject
{
    partial class AddBooksGrid
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListOfBooks = new System.Windows.Forms.DataGridView();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReferesh = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new book:";
            // 
            // dataGridViewListOfBooks
            // 
            this.dataGridViewListOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListOfBooks.Name = "dataGridViewListOfBooks";
            this.dataGridViewListOfBooks.Size = new System.Drawing.Size(600, 426);
            this.dataGridViewListOfBooks.TabIndex = 2;
            this.dataGridViewListOfBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListOfBooks_CellClick);
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.Location = new System.Drawing.Point(616, 238);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(96, 41);
            this.buttonUpdateStock.TabIndex = 3;
            this.buttonUpdateStock.Text = "Update";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(616, 212);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(96, 20);
            this.textBoxStock.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(618, 307);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 41);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delete selected book";
            // 
            // labelUpdate
            // 
            this.labelUpdate.Location = new System.Drawing.Point(613, 174);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(94, 35);
            this.labelUpdate.TabIndex = 7;
            this.labelUpdate.Text = "Update stock of selected book";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(618, 54);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(618, 96);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 9;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(616, 80);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 10;
            this.labelAuthor.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title";
            // 
            // buttonReferesh
            // 
            this.buttonReferesh.Location = new System.Drawing.Point(521, 12);
            this.buttonReferesh.Name = "buttonReferesh";
            this.buttonReferesh.Size = new System.Drawing.Size(91, 426);
            this.buttonReferesh.TabIndex = 12;
            this.buttonReferesh.Text = "Referesh";
            this.buttonReferesh.UseVisualStyleBackColor = true;
            this.buttonReferesh.Click += new System.EventHandler(this.buttonReferesh_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(618, 15);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 13;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(618, 138);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Genre";
            // 
            // AddBooksGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonReferesh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.buttonUpdateStock);
            this.Controls.Add(this.dataGridViewListOfBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddBooksGrid";
            this.Text = "AddBooksGrid";
            this.Load += new System.EventHandler(this.AddBooksGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListOfBooks;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReferesh;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label4;
    }
}