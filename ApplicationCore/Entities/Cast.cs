using System.ComponentModel.DataAnnotations;
namespace ApplicationCore.Entities;

public class Cast
{
    public int Id { get; set; }
    
    [MaxLength(128)]
    public string Name { get; set; }
    
    public string Gender { get; set; }
    
    [MaxLength(2084)]
    public string TmdbUrl { get; set; }
    
    [MaxLength(2084)]
    public string ProfilePath { get; set; }
    
    // Navigation property
    public ICollection<MovieCast> MovieCasts { get; set; }
}
