using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Entities;

namespace MyProject.Context
{
    public class MyContext
    {
        public class MyDbContex : DbContext, IContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<Child> Children { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=MyProjectDb;Trusted_Connection=True;");
                // options.UseSqlServer("Data Source=sqlsrv;Initial Catalog=__________tamar;Integrated Security=True;Trusted_Connection=True;");
            }
            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=MyProjectDb;Trusted_Connection=True;", builder =>
            //    {
            //        builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            //    });
            //    base.OnConfiguring(optionsBuilder);
            //}
            // public MyDbContex(DbContextOptions<MyDbContex> options):base(options) { }
        }
    }
}
