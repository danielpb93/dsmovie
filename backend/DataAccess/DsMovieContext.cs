using backend.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DataAccess
{
    public class DsMovieContext : DbContext
    {
        public DsMovieContext(DbContextOptions<DsMovieContext> options) : base(options){}

        DbSet<Movie> Movie { get; set; }
        DbSet<User> User { get; set; }
        DbSet<Score> Score { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>()
                .HasKey(s => new { s.MovieId, s.UserId });

            modelBuilder.Entity<Score>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Scores)
                .HasForeignKey(s => s.MovieId);

            modelBuilder.Entity<Score>()
                .HasOne(s => s.User)
                .WithMany(u => u.Scores)
                .HasForeignKey(s => s.UserId);
        }
    }
}
