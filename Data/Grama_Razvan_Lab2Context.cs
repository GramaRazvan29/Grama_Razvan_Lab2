using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grama_Razvan_Lab2.Models;

namespace Grama_Razvan_Lab2.Data
{
    public class Grama_Razvan_Lab2Context : DbContext
    {
        public Grama_Razvan_Lab2Context (DbContextOptions<Grama_Razvan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Grama_Razvan_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Grama_Razvan_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
