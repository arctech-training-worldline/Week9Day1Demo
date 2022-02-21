using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Week9Day1Demo.Services
{
    public class o
    {
        public DataSet GetCategoryDataSet()
        {
            const string connectionString = "";
            using (var connection = new SqlConnection(connectionString))
            {
                const string query = "SELECT CategoryID, CategoryName FROM Categories;";
                var adapter = new SqlDataAdapter(query, connection);

                var dataSetCategory = new DataSet();
                adapter.Fill(dataSetCategory, "Categories");

                return dataSetCategory;
            }
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static List<Category> GetCategoryData()
        {
            var categories = new List<Category>();
            const string connectionString = "";

            using (var connection = new SqlConnection(connectionString))
            {
                const string query = "SELECT CategoryID, CategoryName FROM Categories;";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                categories.Add(
                                    new Category { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                            }
                        }
                    }
                }
            }

            return categories;
        }
    }
}