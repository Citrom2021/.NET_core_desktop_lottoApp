using LottoAdatbazis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingAdatbazis
{
    public class VikingContext : DbContext
    {

        public DbSet<LottoSzam> LottoSzamok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VikingLotto050802;Trusted_Connection=true");
        }
    }
}
