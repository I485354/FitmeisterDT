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
    public partial class FoodPage : Form
    {
        readonly IUserBLL userBLL;
        readonly IFoodBLL foodBLL;
        public FoodPage(IFoodBLL food)
        {
            InitializeComponent();

            this.foodBLL = food;
            this.userBLL = new UserBLL(new UserDAL());
            ShowPanel();
        }
        private void ShowPanel()
        {
            FoodPanel panel = new FoodPanel(foodBLL);
            addUserControl(panel);
        }    
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelForFood.Controls.Clear();
            panelForFood.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
           new AdminPage(userBLL).Show();
            this.Close();
        }
    }
}
