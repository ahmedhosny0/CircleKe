using A.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Data;

namespace A.Controllers;

    public class StoreController : Controller
    {
    string connectionString = @"Data Source = 192.168.1.156;User ID=sa;Password=P@ssw0rd;Database=DATA_CENTER;Connect Timeout=150;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
    TestContext objContext = new TestContext();
    public IActionResult Index()
    {
        DataTable dt = new DataTable();
        using (SqlConnection sqlCon = new SqlConnection(connectionString))
        {
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Select STORE_ID,Location,price_category,Franchise,GOVERNMENT from stores", sqlCon);
            sqlDa.Fill(dt);
        }
        return View(dt);
    }
    public IActionResult StoresSales()
    {
        DataTable dt = new DataTable();
        using (SqlConnection sqlCon = new SqlConnection(connectionString))
        {
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("select Stores.LOCATION Store_Name,sum(T.Quantity*T.Price) Total_Sales from TransactionEntry T inner join Stores on Stores.STORE_ID=T.StoreID where cast(T.TransactionTime as date) between '2023-01-01'and '2023-01-31' Group by Stores.LOCATION\r\n", sqlCon);
            sqlDa.Fill(dt);
        }
        return View(dt);
    }

}


