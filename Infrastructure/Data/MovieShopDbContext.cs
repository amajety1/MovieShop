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
    public DbSet<Cast> Casts { get; set; }
    public DbSet<MovieCast> MovieCasts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        
        // modelBuilder.Entity<Movie>(entity => {
        //     entity.Property(e => e.Title).HasColumnType("varchar(256)");
        //     entity.HasKey(e => e.Id);
        // })

        modelBuilder.Entity<Movie>(ConfigureMovie);
        modelBuilder.Entity<MovieGenre>(ConfigureMovieGenre);
        modelBuilder.Entity<MovieCast>(ConfigureMovieCast);
    }

    public void ConfigureMovie(EntityTypeBuilder<Movie> builder){
        // fluent api
        builder.ToTable("Movies");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).UseIdentityColumn(1, 1); // Start from 1 and increment by 1
        builder.Property(e => e.Title).HasColumnType("varchar(500)");
        builder.Property(e => e.Overview).HasColumnType("varchar(2084)");

   


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

    public void ConfigureMovieCast(EntityTypeBuilder<MovieCast> modelBuilder){
        modelBuilder.HasKey(x => new { x.MovieId, x.CastId });
        modelBuilder.ToTable("MovieCasts");
        modelBuilder.Property(x => x.Character).HasMaxLength(450);
        
        modelBuilder.HasOne(x => x.Movie)
        .WithMany()
        .HasForeignKey(x => x.MovieId);
        
        modelBuilder.HasOne(x => x.Cast)
        .WithMany()
        .HasForeignKey(x => x.CastId);
    }
}