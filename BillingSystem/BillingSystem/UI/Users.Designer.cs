
namespace BillingSystem.UI
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.LabelTop = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.fnameText = new System.Windows.Forms.TextBox();
            this.lnameText = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.unameText = new System.Windows.Forms.TextBox();
            this.uname = new System.Windows.Forms.Label();
            this.pwordText = new System.Windows.Forms.TextBox();
            this.pword = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.addText = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.contactText = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.userCombo = new System.Windows.Forms.ComboBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.LabelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(767, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 29);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LabelTop
            // 
            this.LabelTop.AutoSize = true;
            this.LabelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTop.Location = new System.Drawing.Point(345, 9);
            this.LabelTop.Name = "LabelTop";
            this.LabelTop.Size = new System.Drawing.Size(53, 18);
            this.LabelTop.TabIndex = 0;
            this.LabelTop.Text = "Users";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(23, 91);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(73, 16);
            this.fname.TabIndex = 1;
            this.fname.Text = "First Name";
            this.fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // fnameText
            // 
            this.fnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameText.Location = new System.Drawing.Point(147, 88);
            this.fnameText.Name = "fnameText";
            this.fnameText.Size = new System.Drawing.Size(167, 22);
            this.fnameText.TabIndex = 2;
            // 
            // lnameText
            // 
            this.lnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameText.Location = new System.Drawing.Point(147, 125);
            this.lnameText.Name = "lnameText";
            this.lnameText.Size = new System.Drawing.Size(167, 22);
            this.lnameText.TabIndex = 4;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(23, 128);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(70, 16);
            this.lname.TabIndex = 3;
            this.lname.Text = "Last name";
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(147, 164);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(167, 22);
            this.emailText.TabIndex = 6;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(23, 167);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 16);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.label2_Click);
            // 
            // unameText
            // 
            this.unameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameText.Location = new System.Drawing.Point(147, 203);
            this.unameText.Name = "unameText";
            this.unameText.Size = new System.Drawing.Size(167, 22);
            this.unameText.TabIndex = 8;
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(23, 206);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(77, 16);
            this.uname.TabIndex = 7;
            this.uname.Text = "User Name";
            // 
            // pwordText
            // 
            this.pwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwordText.Location = new System.Drawing.Point(147, 242);
            this.pwordText.Name = "pwordText";
            this.pwordText.PasswordChar = 'x';
            this.pwordText.Size = new System.Drawing.Size(167, 22);
            this.pwordText.TabIndex = 10;
            // 
            // pword
            // 
            this.pword.AutoSize = true;
            this.pword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pword.Location = new System.Drawing.Point(23, 245);
            this.pword.Name = "pword";
            this.pword.Size = new System.Drawing.Size(68, 16);
            this.pword.TabIndex = 9;
            this.pword.Text = "Password";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(23, 400);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(53, 16);
            this.gender.TabIndex = 15;
            this.gender.Text = "Gender";
            // 
            // addText
            // 
            this.addText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addText.Location = new System.Drawing.Point(147, 319);
            this.addText.Multiline = true;
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(167, 65);
            this.addText.TabIndex = 14;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(23, 322);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(59, 16);
            this.address.TabIndex = 13;
            this.address.Text = "Address";
            // 
            // contactText
            // 
            this.contactText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactText.Location = new System.Drawing.Point(147, 282);
            this.contactText.Name = "contactText";
            this.contactText.Size = new System.Drawing.Size(167, 22);
            this.contactText.TabIndex = 12;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(23, 285);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(104, 16);
            this.contact.TabIndex = 11;
            this.contact.Text = "Contact Number";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(23, 441);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(72, 16);
            this.user.TabIndex = 16;
            this.user.Text = "User Type";
            // 
            // genderCombo
            // 
            this.genderCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Specified"});
            this.genderCombo.Location = new System.Drawing.Point(147, 400);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(167, 24);
            this.genderCombo.TabIndex = 17;
            // 
            // userCombo
            // 
            this.userCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCombo.FormattingEnabled = true;
            this.userCombo.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.userCombo.Location = new System.Drawing.Point(147, 438);
            this.userCombo.Name = "userCombo";
            this.userCombo.Size = new System.Drawing.Size(167, 24);
            this.userCombo.TabIndex = 18;
            // 
            // idText
            // 
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(147, 51);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(167, 22);
            this.idText.TabIndex = 20;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(23, 54);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(53, 16);
            this.id.TabIndex = 19;
            this.id.Text = "User ID";
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(430, 54);
            this.searchText.Name = "searchText";
            this.searchText.ReadOnly = true;
            this.searchText.Size = new System.Drawing.Size(358, 22);
            this.searchText.TabIndex = 22;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(373, 57);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(51, 16);
            this.search.TabIndex = 21;
            this.search.Text = "Search";
            // 
            // userGrid
            // 
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Location = new System.Drawing.Point(376, 88);
            this.userGrid.Name = "userGrid";
            this.userGrid.Size = new System.Drawing.Size(412, 374);
            this.userGrid.TabIndex = 23;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(104, 510);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 33);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(513, 510);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 33);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(308, 510);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(106, 33);
            this.updateButton.TabIndex = 26;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.userGrid);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.search);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.id);
            this.Controls.Add(this.userCombo);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.user);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.addText);
            this.Controls.Add(this.address);
            this.Controls.Add(this.contactText);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.pwordText);
            this.Controls.Add(this.pword);
            this.Controls.Add(this.unameText);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lnameText);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fnameText);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.TextBox fnameText;
        private System.Windows.Forms.TextBox lnameText;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox unameText;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.TextBox pwordText;
        private System.Windows.Forms.Label pword;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox contactText;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.ComboBox userCombo;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.DataGridView userGrid;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
    }
}