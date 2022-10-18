namespace HotelManagement.Forms
{
    partial class customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customers));
            this.Add = new HotelManagement.Tools.RoundedButton();
            this.LpPanel = new System.Windows.Forms.Panel();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCin = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.Edit = new HotelManagement.Tools.RoundedButton();
            this.Delete = new HotelManagement.Tools.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CodePostal = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.NumTel = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.CIN = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.LpPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Add.BorderRadius = 20;
            this.Add.BorderSize = 0;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(905, 50);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 198);
            this.Add.TabIndex = 21;
            this.Add.TextColor = System.Drawing.Color.White;
            this.Add.UseVisualStyleBackColor = false;
            // 
            // LpPanel
            // 
            this.LpPanel.BackColor = System.Drawing.Color.White;
            this.LpPanel.Controls.Add(this.lblEmail);
            this.LpPanel.Controls.Add(this.lblCodePostal);
            this.LpPanel.Controls.Add(this.lblCountry);
            this.LpPanel.Controls.Add(this.lblCity);
            this.LpPanel.Controls.Add(this.lblNumTel);
            this.LpPanel.Controls.Add(this.lblAdresse);
            this.LpPanel.Controls.Add(this.lblCin);
            this.LpPanel.Controls.Add(this.lblNom);
            this.LpPanel.Controls.Add(this.lblPrenom);
            this.LpPanel.Controls.Add(this.Edit);
            this.LpPanel.Controls.Add(this.Delete);
            this.LpPanel.Location = new System.Drawing.Point(35, 136);
            this.LpPanel.Name = "LpPanel";
            this.LpPanel.Size = new System.Drawing.Size(852, 56);
            this.LpPanel.TabIndex = 20;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodePostal.Location = new System.Drawing.Point(546, 18);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(30, 12);
            this.lblCodePostal.TabIndex = 18;
            this.lblCodePostal.Text = "label3";
            this.lblCodePostal.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.Location = new System.Drawing.Point(475, 21);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(30, 12);
            this.lblCountry.TabIndex = 17;
            this.lblCountry.Text = "label3";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(416, 21);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 12);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "label3";
            this.lblCity.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumTel.Location = new System.Drawing.Point(330, 21);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(30, 12);
            this.lblNumTel.TabIndex = 14;
            this.lblNumTel.Text = "label3";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdresse.Location = new System.Drawing.Point(237, 21);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(30, 12);
            this.lblAdresse.TabIndex = 13;
            this.lblAdresse.Text = "label3";
            // 
            // lblCin
            // 
            this.lblCin.AutoSize = true;
            this.lblCin.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCin.Location = new System.Drawing.Point(184, 21);
            this.lblCin.Name = "lblCin";
            this.lblCin.Size = new System.Drawing.Size(30, 12);
            this.lblCin.TabIndex = 12;
            this.lblCin.Text = "label3";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNom.Location = new System.Drawing.Point(98, 21);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(30, 12);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "label2";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrenom.Location = new System.Drawing.Point(10, 21);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(30, 12);
            this.lblPrenom.TabIndex = 6;
            this.lblPrenom.Text = "label1";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.Edit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.Edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Edit.BorderRadius = 20;
            this.Edit.BorderSize = 0;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Image = global::HotelManagement.Properties.Resources.edit;
            this.Edit.Location = new System.Drawing.Point(727, 3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(58, 48);
            this.Edit.TabIndex = 5;
            this.Edit.TextColor = System.Drawing.Color.White;
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.Delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Delete.BorderRadius = 20;
            this.Delete.BorderSize = 0;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Image = global::HotelManagement.Properties.Resources.delete__1_;
            this.Delete.Location = new System.Drawing.Point(791, 3);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(58, 48);
            this.Delete.TabIndex = 4;
            this.Delete.TextColor = System.Drawing.Color.White;
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.CodePostal);
            this.panel1.Controls.Add(this.Country);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.NumTel);
            this.panel1.Controls.Add(this.Adresse);
            this.panel1.Controls.Add(this.CIN);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Location = new System.Drawing.Point(35, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 71);
            this.panel1.TabIndex = 19;
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CodePostal.ForeColor = System.Drawing.Color.Black;
            this.CodePostal.Location = new System.Drawing.Point(546, 29);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(84, 20);
            this.CodePostal.TabIndex = 18;
            this.CodePostal.Text = "CodePostal";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Country.ForeColor = System.Drawing.Color.Black;
            this.Country.Location = new System.Drawing.Point(475, 29);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(65, 20);
            this.Country.TabIndex = 10;
            this.Country.Text = "Country";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.Location = new System.Drawing.Point(416, 29);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(35, 20);
            this.Username.TabIndex = 9;
            this.Username.Text = "City";
            // 
            // NumTel
            // 
            this.NumTel.AutoSize = true;
            this.NumTel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumTel.ForeColor = System.Drawing.Color.Black;
            this.NumTel.Location = new System.Drawing.Point(330, 29);
            this.NumTel.Name = "NumTel";
            this.NumTel.Size = new System.Drawing.Size(62, 20);
            this.NumTel.TabIndex = 8;
            this.NumTel.Text = "NumTel";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Adresse.ForeColor = System.Drawing.Color.Black;
            this.Adresse.Location = new System.Drawing.Point(237, 29);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(62, 20);
            this.Adresse.TabIndex = 7;
            this.Adresse.Text = "Adresse";
            // 
            // CIN
            // 
            this.CIN.AutoSize = true;
            this.CIN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CIN.ForeColor = System.Drawing.Color.Black;
            this.CIN.Location = new System.Drawing.Point(184, 29);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(34, 20);
            this.CIN.TabIndex = 6;
            this.CIN.Text = "CIN";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstName.ForeColor = System.Drawing.Color.Black;
            this.FirstName.Location = new System.Drawing.Point(10, 29);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(83, 20);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastName.ForeColor = System.Drawing.Color.Black;
            this.LastName.Location = new System.Drawing.Point(98, 29);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(80, 20);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Last Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.Location = new System.Drawing.Point(636, 29);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(46, 20);
            this.Email.TabIndex = 19;
            this.Email.Text = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(636, 21);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(30, 12);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "label3";
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(990, 638);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.LpPanel);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1008, 685);
            this.MinimumSize = new System.Drawing.Size(1008, 685);
            this.Name = "customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.customers_Load);
            this.LpPanel.ResumeLayout(false);
            this.LpPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tools.RoundedButton Add;
        private Panel LpPanel;
        private Label lblCodePostal;
        private Label lblCountry;
        private Label lblCity;
        private Label lblNumTel;
        private Label lblAdresse;
        private Label lblCin;
        private Label lblNom;
        private Label lblPrenom;
        private Tools.RoundedButton Edit;
        private Tools.RoundedButton Delete;
        private Panel panel1;
        private Label CodePostal;
        private Label Country;
        private Label Username;
        private Label NumTel;
        private Label Adresse;
        private Label CIN;
        private Label FirstName;
        private Label LastName;
        private Label Email;
        private Label lblEmail;
    }
}