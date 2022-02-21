using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Week9Day1Demo.Services
{
    public class Orders
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public double StateTax { get; set; }
    }

    public class OrdersDbService
    {
        private const string connectionString = @"Data Source=.;Initial Catalog=WorldLineDatabase;User ID=worldline;Password=Test@123";

        public List<Orders> GetOrders()
        {
            var orders = new List<Orders>();

            // 1. Open Connection to Database Server
            using (var connection = new SqlConnection(connectionString))
            {
                const string query = "select * from Orders";
                // 2. Create a command with query for the current connection
                using (var command = new SqlCommand(query, connection))
                {
                    // 3. Execute the command to get a DataReader
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var order = new Orders
                                {
                                    Id = reader.GetInt32(0),
                                    Title = reader.GetString(1),
                                    Date = reader.GetDateTime(2),
                                    StateTax = reader.GetDouble(3)
                                };

                                orders.Add(order);
                            }
                        }
                    }
                }
            }

            return orders;
        }

        public DataSet GetOrdersDataSet()
        {
            // 1. Open Connection to Database Server
            using (var connection = new SqlConnection(connectionString))
            {
                const string query = "select * from Orders";

                // 2. Create a SqlDataAdapter with query or StoredProcedure for the current Connection
                using (var dataAdapter = new SqlDataAdapter(query, connection))
                {
                    var dataSetOrders = new DataSet();
                    dataAdapter.Fill(dataSetOrders, "Orders");

                    return dataSetOrders;
                }
            }
        }
    }
}