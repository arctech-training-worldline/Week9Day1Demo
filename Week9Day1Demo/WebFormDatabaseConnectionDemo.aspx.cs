using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Week9Day1Demo.Services;

namespace Week9Day1Demo
{
    public partial class WebFormDatabaseConnectionDemo : System.Web.UI.Page
    {
        protected void ButtonShowAllOrders_OnClick(object sender, EventArgs e)
        {
            var ordersDbService = new OrdersDbService();
            var orders = ordersDbService.GetOrders();

            //var sb = new StringBuilder();
            //sb.AppendLine("Id,Title,Date,StateTax");
            //foreach (var order in orders)
            //{
            //    sb.AppendLine($"{order.Id},{order.Title},{order.Date:dd-MMM-yyyy},{order.StateTax}");
            //}
            //TextBoxRecords.Text = sb.ToString();

            TextBoxRecords.Text = JsonConvert.SerializeObject(orders);
        }

        protected void ButtonShowOrdersDataSet_Click(object sender, EventArgs e)
        {
            var ordersDbService = new OrdersDbService();
            var ordersDataSet = ordersDbService.GetOrdersDataSet();

            TextBoxRecords.Text = JsonConvert.SerializeObject(ordersDataSet);
        }
    }
}