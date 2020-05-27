using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public class StarWarsDBContext : DbContext
    {
       // liste des grilles.
        public DbSet<TblGrille> grilles { get; set; }

        // liste des parties.
        public DbSet<TblPartie> parties { get; set; }

        // Configurer l'instance du context.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder ConnectionString = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["StarWarsDBContext"].ConnectionString);
            
            optionsBuilder.UseSqlServer(ConnectionString.ToString());
        }
    }
}
