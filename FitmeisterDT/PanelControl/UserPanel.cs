using BLL.Interface;
using DAL.Class;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Model;

namespace FitmeisterDT.PanelControl
{
    public partial class UserPanel : UserControl
    {
        public readonly IUserBLL userBLL;
        public UserPanel(IUserBLL user)
        {
            InitializeComponent();
            this.userBLL = user;
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            DataTable dt = userBLL.GetUser();
            UserData.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                UserData.DataSource = dt;
                UserData.Refresh();
            }
            else
            {
                MessageBox.Show("No data to display.");
            }
        }
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            CreateAccount userAc = new CreateAccount(userBLL);
            userAc.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = userBLL.GetUser();
            UserData.DataSource = dt;
            UserData.Refresh();
        }

        private void editUserBtn_Click(object sender, EventArgs e)
        {
            
            if (UserData.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(UserData.SelectedRows[0].Cells["UserIDDataGridViewTextBoxColumn"].Value);
                string username = UserData.SelectedRows[0].Cells["UsernameDataGridViewTextBoxColumn"].Value.ToString();
                string email = UserData.SelectedRows[0].Cells["EmailDataGridViewTextBoxColumn"].Value.ToString();
                decimal height = Convert.ToDecimal(UserData.SelectedRows[0].Cells["HeightDataGridViewTextBoxColumn"].Value);
                decimal weight = Convert.ToDecimal(UserData.SelectedRows[0].Cells["WeightDataGridViewTextBoxColumn"].Value);
                string phone = UserData.SelectedRows[0].Cells["PhoneDataGridViewTextBoxColumn"].Value.ToString();
                string pass = UserData.SelectedRows[0].Cells["PasswordDataGridViewTextBoxColumn"].Value.ToString();
                string role = UserData.SelectedRows[0].Cells["Role"].Value.ToString();
                FitmeisterUser user = new FitmeisterUser { 
                    UserID = userId,
                    Username = username,
                    Email = email,
                    Height = height,
                    Weight = weight,
                    Phone  = phone,
                    Password = pass,
                    Role = role,
                    };
                EditUser editForm = new EditUser(userBLL, user);
                editForm.Show();
            }
            else
            {
                MessageBox.Show("Selecteer een gebruiker om te bewerken.");
            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (UserData.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(UserData.SelectedRows[0].Cells["UserIDDataGridViewTextBoxColumn"].Value);
                bool userDeleted = userBLL.DeleteUser(userId);
                if (userDeleted)
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the data grid view or perform any other necessary actions
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
