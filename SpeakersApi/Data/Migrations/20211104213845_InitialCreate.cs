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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    { 1, "Chilliwack", "jim@potter.com", "BC Hydro", "Jim", "Potter", "778-123-4567", "BC", "Cloud Architect" },
                    { 2, "Kelowna", "jane@douglas.com", "Kelowna Company", "Jane", "Douglas", "778-234-5678", "BC", "Frontend Developer" },
                    { 3, "Toronto", "tom@gardner.com", "University of Toronto", "Tom", "Gardner", "778-345-6789", "ON", "Backend Developer" },
                    { 4, "Edmonton", "ann@lee.com", "Edmonton Company", "Ann", "Lee", "778-456-7890", "AB", "Data Analyst" },
                    { 5, "Saskatoon", "james@jones.com", "Saskatoon Public Library", "James", "Jones", "778-567-8901", "SK", "Automation Engineer" },
                    { 6, "Montreal", "susan@taylor.com", "Quebec Power Company", "Susan", "Taylor", "778-678-9012", "QC", "Database Administrator" },
                    { 7, "Vancouver", "peter@white.com", "BCIT", "Peter", "White", "778-789-0123", "BC", "Programmer" },
                    { 8, "Vancouver", "philip@fox.com", "BCIT", "Philip", "Fox", "778-789-0123", "BC", "Programmer" },
                    { 9, "Vancouver", "donna@ray.com", "BCIT", "Donna", "Ray", "778-789-0123", "bC", "Programmer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");
        }
    }
}
