using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models;

public class UserModel
{
    public int Id { get; set; }
    
    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    [StringLength(256)]
    public string Email { get; set; }
    
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First name is required")]
    [StringLength(128)]
    public string FirstName { get; set; }
    
    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Display(Name = "Account Status")]
    public bool IsLocked { get; set; }
    
    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last name is required")]
    [StringLength(128)]
    public string LastName { get; set; }
    
    [Display(Name = "Phone Number")]
    [Phone(ErrorMessage = "Invalid phone number format")]
    [StringLength(16)]
    public string PhoneNumber { get; set; }
    
    [Display(Name = "Profile Picture")]
    [DataType(DataType.ImageUrl)]
    public string ProfilePictureUrl { get; set; }
}
