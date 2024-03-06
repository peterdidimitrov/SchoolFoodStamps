using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class SeedParents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a02b3fa-edc1-4f55-a071-55e443f33636", "AQAAAAEAACcQAAAAEJSb58k9IIquIMh2+yBPkNVetXZmnbJUXEwacu+p29zRpEK/uc14tw9QcKLpEoJKHw==", "DA737785-5163-4B98-8A1D-467EFD38C01C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5180db7a-8eb2-4b80-b531-ee0141c9620a", "AQAAAAEAACcQAAAAEA4be6gQUXe99QRVmFlAaeh6RoDWtKS23tdiT54+YQaGUe3IwodZKxul6mxuahBN1A==", "7BE0E5C4-BB86-4C22-ACBA-271BF2046E9A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28f1a300-eff1-48f4-a971-3fcb0a1cbea8", "AQAAAAEAACcQAAAAEEkx9kIvTVwWR1AuDwOLPsvcsVV3EFBBkpja2tkXjwO5P6DG/An3/AHzp4RX9rpj+A==", "E7E11008-6438-4BEE-8CC9-440372539333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2781449e-82e4-4311-965a-ec47c7f999f2", "AQAAAAEAACcQAAAAEKhhUuj03pdmtwZx4oUm8An9CkRd5VvYXlYsoyIujLj2/xZbZ914BOghYBV8tP8fYg==", "E820ABE6-2DB6-4322-84CE-168626EB2E2D" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f81cb97f-c170-46c0-8657-4f00b8093cc5", "AQAAAAEAACcQAAAAEMd8yRyPGVPRWzOAC0mYtMi2CPtZ7TDzN0HVRD/5hQud4AquCo4zv3LKDNjt9D/ViQ==", "7E176335-85DC-42F4-B905-B59C1FDFCF37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1718aa3e-7545-4e01-9a55-0c9070c6bf50", "AQAAAAEAACcQAAAAEHjY842lYix55z1AwWd6aIlybGqeulhLKhbqVQ3ABuZWTMleKRNrV5C//rNxizY5sA==", "D4007C6A-3086-4D63-8DF1-7F0D20D8EBA7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0241aa9b-67d6-49ca-a6ea-e743d879b196", "AQAAAAEAACcQAAAAEFkgWReAqNB/y1WZXu1odveF8YvO49WC0FhJW2fcPaXBgEvg32Q5CPv8BpVk1MUyww==", "D9B6990B-0738-41B2-AB5F-AFAE147C4205" });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"), "Sofia, Bulgaria", "Petar", "Ivanov", new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d") },
                    { new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"), "Stara Zagora, Bulgaria", "Georgi", "Petrov", new Guid("4aa8654e-1465-4839-814c-a62a69d532e9") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("63281334-434e-4327-b1b7-84b32a9d3d82"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6c32c37-f255-48d9-bb1a-a6cfd1a09260", "AQAAAAEAACcQAAAAEEePCVzlhcog4yY9S0yWQYmirzjD8M43c1q47vWVC5k8gF4r5YIRMe6WrAUU+5s1qA==", "A20C4557-2853-4C95-A67A-CE66263589FE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f19e14c7-b590-4098-a604-42f3adb8e515", "AQAAAAEAACcQAAAAEDfRzzVu7zJ3mtcl+NOWDkBgACAMQGUgRvXOxkGQs/02touD0SZ+O6If12KrKesDIA==", "87928E55-D154-46D7-8AAB-75A6DAC1FC60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8f58fda-2bc6-46cf-b02a-5d3596705125", "AQAAAAEAACcQAAAAEKDwzTP6rbcwUPkDDnClwXBhNuzgqV8aP4fBAwnKkho9qU77zequbp9WQVu8uUumig==", "96246022-EEF3-4441-A259-F84E93DF6B7E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fb201e5-aef2-4537-8eab-e2dbdc7fa34e", "AQAAAAEAACcQAAAAEHrBxwTiHx5VzDECLrzGzbHFMqihPH6tqIAsZRHLPlSZNaxnmqnzc9EbiFop5CSF+g==", "E06B1C21-EA78-46B0-8144-44E8BCFADE0B" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aacdd70-d711-4875-9ed8-5c8aaf0c8d22", "AQAAAAEAACcQAAAAEDjwZU01P7/qJpprkcybC5jjvc3UpLjLWuSczuyjCiZ8mv7817CbE0TkMuwMuvus+w==", "C6D0EA9C-0F96-44CC-9767-1BD143736612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c54cbf6-e3e1-4f1f-b722-cf830d2befc6", "AQAAAAEAACcQAAAAEEv3dt+pB7yImBaGMU4SPHLKayn+C1g7FSFEa8bxuVT/mhib5ewCzeeumn72DPi6ag==", "C424F191-08F0-4384-8639-D23C17F40DBF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be82ac1f-5bd5-447a-9bf5-ae99cfdd9aa3", "AQAAAAEAACcQAAAAEKwMerqJrrsvamPBJLaIcKhnF+WKqOukv8URlFbQZOe/jhenBfGGWxIIqtoTN7qfHA==", "5E3D04EB-9216-4A58-A8DD-140CBE95D20B" });
        }
    }
}
