using DAL.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Class
{
    public class FoodDAL : SupplyDAL, IFoodDAL
    {
        public DataTable GetFoodItems()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string sqlQuery = "SELECT * FROM [FoodItem]";
                try
                {

                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Er is een databasefout opgetreden: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Er is een onverwachte fout opgetreden: {ex.Message}");
                }
            }
            return dt;
        }
        public FoodItem GetDataById(int foodId)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM FoodItem WHERE FoodID = @FoodID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FoodID", foodId);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                            if (dt.Rows.Count > 0)
                            {
                                DataRow row = dt.Rows[0];
                                return new FoodItem
                                {
                                    FoodID = Convert.ToInt32(row["FoodID"]),
                                    FoodName = row["FoodName"].ToString(),
                                    FoodGroup = row["FoodGroup"].ToString(),
                                    Quantity = row["Quantity"].ToString(),
                                    ContainsTracesOf = row["ContainsTracesOf"].ToString(),
                                    KJ = Convert.ToInt32(row["KJ"]),
                                    Kcal = Convert.ToInt32(row["Kcal"]),
                                    Water = Convert.ToDecimal(row["Water"]),
                                    Protein = Convert.ToDecimal(row["Protein"]),
                                    Fat = Convert.ToDecimal(row["Fat"]),
                                    Carbs = Convert.ToDecimal(row["Carbs"]),
                                    Sugar = Convert.ToDecimal(row["Sugar"])
                                };
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Database error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                    }
                }
            }
            return null; 
        }
        public List<FoodItem> GetNamesFoodItem()
        {
            List<FoodItem> foodNames = new List<FoodItem>();
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string sqlQuery = "SELECT [FoodID], [FoodName] FROM [FoodItem]";
                try
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FoodItem foodItem = new FoodItem
                                {
                                    FoodID = Convert.ToInt32(reader["FoodID"]),
                                    FoodName = reader["FoodName"].ToString()
                                };
                                foodNames.Add(foodItem);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Er is een databasefout opgetreden: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Er is een onverwachte fout opgetreden: {ex.Message}");
                }
            }
            return foodNames;
        }
        public bool CreateFoodItem(FoodItem items) 
        { 
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO FoodItem( FoodGroup, FoodName, Quantity, ContainsTracesOf, KJ, Kcal, Water, Protein, Fat, Carbs, Sugar) " +
                        "VALUES( @FoodGroup, @FoodName, @Quantity, @ContainsTracesOf, @KJ, @Kcal, @Water, @Protein, @Fat, @Carbs, @Sugar)";
                    using (SqlCommand command = new SqlCommand(insertQuery, conn))
                    {
                        
                        command.Parameters.AddWithValue("@FoodGroup", items.FoodGroup);
                        command.Parameters.AddWithValue("@FoodName", items.FoodName);
                        command.Parameters.AddWithValue("@Quantity", items.Quantity);
                        command.Parameters.AddWithValue("@ContainsTracesOf", items.ContainsTracesOf);
                        command.Parameters.AddWithValue("@KJ", items.KJ);
                        command.Parameters.AddWithValue("@Kcal", items.Kcal);
                        command.Parameters.AddWithValue("@Water", items.Water);
                        command.Parameters.AddWithValue("@Protein", items.Protein);
                        command.Parameters.AddWithValue("@Fat", items.Fat);
                        command.Parameters.AddWithValue("@Carbs", items.Carbs);
                        command.Parameters.AddWithValue("@Sugar", items.Sugar);

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
                    
                    Console.WriteLine($"SQL fout: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Algemene fout: {ex.Message}");
                    return false;
                }
            }
            return true;
        }
        public bool EditFoodItem(FoodItem items)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    conn.Open();
                    string UpdateQuery = "UPDATE FoodItem SET FoodGroup = @FoodGroup, FoodName = @FoodName, Quantity = @Quantity, ContainsTracesOf = @ContainsTracesOf, KJ = @KJ, Kcal = @Kcal, Water = @Water, Protein = @Protein, Fat = @Fat, Carbs = @Carbs, Sugar = @Sugar " +
                        "WHERE FoodID = @FoodID";
                    using (SqlCommand command = new SqlCommand(UpdateQuery, conn))
                    {
                        command.Parameters.AddWithValue("@FoodID", items.FoodID);
                        command.Parameters.AddWithValue("@FoodGroup", items.FoodGroup);
                        command.Parameters.AddWithValue("@FoodName", items.FoodName);
                        command.Parameters.AddWithValue("@Quantity", items.Quantity);
                        command.Parameters.AddWithValue("@ContainsTracesOf", items.ContainsTracesOf);
                        command.Parameters.AddWithValue("@KJ", items.KJ);
                        command.Parameters.AddWithValue("@Kcal", items.Kcal);
                        command.Parameters.AddWithValue("@Water", items.Water);
                        command.Parameters.AddWithValue("@Protein", items.Protein);
                        command.Parameters.AddWithValue("@Fat", items.Fat);
                        command.Parameters.AddWithValue("@Carbs", items.Carbs);
                        command.Parameters.AddWithValue("@Sugar", items.Sugar);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);  
                    return false;
                }
            }
        }
        public bool DeleteFoodItem(int foodId) 
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM [FoodItem] WHERE FoodID = @FoodID";
                    SqlCommand command = new SqlCommand(deleteQuery, conn);
                    command.Parameters.AddWithValue("@FoodID", foodId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting fooditem: " + ex.Message);
                    return false;
                }
            }
        }
        public List<FoodItem> SearchFoodItem(string searchTerm)
        {
            List<FoodItem> resultList = new List<FoodItem>();
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    conn.Open();
                    string searchQuery = "SELECT * FROM FoodItem WHERE FoodName LIKE @SearchTerm OR FoodGroup LIKE @SearchTerm";
                    using (SqlCommand command = new SqlCommand(searchQuery, conn))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FoodItem foodItem = new FoodItem
                                {
                                    FoodID = Convert.ToInt32(reader["FoodID"]),
                                    FoodName = reader["FoodName"].ToString(),
                                    FoodGroup = reader["FoodGroup"].ToString(),
                                    Quantity = reader["Quantity"].ToString(),
                                    ContainsTracesOf = reader["ContainsTracesOf"].ToString(),
                                    KJ = Convert.ToInt32(reader["KJ"]),
                                    Kcal = Convert.ToInt32(reader["Kcal"]),
                                    Water = Convert.ToDecimal(reader["Water"]),
                                    Protein = Convert.ToDecimal(reader["Protein"]),
                                    Fat = Convert.ToDecimal(reader["Fat"]),
                                    Carbs = Convert.ToDecimal(reader["Carbs"]),
                                    Sugar = Convert.ToDecimal(reader["Sugar"])
                                };
                                resultList.Add(foodItem);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                    return null;
                }
            }
            return resultList;
        }
        public List<FoodItem> GetFoodItemsForMeal(int mealId)
        {
            var foodItems = new List<FoodItem>();

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                string sqlQuery = @"
            SELECT fi.* 
            FROM MealFoodItem mfi
            INNER JOIN FoodItem fi ON mfi.foodID = fi.FoodID
            WHERE mfi.mealID = @mealID";
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@mealID", mealId);
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foodItems.Add(new FoodItem
                            {
                                FoodID = reader.GetInt32(reader.GetOrdinal("FoodID")),
                                FoodGroup = reader.GetString(reader.GetOrdinal("FoodGroup")),
                                FoodName = reader.GetString(reader.GetOrdinal("FoodName")),
                                Quantity = reader.GetString(reader.GetOrdinal("Quantity")),
                                KJ = reader.GetInt32(reader.GetOrdinal("KJ")),
                                Kcal = reader.GetInt32(reader.GetOrdinal("Kcal")),
                                Water = reader.GetDecimal(reader.GetOrdinal("Water")),
                                Protein = reader.GetDecimal(reader.GetOrdinal("Protein")),
                                Fat = reader.GetDecimal(reader.GetOrdinal("Fat")),
                                Carbs = reader.GetDecimal(reader.GetOrdinal("Carbs")),
                                Sugar = reader.GetDecimal(reader.GetOrdinal("Sugar"))
                            });
                        }
                    }
                }
            }

            return foodItems;
        }
    }
}

