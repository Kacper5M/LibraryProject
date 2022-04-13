
namespace LibraryProject
{
    partial class createUser
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
            this.labelEnterInfo = new System.Windows.Forms.Label();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.labelEnterSurname = new System.Windows.Forms.Label();
            this.labelEnterPhone = new System.Windows.Forms.Label();
            this.labelEnterPesel = new System.Windows.Forms.Label();
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.textBoxEnterSurname = new System.Windows.Forms.TextBox();
            this.textBoxEnterPhone = new System.Windows.Forms.TextBox();
            this.textBoxEnterPesel = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
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
            this.labelCreatePanel.Size = new System.Drawing.Size(314, 20);
            this.labelCreatePanel.TabIndex = 0;
            this.labelCreatePanel.Text = "CREATE NEW USER PANEL";
            this.labelCreatePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnterInfo
            // 
            this.labelEnterInfo.AutoSize = true;
            this.labelEnterInfo.Location = new System.Drawing.Point(16, 54);
            this.labelEnterInfo.Name = "labelEnterInfo";
            this.labelEnterInfo.Size = new System.Drawing.Size(35, 13);
            this.labelEnterInfo.TabIndex = 1;
            this.labelEnterInfo.Text = "label2";
            // 
            // labelEnterName
            // 
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.Location = new System.Drawing.Point(16, 105);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(35, 13);
            this.labelEnterName.TabIndex = 2;
            this.labelEnterName.Text = "label2";
            // 
            // labelEnterSurname
            // 
            this.labelEnterSurname.AutoSize = true;
            this.labelEnterSurname.Location = new System.Drawing.Point(16, 153);
            this.labelEnterSurname.Name = "labelEnterSurname";
            this.labelEnterSurname.Size = new System.Drawing.Size(35, 13);
            this.labelEnterSurname.TabIndex = 3;
            this.labelEnterSurname.Text = "label3";
            // 
            // labelEnterPhone
            // 
            this.labelEnterPhone.AutoSize = true;
            this.labelEnterPhone.Location = new System.Drawing.Point(16, 203);
            this.labelEnterPhone.Name = "labelEnterPhone";
            this.labelEnterPhone.Size = new System.Drawing.Size(35, 13);
            this.labelEnterPhone.TabIndex = 4;
            this.labelEnterPhone.Text = "label4";
            // 
            // labelEnterPesel
            // 
            this.labelEnterPesel.AutoSize = true;
            this.labelEnterPesel.Location = new System.Drawing.Point(16, 253);
            this.labelEnterPesel.Name = "labelEnterPesel";
            this.labelEnterPesel.Size = new System.Drawing.Size(35, 13);
            this.labelEnterPesel.TabIndex = 5;
            this.labelEnterPesel.Text = "label5";
            // 
            // textBoxEnterName
            // 
            this.textBoxEnterName.Location = new System.Drawing.Point(15, 121);
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(147, 20);
            this.textBoxEnterName.TabIndex = 6;
            // 
            // textBoxEnterSurname
            // 
            this.textBoxEnterSurname.Location = new System.Drawing.Point(15, 169);
            this.textBoxEnterSurname.Name = "textBoxEnterSurname";
            this.textBoxEnterSurname.Size = new System.Drawing.Size(147, 20);
            this.textBoxEnterSurname.TabIndex = 7;
            // 
            // textBoxEnterPhone
            // 
            this.textBoxEnterPhone.Location = new System.Drawing.Point(15, 219);
            this.textBoxEnterPhone.Name = "textBoxEnterPhone";
            this.textBoxEnterPhone.Size = new System.Drawing.Size(147, 20);
            this.textBoxEnterPhone.TabIndex = 8;
            // 
            // textBoxEnterPesel
            // 
            this.textBoxEnterPesel.Location = new System.Drawing.Point(15, 269);
            this.textBoxEnterPesel.Name = "textBoxEnterPesel";
            this.textBoxEnterPesel.Size = new System.Drawing.Size(147, 20);
            this.textBoxEnterPesel.TabIndex = 9;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(12, 319);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(288, 43);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "button1";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // createUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 378);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxEnterPesel);
            this.Controls.Add(this.textBoxEnterPhone);
            this.Controls.Add(this.textBoxEnterSurname);
            this.Controls.Add(this.textBoxEnterName);
            this.Controls.Add(this.labelEnterPesel);
            this.Controls.Add(this.labelEnterPhone);
            this.Controls.Add(this.labelEnterSurname);
            this.Controls.Add(this.labelEnterName);
            this.Controls.Add(this.labelEnterInfo);
            this.Controls.Add(this.labelCreatePanel);
            this.Name = "createUser";
            this.Text = "createUser";
            this.Load += new System.EventHandler(this.createUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreatePanel;
        private System.Windows.Forms.Label labelEnterInfo;
        private System.Windows.Forms.Label labelEnterName;
        private System.Windows.Forms.Label labelEnterSurname;
        private System.Windows.Forms.Label labelEnterPhone;
        private System.Windows.Forms.Label labelEnterPesel;
        private System.Windows.Forms.TextBox textBoxEnterName;
        private System.Windows.Forms.TextBox textBoxEnterSurname;
        private System.Windows.Forms.TextBox textBoxEnterPhone;
        private System.Windows.Forms.TextBox textBoxEnterPesel;
        private System.Windows.Forms.Button buttonRegister;
    }
}