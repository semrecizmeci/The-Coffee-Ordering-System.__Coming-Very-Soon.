using Kahve_Sipariş_Proje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
namespace Kahve_Sipariş_Proje.Controllers
{
    public class AnaMenuController : Controller
    {
        private readonly string _conncetionString = "Server=104.247.162.242\\MSSQLSERVER2017;Database=akadem58_sc1;" + "User Id=akadem58_sc1;Password=Ez7t46d3%;";
        public IActionResult AnaMenu()
        {
            return View();
        }

        //public IActionResult todoList()
        //{
        //    // veri çekme
        //    var addto = new List<todoList>();
        //    using (SqlConnection connection = new SqlConnection(_conncetionString))
        //    {
        //        connection.Open();
        //        var command = new SqlCommand("SELECT id,todo,completed,created_on,updates_on FROM todoList", connection);
        //        var reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            var item = new todoList();
        //            item.Id = reader.GetInt32(0);
        //            item.Todo = reader.GetString(1);
        //            item.Completed = reader.GetInt32(2);
        //            item.Created_on = reader.GetDateTime(3);
        //            item.Updates_on = reader.GetDateTime(4);
        //            addto.Add(item);
        //        }
        //    }
        //    return Json(addto);
        //}



        public IActionResult KahveMenu()
        {

            var addto = new List<Coffee>();
            using (SqlConnection connection = new SqlConnection(_conncetionString))
            {
                connection.Open();
                var command = new SqlCommand("select coffeeId, coffeeName, price from Coffees_Name", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var item = new Coffee();
                    item.CoffeeId = reader.GetInt32(0);
                    item.CoffeeName = reader.GetString(1);
                    item.Price = reader.GetInt32(2);


                    addto.Add(item);
                }

            }
            return View(addto);
        }
       
    }
}
