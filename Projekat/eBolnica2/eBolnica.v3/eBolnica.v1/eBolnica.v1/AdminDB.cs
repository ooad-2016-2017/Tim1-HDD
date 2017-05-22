using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Data.Entity;
using Windows.Storage;
using System.IO;
using eBolnica.v1.Model;

namespace eBolnica.v1
{
    public class AdminDB : DbContext
    {
        public DbSet<Pacijent> Pacijenti { get; set; }
        public DbSet<Doktor> Doktori { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string databaseFilePath = "AdminDB.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }

            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {

         }*/
    }
}
