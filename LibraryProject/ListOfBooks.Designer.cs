
namespace LibraryProject
{
    partial class ListOfBooks
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
            this.dataGridViewListOfBooks = new System.Windows.Forms.DataGridView();
            this.buttonAvailableBooks = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.buttonReferesh = new System.Windows.Forms.Button();
            this.labelPick = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelGenre = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListOfBooks
            // 
            this.dataGridViewListOfBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOfBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListOfBooks.Name = "dataGridViewListOfBooks";
            this.dataGridViewListOfBooks.Size = new System.Drawing.Size(607, 426);
            this.dataGridViewListOfBooks.TabIndex = 0;
            // 
            // buttonAvailableBooks
            // 
            this.buttonAvailableBooks.Location = new System.Drawing.Point(625, 405);
            this.buttonAvailableBooks.Name = "buttonAvailableBooks";
            this.buttonAvailableBooks.Size = new System.Drawing.Size(163, 33);
            this.buttonAvailableBooks.TabIndex = 1;
            this.buttonAvailableBooks.Text = "SHOW";
            this.buttonAvailableBooks.UseVisualStyleBackColor = true;
            this.buttonAvailableBooks.Click += new System.EventHandler(this.buttonAvailableBooks_Click);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(625, 389);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(158, 13);
            this.labelShow.TabIndex = 2;
            this.labelShow.Text = "and show only available books :";
            // 
            // buttonReferesh
            // 
            this.buttonReferesh.Location = new System.Drawing.Point(453, 12);
            this.buttonReferesh.Name = "buttonReferesh";
            this.buttonReferesh.Size = new System.Drawing.Size(166, 426);
            this.buttonReferesh.TabIndex = 3;
            this.buttonReferesh.Text = "Referesh";
            this.buttonReferesh.UseVisualStyleBackColor = true;
            this.buttonReferesh.Click += new System.EventHandler(this.buttonReferesh_Click);
            // 
            // labelPick
            // 
            this.labelPick.AutoSize = true;
            this.labelPick.Location = new System.Drawing.Point(625, 41);
            this.labelPick.Name = "labelPick";
            this.labelPick.Size = new System.Drawing.Size(68, 13);
            this.labelPick.TabIndex = 4;
            this.labelPick.Text = "Search book";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(622, 68);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Title";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(622, 108);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 9;
            this.labelAuthor.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genre";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(625, 85);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(139, 20);
            this.textBoxTitle.TabIndex = 11;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(625, 125);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(139, 20);
            this.textBoxAuthor.TabIndex = 12;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(625, 164);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(139, 20);
            this.textBoxGenre.TabIndex = 13;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(625, 190);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 23);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(624, 349);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(81, 13);
            this.labelGenre.TabIndex = 15;
            this.labelGenre.Text = "Show by genre:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(625, 365);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(136, 21);
            this.comboBoxGenre.TabIndex = 16;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // ListOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelPick);
            this.Controls.Add(this.buttonReferesh);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.buttonAvailableBooks);
            this.Controls.Add(this.dataGridViewListOfBooks);
            this.Name = "ListOfBooks";
            this.Text = "ListOfBooks";
            this.Load += new System.EventHandler(this.ListOfBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOfBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListOfBooks;
        private System.Windows.Forms.Button buttonAvailableBooks;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button buttonReferesh;
        private System.Windows.Forms.Label labelPick;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.ComboBox comboBoxGenre;
    }
}