using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpeakersApi.Models;

namespace SpeakersApi.Data
{
    public class SampleData
    {
        public static List<Speaker> GetSpeakers() {
            List<Speaker> speakers = new List<Speaker>() {
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Jim",
                    LastName = "Potter",
                    Email = "jim@potter.com",
                    MobileNumber = "778-123-4567",
                    Specialization = "Cloud Architect",
                    City = "Chilliwack",
                    Province = "BC",
                    Employer = "BC Hydro"
                },
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Jane",
                    LastName = "Douglas",
                    Email = "jane@douglas.com",
                    MobileNumber = "778-234-5678",
                    Specialization = "Frontend Developer",
                    City = "Kelowna",
                    Province = "BC",
                    Employer = "Kelowna Company"
                },
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Tom",
                    LastName = "Gardner",
                    Email = "tom@gardner.com",
                    MobileNumber = "778-345-6789",
                    Specialization = "Backend Developer",
                    City = "Toronto",
                    Province = "ON",
                    Employer = "University of Toronto"
                },
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Ann",
                    LastName = "Lee",
                    Email = "ann@lee.com",
                    MobileNumber = "778-456-7890",
                    Specialization = "Data Analyst",
                    City = "Edmonton",
                    Province = "AB",
                    Employer = "Edmonton Company"
                },
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "James",
                    LastName = "Jones",
                    Email = "james@jones.com",
                    MobileNumber = "778-567-8901",
                    Specialization = "Automation Engineer",
                    City = "Saskatoon",
                    Province = "SK",
                    Employer = "Saskatoon Public Library"
                },
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Susan",
                    LastName = "Taylor",
                    Email = "susan@taylor.com",
                    MobileNumber = "778-678-9012",
                    Specialization = "Database Administrator",
                    City = "Montreal",
                    Province = "QC",
                    Employer = "Quebec Power Company"
                },
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Peter",
                    LastName = "White",
                    Email = "peter@white.com",
                    MobileNumber = "778-789-0123",
                    Specialization = "Programmer",
                    City = "Vancouver",
                    Province = "BC",
                    Employer = "BCIT"
                },
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Philip",
                    LastName = "Fox",
                    Email = "philip@fox.com",
                    MobileNumber = "778-789-0123",
                    Specialization = "Programmer",
                    City = "Vancouver",
                    Province = "BC",
                    Employer = "BCIT"
                },
                new Speaker() {
                    ID = Guid.NewGuid().ToString(),
                    FirstName = "Donna",
                    LastName = "Ray",
                    Email = "donna@ray.com",
                    MobileNumber = "778-789-0123",
                    Specialization = "Programmer",
                    City = "Vancouver",
                    Province = "bC",
                    Employer = "BCIT"
                },
            };

            return speakers;
        }
    }
}