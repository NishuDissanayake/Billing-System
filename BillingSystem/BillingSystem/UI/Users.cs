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
            DataTable dt = dal.Select();
            userGrid.DataSource = dt;
        }

        public void clear()
        {
            idText.Text = "";
            fnameText.Text = "";
            lnameText.Text = "";
            emailText.Text = "";
            unameText.Text = "";
            pwordText.Text = "";
            contactText.Text = "";
            addText.Text = "";
            genderCombo.Text = "";
            userCombo.Text = "";
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
                clear();
            }
            else
            {
                MessageBox.Show("Error adding the user");
            }
            DataTable dt = dal.Select();
            userGrid.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idText.Text = userGrid.Rows[rowIndex].Cells[0].Value.ToString();
            fnameText.Text = userGrid.Rows[rowIndex].Cells[1].Value.ToString();
            lnameText.Text = userGrid.Rows[rowIndex].Cells[2].Value.ToString();
            emailText.Text = userGrid.Rows[rowIndex].Cells[3].Value.ToString();
            unameText.Text = userGrid.Rows[rowIndex].Cells[4].Value.ToString();
            pwordText.Text = userGrid.Rows[rowIndex].Cells[5].Value.ToString();
            contactText.Text = userGrid.Rows[rowIndex].Cells[6].Value.ToString();
            addText.Text = userGrid.Rows[rowIndex].Cells[7].Value.ToString();
            genderCombo.Text = userGrid.Rows[rowIndex].Cells[8].Value.ToString();
            userCombo.Text = userGrid.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            bl.id = Convert.ToInt32(idText.Text);
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

            bool success = dal.update(bl);
            if (success == true)
            {
                MessageBox.Show("User updated successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Error updating the user");
            }
            DataTable dt = dal.Select();
            userGrid.DataSource = dt;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bl.id = Convert.ToInt32(idText.Text);
            bool success = dal.delete(bl);
            if (success == true)
            {
                MessageBox.Show("User deleted successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Error deleting the user");
            }
            DataTable dt = dal.Select();
            userGrid.DataSource = dt;
        }
    }
}
