using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAppTDSII_2020.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<WebAppTDSII_2020.Models.BancosCab> BancosCab { set; get; }
        public virtual DbSet<WebAppTDSII_2020.Models.BancosDet> BancosDet { get; set; }
        //public virtual DbSet<WebAppTDSII_2020.Models.Producto> Producto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-18U8BGE; Database=DbWebAppTDSII-202009;User Id=sa; Password=123; " +
                "Trusted_Connection=false;MultipleActiveResultSets = True");
        }
    }
}
