using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsWebSite.Models;


namespace NewsWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public async Task<IActionResult> TestAsync()
        {
            IList<string> data = new List<string>();
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=dbo"))
            {
                await connection.OpenAsync();
                var command = connection.CreateCommand();
                command.CommandText = "select * from article";
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    data.Add(reader["id"].ToString() + " " + reader["title"] + " " + reader["body"]);
                }
            }
            return View(data);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
