using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Pet
{
    [Column("PetId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Pet name is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Pet color is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Color is 60 characters.")]
    public string? BaseColor { get; set; }
    
    [Required(ErrorMessage = "Sex is a required field.")]
    [MaxLength(20, ErrorMessage = "Sex can't be longer than 20 characters.")]
    public string? Sex { get; set; }
    
    [Required(ErrorMessage = "Breed is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Breed is 60 characters.")]
    public string? Breed { get; set; }
    
    [Required(ErrorMessage = "Species is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Species is 60 characters.")]
    public string? Species { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? ProfilePicture { get; set; }
    public string? Description { get; set; }
}