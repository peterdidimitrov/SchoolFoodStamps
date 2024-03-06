using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class SeedSchools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cba1c66-e389-44b6-a39b-40eda113d618", "AQAAAAEAACcQAAAAECpJJOBIhmHdlQCMuXAoNMPv1/a8fnmUk+EBY5uXVx+Hrixznp+H2LH0JNboN9QKEw==", "BC191C60-32CB-4F1A-8345-DB80A98E0A6A" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8e42e26-5ba0-4af0-bbc5-9d08b84fee84", "AQAAAAEAACcQAAAAEHANC9lABRbMale/aL6GA66yBkOWc7gcei8fMcgiUkopPdnWZekz5NlSII5AIs1Pqw==", "953A35F9-C4BE-4383-A2D7-110B94FE25E7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04d72e2e-a006-434b-937f-678a23e80109", "AQAAAAEAACcQAAAAEMxEPpx3RiSYPkDB/nP/UwQfXNlHjz1e16fww8KVh43izsfh8Z5HPBxy8klK2mvpJw==", "7C6CB1A5-3189-4EE6-86B2-2DE1D4961B48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "951bcee4-2b14-4af3-b23b-429eb3e0ce17", "AQAAAAEAACcQAAAAEJlHCy0Us+zTHvKKcAjYCJyfFFFVO+dAeyZgMjMTdkrcEXayX8pKcBEyw+iPBnx7IQ==", "BADB1BD2-1676-42C9-B4D3-BD94928C3001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "312b9340-20a0-4d72-b070-05b788d25f2f", "AQAAAAEAACcQAAAAEH41R2lhAMK61D1UPczySFF7HSl1rVakY1HUFctOo6/C6bLwhcA8ETt0k5Ya7olf9g==", "CA1B9155-38C4-4280-81A1-830E216B04FB" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4ffdf16-8c0f-4118-90ae-829f2341e31c", "AQAAAAEAACcQAAAAEPoD2uSZ+cik53tg7MmEUo8Z8jpnC/pUGnJt8enfrK8krT6xRSOnEbwMMJvvVZlL/g==", "29740100-490F-4604-92D7-FB309B00AEC5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12db5774-014b-4dcb-af67-d76240c4648d", "AQAAAAEAACcQAAAAEK5lwrRyFztETjQpN5jFb+G12xjVIviW7u1JLZAdtbC8Wl+m5xCvnPipgFfWr5I6dA==", "0A7C632D-2448-4F9C-9445-9DE17E583342" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CateringCompanyId", "IdentificationNumber", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("6cd00c11-b0cb-428a-9143-df5743105a92"), "bul. Al. Stamboliiski 33", new Guid("8e91e660-535c-4f3a-b2fb-cc4e28682345"), "121756787", "51 SOU Hristo  Botev", new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421") },
                    { new Guid("e3af4b8e-8f07-4962-838e-670bd305758f"), "bul. Hristo Botev 41", new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), "121756886", "41 OU Patriarh Evtimii", new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("6cd00c11-b0cb-428a-9143-df5743105a92"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("e3af4b8e-8f07-4962-838e-670bd305758f"));

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
        }
    }
}
