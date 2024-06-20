using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEF
{
    public class DataContext : DbContext
    {
    
        public String Dbpath { get; set; }
        public object Users { get; internal set; }

        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            Dbpath = Path.Join(path, "EFClass1.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={Dbpath}");
        }
    }
}
