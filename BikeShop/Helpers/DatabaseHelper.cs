using BikeShop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace BikeShop.Helpers
{
    internal static class DatabaseHelper
    {
        internal static BikeStoreContext CreateContext()
        {
            string databasePath = Path.GetFullPath(Path.Combine(
                AppContext.BaseDirectory,
                "..",
                "..",
                "..",
                "Database",
                "BikeStore.mdf"));

            string connectionString =
                $@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=""{databasePath}"";
                Integrated Security=True;
                Connect Timeout=30;";

            var options = new DbContextOptionsBuilder<BikeStoreContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new BikeStoreContext(options);
        }
    }
}