
namespace BillingSystem
{
    partial class UserDashboard
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
            this.UserMenu = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.StoreLNameLabel = new System.Windows.Forms.Label();
            this.StoreFNamelabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.FooterLable = new System.Windows.Forms.Label();
            this.UserMenu.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserMenu
            // 
            this.UserMenu.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.UserMenu.Location = new System.Drawing.Point(0, 0);
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(800, 25);
            this.UserMenu.TabIndex = 0;
            this.UserMenu.Text = "UserMenu";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.salesToolStripMenuItem.Text = "Sales Forms";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(171, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Billing and Inventory Management System";
            // 
            // StoreLNameLabel
            // 
            this.StoreLNameLabel.AutoSize = true;
            this.StoreLNameLabel.Font = new System.Drawing.Font("Ubuntu", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreLNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.StoreLNameLabel.Location = new System.Drawing.Point(344, 146);
            this.StoreLNameLabel.Name = "StoreLNameLabel";
            this.StoreLNameLabel.Size = new System.Drawing.Size(90, 36);
            this.StoreLNameLabel.TabIndex = 11;
            this.StoreLNameLabel.Text = "Store";
            // 
            // StoreFNamelabel
            // 
            this.StoreFNamelabel.AutoSize = true;
            this.StoreFNamelabel.Font = new System.Drawing.Font("Ubuntu", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreFNamelabel.Location = new System.Drawing.Point(281, 146);
            this.StoreFNamelabel.Name = "StoreFNamelabel";
            this.StoreFNamelabel.Size = new System.Drawing.Size(57, 36);
            this.StoreFNamelabel.TabIndex = 10;
            this.StoreFNamelabel.Text = "My";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UserNameLabel.Location = new System.Drawing.Point(64, 35);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(150, 21);
            this.UserNameLabel.TabIndex = 9;
            this.UserNameLabel.Text = "Nishu Dissanayake";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(15, 35);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(44, 21);
            this.UserLabel.TabIndex = 8;
            this.UserLabel.Text = "User";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Footer.Controls.Add(this.FooterLable);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 430);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(800, 20);
            this.Footer.TabIndex = 7;
            // 
            // FooterLable
            // 
            this.FooterLable.AutoSize = true;
            this.FooterLable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FooterLable.Location = new System.Drawing.Point(240, 0);
            this.FooterLable.Name = "FooterLable";
            this.FooterLable.Size = new System.Drawing.Size(211, 17);
            this.FooterLable.TabIndex = 0;
            this.FooterLable.Text = "Developed By: Nishu Dissanayake";
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoreLNameLabel);
            this.Controls.Add(this.StoreFNamelabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.UserMenu);
            this.MainMenuStrip = this.UserMenu;
            this.Name = "UserDashboard";
            this.Text = "User Dashboard";
            this.UserMenu.ResumeLayout(false);
            this.UserMenu.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UserMenu;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StoreLNameLabel;
        private System.Windows.Forms.Label StoreFNamelabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Label FooterLable;
    }
}