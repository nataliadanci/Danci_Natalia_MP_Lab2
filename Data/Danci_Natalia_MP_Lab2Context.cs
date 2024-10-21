using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Danci_Natalia_MP_Lab2.Models;

namespace Danci_Natalia_MP_Lab2.Data
{
    public class Danci_Natalia_MP_Lab2Context : DbContext
    {
        public Danci_Natalia_MP_Lab2Context (DbContextOptions<Danci_Natalia_MP_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Danci_Natalia_MP_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Danci_Natalia_MP_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Danci_Natalia_MP_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Danci_Natalia_MP_Lab2.Models.Category>Category { get; set; } = default!;
    }
}
