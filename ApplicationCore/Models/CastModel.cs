using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models;

public class CastModel
{
    public int Id { get; set; }
    
    [Display(Name = "Name")]
    public string Name { get; set; }
    
    [Display(Name = "Character")]
    public string Character { get; set; }
    
    [Display(Name = "Profile Path")]
    public string? ProfilePath { get; set; }
    
    [Display(Name = "Gender")]
    public string Gender { get; set; }
    
    [Display(Name = "TMDB URL")]
    public string TmdbUrl { get; set; }

}
