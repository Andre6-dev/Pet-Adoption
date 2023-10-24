using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Vaccine
{
    [Column("VaccineId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Vaccine name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Vaccine cost is a required field.")]
    public Double? Cost { get; set; }
    public DateTime? DateOfVaccination { get; set; }
    public DateTime? NextVaccination { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    [ForeignKey(nameof(Pet))]
    public Guid PetId { get; set; }
    public Pet? Pet { get; set; }
}