using Microsoft.EntityFrameworkCore;
using StorageApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace StorageApi.Data
{
    public class StorageApiContext : DbContext
    {
        public StorageApiContext(DbContextOptions<StorageApiContext> options)
            : base(options)
        {
        }

        public DbSet<StorageApi.Models.Product> Product { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "dd",
                    Category = "f",
                    Count = 1,
                    Description = "dd",
                    Price = 22,
                    Shelf = "fsa"
                }
                );

           

        }

    }
}
