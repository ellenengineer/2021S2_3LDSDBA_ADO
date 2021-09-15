using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class DAO
    {
        public string connectionString = @"server=localhost\SQLEXPRESS;database=BANCO;integrated security=yes;";

        public string ConnString 
        { 
            get
            {
                return this.connectionString;
            }
        }
    }
}
