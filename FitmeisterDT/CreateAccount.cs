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


namespace FitmeisterDT
{
    public partial class CreateAccount : Form
    {
        private readonly IUserBLL userBLL;

        public CreateAccount(IUserBLL user)
        {
            InitializeComponent();
            genderBox.Items.Add("Male");
            genderBox.Items.Add("Female");
            this.userBLL = user;
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (CheckIfValid())
            {
                FitmeisterUser newUser = UserData();

                bool accountCreated = userBLL.CreateAccount(newUser,newUser.Password);

                if (accountCreated)
                {
                    MessageBox.Show("Account succesvol aangemaakt!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Er is een fout opgetreden bij het aanmaken van het account.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vul alle verplichte velden in voordat u een account maakt.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIfValid()
        {
            if (string.IsNullOrWhiteSpace(fNameBox.Text) ||
                string.IsNullOrWhiteSpace(lNameBox.Text) ||
                string.IsNullOrWhiteSpace(emailBox.Text) ||
                string.IsNullOrWhiteSpace(passwordBox.Text) ||
                string.IsNullOrWhiteSpace(telBox.Text) ||
                genderBox.SelectedIndex.ToString() == " ")
            {
                return false;
            }
            else
            {

                return true;
            }
        }

        private FitmeisterUser UserData()
        {
            decimal height, weight, BMI;
            decimal.TryParse(weightBox.Text, out weight);
            decimal.TryParse(heightBox.Text, out height);
            BMI = weight / height * height;
            return new FitmeisterUser
            (
                fNameBox.Text + " " + lNameBox.Text,
                passwordBox.Text,
                emailBox.Text,
                telBox.Text,
                genderBox.Text,
                DateTime.Now,
                weight,
                height,
                BMI
            );
        }
        
    }
}
