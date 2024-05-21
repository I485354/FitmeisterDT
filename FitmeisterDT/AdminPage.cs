using BLL.Admin;
using BLL.Interface;
using DAL.Class;
using FitmeisterDT.PanelControl;
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
    public partial class AdminPage : Form
    {
        public readonly IUserBLL userBLL;
        public readonly IFoodBLL foodBLL;

        public AdminPage(IUserBLL user)
        {
            InitializeComponent();

            foodBLL = new FoodBLL(new FoodDAL());
            this.userBLL = user;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            adminPanel.Controls.Clear();
            adminPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void UserInfoBtn_Click(object sender, EventArgs e)
        {
            logoPicture.Visible = false;
            adminPanel.Visible = true;
            if (adminPanel.Visible == true)
            {
                UserPanel panel = new UserPanel(userBLL);
                addUserControl(panel);
            }
        }

        private void foodPageBtn_Click(object sender, EventArgs e)
        {
            new FoodPage(foodBLL).Show();
            this.Hide();
        }
    }
}
