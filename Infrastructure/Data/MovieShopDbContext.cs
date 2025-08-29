using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data;

public class MovieShopDbContext : DbContext
{
    public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options) : base(options)
    {

    }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movie { get; set; }
    public DbSet<Trailer> Trailers { get; set; }
    public DbSet<MovieGenre> MovieGenres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        
        // modelBuilder.Entity<Movie>(entity => {
        //     entity.Property(e => e.Title).HasColumnType("varchar(256)");
        //     entity.HasKey(e => e.Id);
        // })

        modelBuilder.Entity<Movie>(ConfigureMovie);
        modelBuilder.Entity<MovieGenre>(ConfigureMovieGenre);
    }

    public void ConfigureMovie(EntityTypeBuilder<Movie> builder){
        // fluent api
        builder.ToTable("Movies");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Title).HasColumnType("varchar(500)");
        builder.Property(e => e.Overview).HasColumnType("varchar(512)");

   


    }

    public void ConfigureMovieGenre(EntityTypeBuilder<MovieGenre> modelBuilder){
        modelBuilder.HasKey(x => new { x.MovieId, x.GenreId });
        modelBuilder.HasOne(x => x.Movie)
        .WithMany(x => x.MovieGenres)
        .HasForeignKey(x => x.MovieId);
        
        modelBuilder.HasOne(x => x.Genre)
        .WithMany(x => x.MovieGenres)
        .HasForeignKey(x => x.GenreId);
    }
}