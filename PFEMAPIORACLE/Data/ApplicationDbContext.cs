using PFEMAPIORACLE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Web;
using System.Configuration;

namespace PFEMAPIORACLE.Data
{
    public class ApplicationDbContext : DbContext
    {
        string conString = ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString;

        public ApplicationDbContext() : 
          base("conString")
        {
            //disable initializer
            Database.SetInitializer<ApplicationDbContext>(null);

            //string conString = ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString;

            OracleConnection myConnection = new OracleConnection(conString);
            myConnection.Open();
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<PFEMAPIORACLE.Models.V_TRNS_PAYMENT_HDR> V_TRNS_PAYMENT_HDR { get; set; }
    }
}