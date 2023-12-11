using A.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
namespace A.Controllers
{
    public class DisplayController : Controller
    {

        public IActionResult Index(DateTime? start, DateTime? end)
        {
            //    string mainconn = System.Configuration.ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            //  SqlConnection sqlConn = new SqlConnection(mainconn);
            //    string sqlquery = "select * from Transactionentry where transdate between " + start + "`and`" + end + "`";
            //    SqlCommand sqlcomm=new SqlCommand(sqlquery, sqlConn);
            //    sqlConn.Open();
            //    SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            //    DataSet ds = new DataSet();
            //    sda.Fill(ds);
            //    List<Store> lc = new List<Store>();
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //        lc.Add(new Store
            //        {
            //            Id = Convert.ToInt32(dr["ID"]),
            //            Location = Convert.ToString(dr["Location"])
            //        }) ;
            //    }
            //    sqlConn.Close();
            //    ModelState.Clear();
            //    return View(lc);
            //}
            return View();
        }
    }
}
