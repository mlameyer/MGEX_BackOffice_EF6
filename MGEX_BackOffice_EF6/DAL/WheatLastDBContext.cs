using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MGEX_BackOffice_EF6.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace MGEX_BackOffice_EF6.DAL
{
    public class WheatLastDBContext : DbContext
    {
        public List<ProductLast> getLastRecords(String procedure)
        {
            List<ProductLast> spreadList = new List<ProductLast>();
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(procedure, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            ProductLast thisSpread = new ProductLast();
                            thisSpread.Product = Convert.ToString(row["Product"]);
                            thisSpread.B_Price = Convert.ToDecimal(row["B_Price"]);
                            thisSpread.O_Price = Convert.ToDecimal(row["O_Price"]);
                            thisSpread.B_Seq_Num = Convert.ToInt32(row["B_Seq_No"]);
                            thisSpread.O_Seq_Num = Convert.ToInt32(row["O_Seq_No"]);
                            thisSpread.B_Time = Convert.ToInt32(row["B_Time"]);
                            thisSpread.O_Time = Convert.ToInt32(row["O_Time"]);
                            spreadList.Add(thisSpread);
                        }
                    }
                }
            }
            return spreadList;
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MyDbContextConnectionString"].ConnectionString;
        }
    }

    }