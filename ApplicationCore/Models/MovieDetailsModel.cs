using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models;

public class MovieDetailsModel
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Title is required")]
    [StringLength(256, ErrorMessage = "Title cannot exceed 256 characters")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "Poster URL is required")]
    [StringLength(2084, ErrorMessage = "URL cannot exceed 2084 characters")]
    [Display(Name = "Poster URL")]
    public string PosterUrl { get; set; }
    
    [Required(ErrorMessage = "Overview is required")]
    [StringLength(4096, ErrorMessage = "Overview cannot exceed 4096 characters")]
    public string Overview { get; set; }
    
    [StringLength(512, ErrorMessage = "Tagline cannot exceed 512 characters")]
    public string Tagline { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Budget must be a positive number")]
    [DataType(DataType.Currency)]
    public decimal Budget { get; set; }
    
    [Range(0, double.MaxValue, ErrorMessage = "Revenue must be a positive number")]
    [DataType(DataType.Currency)]
    public decimal Revenue { get; set; }
}
    