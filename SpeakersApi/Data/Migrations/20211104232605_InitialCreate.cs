using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakersApi.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Speaker",
                columns: new[] { "ID", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province", "Specialization" },
                values: new object[,]
                {
                    { "e42ccd67-5b62-40ba-9304-52c84b8d7485", "Chilliwack", "jim@potter.com", "BC Hydro", "Jim", "Potter", "778-123-4567", "BC", "Cloud Architect" },
                    { "ceb347c4-5d8a-43e1-9289-c48319ddf777", "Kelowna", "jane@douglas.com", "Kelowna Company", "Jane", "Douglas", "778-234-5678", "BC", "Frontend Developer" },
                    { "7a903755-9953-4d2a-bc8d-8c86d66fed33", "Toronto", "tom@gardner.com", "University of Toronto", "Tom", "Gardner", "778-345-6789", "ON", "Backend Developer" },
                    { "7ab83788-559e-4f13-a3af-6ac84da0335f", "Edmonton", "ann@lee.com", "Edmonton Company", "Ann", "Lee", "778-456-7890", "AB", "Data Analyst" },
                    { "af9e771c-9165-4a21-a4c6-9aa10dd0994e", "Saskatoon", "james@jones.com", "Saskatoon Public Library", "James", "Jones", "778-567-8901", "SK", "Automation Engineer" },
                    { "a83399cc-0ff1-49c0-b2b0-d4d133e67117", "Montreal", "susan@taylor.com", "Quebec Power Company", "Susan", "Taylor", "778-678-9012", "QC", "Database Administrator" },
                    { "14f677c1-4223-4e5d-9ea2-ebff1047dec7", "Vancouver", "peter@white.com", "BCIT", "Peter", "White", "778-789-0123", "BC", "Programmer" },
                    { "668e2221-b913-42a9-9752-1de110df41df", "Vancouver", "philip@fox.com", "BCIT", "Philip", "Fox", "778-789-0123", "BC", "Programmer" },
                    { "6487f845-2d16-481f-9675-5b7209488c89", "Vancouver", "donna@ray.com", "BCIT", "Donna", "Ray", "778-789-0123", "bC", "Programmer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");
        }
    }
}
