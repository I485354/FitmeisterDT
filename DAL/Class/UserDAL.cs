using DAL.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Class
{
    public class UserDAL : SupplyDAL, IUserDAL
    {
        public SupplyDAL SupplyDAL { get; }

        public UserDAL()
        {

        }
        public DataTable GetUser()
        {

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {

                    conn.Open();
                    string sqlQuery = "SELECT * FROM [User]";
                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("GetUser gaat fout");
                }
                finally
                {
                    conn.Close();
                }
            }
            return dt;
        }
        public bool CreateAccount(FitmeisterUser user)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO [User] (Username, Email, Phone, Password, Salt, BirthDate, Weight, Height, Gender, BMI, Role) " +
                           "VALUES (@Username, @Email, @Phone, @Password, @Salt, @BirthDate, @Weight, @Height, @Gender, @BMI, @Role)"; ;
                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@Phone", user.Phone);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Salt", user.Salt);
                        command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                        command.Parameters.AddWithValue("@Weight", user.Weight);
                        command.Parameters.AddWithValue("@Height", user.Height);
                        command.Parameters.AddWithValue("@Gender", user.Gender);
                        command.Parameters.AddWithValue("@BMI",user.BMI);
                        command.Parameters.AddWithValue("@Role", "costumer");
                        foreach (SqlParameter parameter in command.Parameters)
                        {
                            if (parameter.SqlDbType == SqlDbType.NVarChar && parameter.Size > 0 && parameter.Value != null && parameter.Value.ToString().Length > parameter.Size)
                            {
                                throw new ArgumentException($"De waarde van parameter {parameter.ParameterName} is te lang voor de kolom in de database.");
                            }
                        }
                        command.ExecuteNonQuery();
                   }
                }
                catch (SqlException ex)
                {
                    // Log de SQL fout
                    Console.WriteLine($"SQL fout: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    // Log de algemene fout
                    Console.WriteLine($"Algemene fout: {ex.Message}");
                    return false;
                }

            }
            return true;
        }
        public bool UpdateUser(FitmeisterUser user)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                var command = new SqlCommand("UPDATE [User] SET Username = @Username, Email = @Email, Weight = @Weight, Height = @Height, Password = @Password, Phone = @Phone, BMI = @BMI, Role = @Role WHERE UserID = @UserID", conn);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Height", user.Height);
                command.Parameters.AddWithValue("@Weight", user.Weight);
                command.Parameters.AddWithValue("@Phone", user.Phone);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@BMI", user.BMI);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.Parameters.AddWithValue("@UserID", user.UserID);
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
        public bool GetLoginData(string email, string pass, out FitmeisterUser user)
        {
            user = null;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                string query = "SELECT * FROM [User] WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", pass);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new FitmeisterUser
                        {
                            UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            Password = reader.GetString(reader.GetOrdinal("Password")),
                            Salt = reader.GetString(reader.GetOrdinal("Salt")),
                            Role = reader.GetString(reader.GetOrdinal("Role")),
                        };
                        return true;  // Gebruiker gevonden
                    }
                }
            }
            return false;
        }

        public bool DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM [User] WHERE UserID = @UserID";
                    SqlCommand command = new SqlCommand(deleteQuery, conn);
                    command.Parameters.AddWithValue("@UserID", userId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting user: " + ex.Message);
                    return false;
                }
            }
        }
    }

}

