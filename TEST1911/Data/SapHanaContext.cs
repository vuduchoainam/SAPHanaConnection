using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.SapHana;
using System;
using System.Linq;
using TEST1911.Models;

namespace TEST1911.Data
{
    public class SapHanaContext : DataConnection
    {
        public SapHanaContext()
            : base(LinqToDB.ProviderName.SapHanaOdbc, string.Format(
            "driver={0};servernode={1};uid={2};pwd={3};cs={4};",
            IntPtr.Size == 8 ? "{hdbodbc}" : "{hdbodbc32}",
            "103.42.57.57:30015",
            "SAC_BI",
            "Sacbi123",
            "TEST1811"))
        {
        }

        public IQueryable<Customer> Customers => this.GetTable<Customer>();

    }
}
