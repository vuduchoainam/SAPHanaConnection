using LinqToDB;
using LinqToDB.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using TEST1911.Data;
using TEST1911.Models;

namespace TEST1911
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        

            using (var db = new SapHanaContext())
            {
                db.CreateTable<Customer>();
                var customers = db.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
