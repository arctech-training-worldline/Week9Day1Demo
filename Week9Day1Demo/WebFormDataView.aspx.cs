using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Week9Day1Demo.Services;

namespace Week9Day1Demo
{
    public partial class WebFormDataView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var orderDbService = new OrdersDbService();

            GridView1.DataSource = orderDbService.GetOrdersDataSet();
            GridView1.DataBind();
        }
    }
}