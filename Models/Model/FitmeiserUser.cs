using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class FitmeisterUser
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }  
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string Gender { get; set; }
        public decimal BMI { get; set; }
        public string Role { get; set; }

        public FitmeisterUser()
        {

        }

        public FitmeisterUser(int id, string name, string pass, string email, string number, string gender, DateTime birthday, decimal weight, decimal height, decimal BMI, string role)
        {
            this.UserID = id;
            this.Username = name;
            this.Password = pass;
            this.Email = email;
            this.Phone = number;
            this.Gender = gender;
            this.BirthDate = birthday;
            this.Weight = weight;
            this.Height = height;
            this.BMI = BMI;
            Role = role;
        }

        public FitmeisterUser(string name, string pass, string email, string number, string gender, DateTime birthday, decimal weight, decimal height, decimal BMI)
        {
            this.Username = name;
            this.Password = pass;
            this.Email = email;
            this.Phone = number;
            this.Gender = gender;
            this.BirthDate = birthday;
            this.Weight = weight;
            this.Height = height;
        }
        
        public FitmeisterUser(int id, string name, string email, decimal height, decimal weight)
        {
            this.UserID = id;
            this.Username = name;
            this.Email= email;
            this.Height = height;
            this.Weight = weight;
        }

        public FitmeisterUser(string email, string pass,string role)
        {
            this.Email = email;
            this.Password = pass;   
            this.Role = role;
            
        }
    }
}
