using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<Device> Device { get; set; } //veritabanındaki tabloyu buluyor, birbirine eşleştiriyor.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GAMZE\\SQLEXPRESS;Database=BotasDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;", null);
        }
    }
}
