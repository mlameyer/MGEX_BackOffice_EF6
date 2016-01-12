using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;

namespace MGEX_BackOffice_EF6.Models
{
    public class ProductLast
    {
        public string Product { get; set; }
        public decimal B_Price { get; set; }
        public decimal O_Price { get; set; }
        public int B_Seq_Num { get; set; }
        public int O_Seq_Num { get; set; }
        public int B_Time { get; set; }
        public int O_Time { get; set; }
    }
}