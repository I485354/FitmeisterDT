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
    public class MealDAL : SupplyDAL, IMealDAL
    {
        public void AddFoodItemToMeal(int mealId, int foodItemId)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string sqlQuery = "INSERT INTO MealFoodItem (MealID, FoodID) VALUES (@MealID, @FoodID)";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@MealID", mealId);
                    command.Parameters.AddWithValue("@FoodID", foodItemId);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public int AddMeal(Meal meal)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string sqlQuery = "INSERT INTO Meals (timestamp, name, logID, partOfDay) OUTPUT INSERTED.mealID VALUES (@timestamp, @name, @logID, @partOfDay)";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@timestamp", meal.TimeStamp);
                    command.Parameters.AddWithValue("@name", meal.Name);
                    command.Parameters.AddWithValue("@logID", meal.LogID);
                    command.Parameters.AddWithValue("@partOfDay", meal.PartOfDay);
                    conn.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public Meal GetMealForLog(int logId, string mealName)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string sqlQuery = "SELECT * FROM Meals WHERE logID = @logID AND name = @name";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@logID", logId);
                    command.Parameters.AddWithValue("@name", mealName);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Meal
                            {
                                MealID = reader.GetInt32(reader.GetOrdinal("mealID")),
                                LogID = reader.GetInt32(reader.GetOrdinal("logID")),
                                TimeStamp = reader.GetDateTime(reader.GetOrdinal("timestamp")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                PartOfDay = reader.GetString(reader.GetOrdinal("partOfDay"))
                            };
                        }
                    }
                }
            }
            return null;
        }
        public Meal CreateMealForLog(int logId, string mealName, DateTime currentDateTime)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string insertQuery = "INSERT INTO Meals (timestamp, name, logID, partOfDay) OUTPUT INSERTED.mealID VALUES (@timestamp, @name, @logID, @partOfDay)";
                using (SqlCommand command = new SqlCommand(insertQuery, conn))
                {
                    command.Parameters.AddWithValue("@timestamp", currentDateTime);
                    command.Parameters.AddWithValue("@name", mealName);
                    command.Parameters.AddWithValue("@logID", logId);
                    command.Parameters.AddWithValue("@partOfDay", mealName);
                    conn.Open();
                    int newMealId = (int)command.ExecuteScalar();
                    return new Meal { MealID = newMealId, LogID = logId, TimeStamp = currentDateTime, Name = mealName, PartOfDay = mealName };
                }
            }
        }
        public List<Meal> GetMealsForLog(int logId)
        {
            var meals = new List<Meal>();

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string sqlQuery = "SELECT * FROM Meals WHERE logID = @logID";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@logID", logId);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            meals.Add(new Meal
                            {
                                MealID = reader.GetInt32(reader.GetOrdinal("mealID")),
                                LogID = reader.GetInt32(reader.GetOrdinal("logID")),
                                TimeStamp = reader.GetDateTime(reader.GetOrdinal("timestamp")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                PartOfDay = reader.GetString(reader.GetOrdinal("partOfDay"))
                            });
                        }
                    }
                }
            }

            return meals;
        }
    }
}

