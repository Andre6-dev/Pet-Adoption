using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class VaccineConfiguration : IEntityTypeConfiguration<Vaccine>
{
    public void Configure(EntityTypeBuilder<Vaccine> builder)
    {
        builder.HasData
        (
            new Vaccine
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                Name = "Rabies",
                Cost = 100.00,
                DateOfVaccination = new DateTime(2021, 10, 10),
                NextVaccination = new DateTime(2022, 10, 10),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                PetId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new Vaccine
            {
                Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                Name = "Canine Distemper Vaccine",
                Cost = 40.0,
                DateOfVaccination = new DateTime(2023, 1, 15),
                NextVaccination = new DateTime(2023, 7, 15),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                PetId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new Vaccine
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Name = "Feline Leukemia Vaccine",
                Cost = 30.0,
                DateOfVaccination = new DateTime(2023, 2, 10),
                NextVaccination = new DateTime(2023, 8, 10),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                PetId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
            }
        );
    }
    
}