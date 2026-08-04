using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDatabaseApp
{
    internal class DatabaseHelper
    {
        public static string ConnectionString =>
        @"Data Source=(LocalDB)\MSSQLLocalDB;
          Initial Catalog=StudentManagementDB;
          Integrated Security=True;
          TrustServerCertificate=True";
    }
}
