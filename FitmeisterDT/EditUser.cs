using BLL.Interface;
using Microsoft.VisualBasic.ApplicationServices;
using Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FitmeisterDT
{
    public partial class EditUser : Form
    {

        private readonly IUserBLL userBLL;
        private FitmeisterUser User;
        public EditUser(IUserBLL user, FitmeisterUser userData)
        {
            
            InitializeComponent();
            this.userBLL = user;
            this.User = userData;
            roleCb.Items.Add("admin");
            roleCb.Items.Add("costumer");
            PopulateUserData();
            
        }
        private void PopulateUserData()
        {
            editName.Text = User.Username;
            editEmail.Text = User.Email;
            editHeight.Text = User.Height.ToString();
            editWeight.Text = User.Weight.ToString();
            telEditBox.Text = User.Phone;
            passwordEditBox.Text = User.Password;
            roleCb.Text = User.Role;

        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordEditBox.Text == ConfirmPassword.Text && roleCb.SelectedItem != null)
                {
                    decimal weight, height, BMI;
                    if (decimal.TryParse(editHeight.Text, out height) && decimal.TryParse(editWeight.Text, out weight))
                    {
                        // Update het User object met de nieuwe gegevens
                        User.Username = editName.Text;
                        User.Email = editEmail.Text;
                        User.Password = passwordEditBox.Text; 
                        User.Role = roleCb.SelectedItem.ToString();
                        User.Phone = telEditBox.Text;
                        User.Height = height;
                        User.Weight = weight;
                        BMI = weight/height*height;
                        User.BMI = BMI;

                        bool result = userBLL.UpdateUser(User);

                        if (result)
                        {
                            MessageBox.Show("Gebruiker succesvol bijgewerkt.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Er is een fout opgetreden bij het bijwerken van de gebruiker.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Controleer de ingevoerde waarden voor gewicht en lengte.", "Ongeldige Invoer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Het bevestigingswachtwoord komt niet overeen of er is geen rol geselecteerd.", "Validatiefout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het bijwerken van de gebruiker: " + ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CancelUpdateBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
