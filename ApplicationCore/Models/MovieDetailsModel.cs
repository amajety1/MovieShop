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
    
    [StringLength(2084, ErrorMessage = "URL cannot exceed 2084 characters")]
    [Display(Name = "IMDB URL")]
    public string? ImdbUrl { get; set; }
    
    [StringLength(2084, ErrorMessage = "URL cannot exceed 2084 characters")]
    [Display(Name = "TMDB URL")]
    public string? TmdbUrl { get; set; }
    
    [StringLength(2084, ErrorMessage = "URL cannot exceed 2084 characters")]
    [Display(Name = "Backdrop URL")]
    public string? BackdropUrl { get; set; }
    
    [StringLength(64, ErrorMessage = "Language cannot exceed 64 characters")]
    [Display(Name = "Original Language")]
    public string? OriginalLanguage { get; set; }
    
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime? ReleaseDate { get; set; }
    
    [Display(Name = "Runtime (minutes)")]
    [Range(0, 500, ErrorMessage = "Runtime must be between 0 and 500 minutes")]
    public int? RunTime { get; set; }
    
    [Range(0, 100, ErrorMessage = "Price must be between $0 and $100")]
    [DataType(DataType.Currency)]
    public decimal? Price { get; set; }
    
    [Display(Name = "Created Date")]
    [DataType(DataType.DateTime)]
    public DateTime? CreatedDate { get; set; }
    
    [Display(Name = "Updated Date")]
    [DataType(DataType.DateTime)]
    public DateTime? UpdatedDate { get; set; }
    
    [Display(Name = "Updated By")]
    public string? UpdatedBy { get; set; }
    
    [Display(Name = "Created By")]
    public string? CreatedBy { get; set; }
    
    public List<CastModel> Casts { get; set; } = new List<CastModel>();
}
    