using BillingSystem.BusinessLogic;
using BillingSystem.DataAxisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem.UI
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        UserBL bl = new UserBL();
        userDAL dal = new userDAL();

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bl.firstname = fnameText.Text;
            bl.lastname = lnameText.Text;
            bl.email = emailText.Text;
            bl.username = unameText.Text;
            bl.password = pwordText.Text;
            bl.contact = contactText.Text;
            bl.address = addText.Text;
            bl.gender = genderCombo.Text;
            bl.usertype = userCombo.Text;
            bl.addeddate = DateTime.Now;
            bl.addedby = 1;

            bool success = dal.insert(bl);
            if(success == true)
            {
                MessageBox.Show("User added successfully");
            }
            else
            {
                MessageBox.Show("Error adding the user");
            }
        }
    }
}
