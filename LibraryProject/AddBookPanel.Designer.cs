
namespace LibraryProject
{
    partial class AddBookPanel
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
            this.labelCreatePanel = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCreatePanel
            // 
            this.labelCreatePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelCreatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCreatePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCreatePanel.Font = new System.Drawing.Font("Miriam CLM", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCreatePanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCreatePanel.Location = new System.Drawing.Point(0, 0);
            this.labelCreatePanel.Name = "labelCreatePanel";
            this.labelCreatePanel.Size = new System.Drawing.Size(304, 20);
            this.labelCreatePanel.TabIndex = 1;
            this.labelCreatePanel.Text = "ADD NEW BOOK PANEL";
            this.labelCreatePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(12, 224);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(271, 53);
            this.buttonAddBook.TabIndex = 2;
            this.buttonAddBook.Text = "Add book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(9, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Title:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(9, 89);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Author:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(9, 128);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Genre";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(9, 167);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 66);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(271, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(12, 105);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(271, 20);
            this.textBoxAuthor.TabIndex = 8;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(12, 144);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(271, 20);
            this.textBoxGenre.TabIndex = 9;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(12, 183);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(271, 20);
            this.textBoxQuantity.TabIndex = 10;
            // 
            // AddBookPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 300);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.labelCreatePanel);
            this.Name = "AddBookPanel";
            this.Text = "AddBookPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreatePanel;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxQuantity;
    }
}