using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class PetConfiguration : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.HasData
        (
            new Pet
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Name = "Calicha",
                BaseColor = "White with Orange",
                Sex = "Female",
                Breed = "Domestic Shorthair",
                Species = "Dog",
                DateOfBirth = new DateTime(2019, 10, 10),
                ProfilePicture = "https://ih1.redbubble.net/image.5216930147.0695/raf,360x360,075,t,fafafa:ca443f4786.jpg",
                Description = "Calicha is a very playful cat. She loves to play with her toys and with other cats. She is very friendly and loves to be petted."
            },
            new Pet
            {
                Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                Name = "Milo",
                BaseColor = "Black",
                Sex = "Male",
                Breed = "Domestic Shorthair",
                Species = "Cat",
                DateOfBirth = new DateTime(2020, 10, 10),
                ProfilePicture = "https://i.pinimg.com/222x/3a/03/66/3a036686ccb51b93ebcea512672a3fe9.jpg",
                Description = "Milo is a very playful cat. He loves to play with his toys and with other cats. He is very friendly and loves to be petted."
            }
        );
    }
}