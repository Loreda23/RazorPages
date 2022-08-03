#define Rating
#if Rating
#region snippet_1 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovies.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMoviesContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                #region snippet1
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Made For You with Love",
                        ReleaseDate = DateTime.Parse("2019-05-01"),
                        Genre = "Comedie Romantique",
                        Price = 14999,
                        Rating = "G"
                    },
                #endregion
                    new Movie
                    {
                        Title = "Le Crocodile Du Botswanga ",
                        ReleaseDate = DateTime.Parse("2015-07-08"),
                        Genre = "Comedie",
                        Price =11450,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "L'heritage de Saw",
                        ReleaseDate = DateTime.Parse("2014-09-23"),
                        Genre = "Tragedie",
                        Price = 23460,
                        Rating = "Na"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-07-29"),
                        Genre = "Western",
                        Price = 16700,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
#endregion
#endif