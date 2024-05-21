using DAL.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Class
{
    public class DailylogDAL : SupplyDAL, IDailylogDAL
    {
        public DailylogDAL() 
        {
            
        }
        public DailyLog GetDailyLog(int userId, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string sqlQuery = "SELECT * FROM DailyLogs WHERE userID = @userID AND date = @date";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@userID", userId);
                    command.Parameters.AddWithValue("@date", date);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DailyLog
                            {
                                LogID = reader.GetInt32(reader.GetOrdinal("logID")),
                                UserID = reader.GetInt32(reader.GetOrdinal("userID")),
                                Date = reader.GetDateTime(reader.GetOrdinal("date")),
                                TotalCalories = reader.IsDBNull(reader.GetOrdinal("totalCalories")) ? 0 : reader.GetInt32(reader.GetOrdinal("totalCalories")),
                                TotalFats = reader.IsDBNull(reader.GetOrdinal("totalFat")) ? 0 : reader.GetDouble(reader.GetOrdinal("totalFat")),
                                TotalCarbs = reader.IsDBNull(reader.GetOrdinal("totalCarbs")) ? 0 : reader.GetDouble(reader.GetOrdinal("totalCarbs")),
                                TotalProteins = reader.IsDBNull(reader.GetOrdinal("totalProtein")) ? 0 : reader.GetDouble(reader.GetOrdinal("totalProtein"))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public DailyLog CreateDailyLog(int userId, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string insertQuery = "INSERT INTO DailyLogs (userID, date) OUTPUT INSERTED.logID VALUES (@userID, @date)";
                using (SqlCommand command = new SqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@userID", userId);
                    command.Parameters.AddWithValue("@date", date);
                    conn.Open();
                    int newLogId = (int)command.ExecuteScalar();
                    return new DailyLog { LogID = newLogId, UserID = userId, Date = date };
                }
            }
        }
        public void UpdateDailyLogs(int cal, decimal fat, decimal carbs, decimal proteins, int logID)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string updateQuery = @"
                UPDATE DailyLogs
                SET 
                    totalCalories = @totalCalories,
                    totalFat = @totalFat,
                    totalCarbs = @totalCarbs,
                    totalProtein = @totalProteins
                WHERE logID = @logID";

                using (SqlCommand command = new SqlCommand(updateQuery, conn))
                {
                    command.Parameters.AddWithValue("@totalCalories", cal);
                    command.Parameters.AddWithValue("@totalFat", fat);
                    command.Parameters.AddWithValue("@totalCarbs", carbs);
                    command.Parameters.AddWithValue("@totalProteins", proteins);
                    command.Parameters.AddWithValue("@logID", logID);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
