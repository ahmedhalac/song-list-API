using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongListAPI.Models
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Hip Hop"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Jazz"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Pop"
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Metal"
                },
                new Category
                {
                    CategoryId = 5,
                    Name = "Rock"
                }
                );
        }
    }
}
