using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class Product
    { 
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Department { get; set; }
    }
}