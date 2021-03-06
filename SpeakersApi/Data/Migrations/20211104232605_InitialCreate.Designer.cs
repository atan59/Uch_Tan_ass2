// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SpeakersApi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211104232605_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpeakersApi.Models.Speaker", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Speaker");

                    b.HasData(
                        new
                        {
                            ID = "e42ccd67-5b62-40ba-9304-52c84b8d7485",
                            City = "Chilliwack",
                            Email = "jim@potter.com",
                            Employer = "BC Hydro",
                            FirstName = "Jim",
                            LastName = "Potter",
                            MobileNumber = "778-123-4567",
                            Province = "BC",
                            Specialization = "Cloud Architect"
                        },
                        new
                        {
                            ID = "ceb347c4-5d8a-43e1-9289-c48319ddf777",
                            City = "Kelowna",
                            Email = "jane@douglas.com",
                            Employer = "Kelowna Company",
                            FirstName = "Jane",
                            LastName = "Douglas",
                            MobileNumber = "778-234-5678",
                            Province = "BC",
                            Specialization = "Frontend Developer"
                        },
                        new
                        {
                            ID = "7a903755-9953-4d2a-bc8d-8c86d66fed33",
                            City = "Toronto",
                            Email = "tom@gardner.com",
                            Employer = "University of Toronto",
                            FirstName = "Tom",
                            LastName = "Gardner",
                            MobileNumber = "778-345-6789",
                            Province = "ON",
                            Specialization = "Backend Developer"
                        },
                        new
                        {
                            ID = "7ab83788-559e-4f13-a3af-6ac84da0335f",
                            City = "Edmonton",
                            Email = "ann@lee.com",
                            Employer = "Edmonton Company",
                            FirstName = "Ann",
                            LastName = "Lee",
                            MobileNumber = "778-456-7890",
                            Province = "AB",
                            Specialization = "Data Analyst"
                        },
                        new
                        {
                            ID = "af9e771c-9165-4a21-a4c6-9aa10dd0994e",
                            City = "Saskatoon",
                            Email = "james@jones.com",
                            Employer = "Saskatoon Public Library",
                            FirstName = "James",
                            LastName = "Jones",
                            MobileNumber = "778-567-8901",
                            Province = "SK",
                            Specialization = "Automation Engineer"
                        },
                        new
                        {
                            ID = "a83399cc-0ff1-49c0-b2b0-d4d133e67117",
                            City = "Montreal",
                            Email = "susan@taylor.com",
                            Employer = "Quebec Power Company",
                            FirstName = "Susan",
                            LastName = "Taylor",
                            MobileNumber = "778-678-9012",
                            Province = "QC",
                            Specialization = "Database Administrator"
                        },
                        new
                        {
                            ID = "14f677c1-4223-4e5d-9ea2-ebff1047dec7",
                            City = "Vancouver",
                            Email = "peter@white.com",
                            Employer = "BCIT",
                            FirstName = "Peter",
                            LastName = "White",
                            MobileNumber = "778-789-0123",
                            Province = "BC",
                            Specialization = "Programmer"
                        },
                        new
                        {
                            ID = "668e2221-b913-42a9-9752-1de110df41df",
                            City = "Vancouver",
                            Email = "philip@fox.com",
                            Employer = "BCIT",
                            FirstName = "Philip",
                            LastName = "Fox",
                            MobileNumber = "778-789-0123",
                            Province = "BC",
                            Specialization = "Programmer"
                        },
                        new
                        {
                            ID = "6487f845-2d16-481f-9675-5b7209488c89",
                            City = "Vancouver",
                            Email = "donna@ray.com",
                            Employer = "BCIT",
                            FirstName = "Donna",
                            LastName = "Ray",
                            MobileNumber = "778-789-0123",
                            Province = "bC",
                            Specialization = "Programmer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
