using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetAdoption.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "BaseColor", "Breed", "DateOfBirth", "Description", "Name", "ProfilePicture", "Sex", "Species" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Black", "Domestic Shorthair", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milo is a very playful cat. He loves to play with his toys and with other cats. He is very friendly and loves to be petted.", "Milo", "https://i.pinimg.com/222x/3a/03/66/3a036686ccb51b93ebcea512672a3fe9.jpg", "Male", "Cat" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "White with Orange", "Domestic Shorthair", new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calicha is a very playful cat. She loves to play with her toys and with other cats. She is very friendly and loves to be petted.", "Calicha", "https://ih1.redbubble.net/image.5216930147.0695/raf,360x360,075,t,fafafa:ca443f4786.jpg", "Female", "Dog" }
                });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "VaccineId", "Cost", "CreatedAt", "DateOfVaccination", "Name", "NextVaccination", "PetId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 30.0, new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feline Leukemia Vaccine", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9188) },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 100.0, new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9171), new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rabies", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9180) },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 40.0, new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canine Distemper Vaccine", new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new DateTime(2023, 10, 24, 14, 20, 30, 748, DateTimeKind.Local).AddTicks(9184) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "VaccineId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "VaccineId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "VaccineId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
