using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolFoodStamps.Data.Migrations
{
    public partial class SeedCateringCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"), 0, "d6c32c37-f255-48d9-bb1a-a6cfd1a09260", "gosho@yahoo.com", false, false, null, "GOSHO@YAHOO.COM", "GOSHO@YAHOO.COM", "AQAAAAEAACcQAAAAEEePCVzlhcog4yY9S0yWQYmirzjD8M43c1q47vWVC5k8gF4r5YIRMe6WrAUU+5s1qA==", null, false, "A20C4557-2853-4C95-A67A-CE66263589FE", false, "gosho@yahoo.com" },
                    { new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"), 0, "f19e14c7-b590-4098-a604-42f3adb8e515", "patriarh.evtimi@abv.bg", false, false, null, "PATRIARH.EVTIMI@ABV.BG", "PATRIARH.EVTIMI@ABV.BG", "AQAAAAEAACcQAAAAEDfRzzVu7zJ3mtcl+NOWDkBgACAMQGUgRvXOxkGQs/02touD0SZ+O6If12KrKesDIA==", null, false, "87928E55-D154-46D7-8AAB-75A6DAC1FC60", false, "patriarh.evtimi@abv.bg" },
                    { new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"), 0, "c8f58fda-2bc6-46cf-b02a-5d3596705125", "pesho@abv.bg", false, false, null, "PESHO@ABV.BG", "PESHO@ABV.BG", "AQAAAAEAACcQAAAAEKDwzTP6rbcwUPkDDnClwXBhNuzgqV8aP4fBAwnKkho9qU77zequbp9WQVu8uUumig==", null, false, "96246022-EEF3-4441-A259-F84E93DF6B7E", false, "pesho@abv.bg" },
                    { new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"), 0, "2fb201e5-aef2-4537-8eab-e2dbdc7fa34e", "dimitrichko_admin@org.bg", false, false, null, "DIMITRICHKO_ADMIN@ORG.BG", "DIMITRICHKO_ADMIN@ORG.BG", "AQAAAAEAACcQAAAAEHrBxwTiHx5VzDECLrzGzbHFMqihPH6tqIAsZRHLPlSZNaxnmqnzc9EbiFop5CSF+g==", null, false, "E06B1C21-EA78-46B0-8144-44E8BCFADE0B", false, "dimitrichko_admin@org.bg" },
                    { new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"), 0, "1aacdd70-d711-4875-9ed8-5c8aaf0c8d22", "hristo.botev@abv.bg", false, false, null, "HRISTO.BOTEV@ABV.BG", "HRISTO.BOTEV@ABV.BG", "AQAAAAEAACcQAAAAEDjwZU01P7/qJpprkcybC5jjvc3UpLjLWuSczuyjCiZ8mv7817CbE0TkMuwMuvus+w==", null, false, "C6D0EA9C-0F96-44CC-9767-1BD143736612", false, "hristo.botev@abv.bg" },
                    { new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"), 0, "7c54cbf6-e3e1-4f1f-b722-cf830d2befc6", "pesho@yahoo.com", false, false, null, "PESHO@YAHOO.COM", "PESHO@YAHOO.COM", "AQAAAAEAACcQAAAAEEv3dt+pB7yImBaGMU4SPHLKayn+C1g7FSFEa8bxuVT/mhib5ewCzeeumn72DPi6ag==", null, false, "C424F191-08F0-4384-8639-D23C17F40DBF", false, "pesho@yahoo.com" },
                    { new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"), 0, "be82ac1f-5bd5-447a-9bf5-ae99cfdd9aa3", "test@test.bg", false, false, null, "TEST@TEST.BG", "TEST@TEST.BG", "AQAAAAEAACcQAAAAEKwMerqJrrsvamPBJLaIcKhnF+WKqOukv8URlFbQZOe/jhenBfGGWxIIqtoTN7qfHA==", null, false, "5E3D04EB-9216-4A58-A8DD-140CBE95D20B", false, "test@test.bg" }
                });

            migrationBuilder.InsertData(
                table: "CateringCompanies",
                columns: new[] { "Id", "Address", "IdentificationNumber", "Name", "UserId" },
                values: new object[] { new Guid("8e91e660-535c-4f3a-b2fb-cc4e28682345"), null, "121756889", "HealtyFoodForChildren", new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5") });

            migrationBuilder.InsertData(
                table: "CateringCompanies",
                columns: new[] { "Id", "Address", "IdentificationNumber", "Name", "UserId" },
                values: new object[] { new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"), null, "121756888", "ET SAM-DPD", new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4aa8654e-1465-4839-814c-a62a69d532e9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a40a6c8-b237-4c18-8272-4c8d21c4b5d0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae67adef-86a9-4c12-affb-457f91a3ee8e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d35e9b04-d31b-40f6-8d0d-da225a969421"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4e56355-18ae-42a7-b082-25a2cf382d3d"));

            migrationBuilder.DeleteData(
                table: "CateringCompanies",
                keyColumn: "Id",
                keyValue: new Guid("8e91e660-535c-4f3a-b2fb-cc4e28682345"));

            migrationBuilder.DeleteData(
                table: "CateringCompanies",
                keyColumn: "Id",
                keyValue: new Guid("efd31b6c-2a3c-4989-824f-2387c9951234"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97c32df3-7a02-49a9-871b-0b27c4c37cb5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fec4e958-bf56-4247-a6c8-51fae40d852d"));
        }
    }
}
