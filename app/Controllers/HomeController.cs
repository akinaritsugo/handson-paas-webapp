using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using WebApplication1.Models;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            var list = new List<Employee>();
            var connectionString = _configuration.GetConnectionString("SampleDatabase");

            using (var con = new SqlConnection(connectionString))
            using (var cmd = con.CreateCommand())
            {
                try
                {
                    // DB接続
                    con.Open();

                    // クエリ実行
                    cmd.CommandText = @"SELECT [code],[name],[survey_year],[employees] FROM [prefectures] LEFT JOIN [work] ON [prefectures].[code] = [work].[prefectures_code] WHERE [survey_year]=@SURVEY_YEAR";
                    cmd.Parameters.Add(new SqlParameter("@SURVEY_YEAR", 2015));

                    // 一行ずつ取得
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read() == true)
                        {
                            list.Add(new Employee()
                            {
                                PrefectureCode = int.Parse(reader["code"].ToString()),
                                PrefectureName = reader["name"].ToString(),
                                SurveyYear = int.Parse(reader["survey_year"].ToString()),
                                Employees = int.Parse(reader["employees"].ToString())
                            });
                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
                finally
                {
                    con.Close();
                }

            }

            return View(list);
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
