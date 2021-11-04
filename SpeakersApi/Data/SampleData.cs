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
                    ID = 1,
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
                    ID = 2,
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
                    ID = 3,
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
                    ID = 4,
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
                    ID = 5,
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
                    ID = 6,
                    FirstName = "",
                    LastName = "",
                    Email = "",
                    MobileNumber = "",
                    Specialization = "",
                    City = "",
                    Province = "",
                    Employer = ""
                },
                new Speaker() {
                    ID = 7,
                    FirstName = "",
                    LastName = "",
                    Email = "",
                    MobileNumber = "",
                    Specialization = "",
                    City = "",
                    Province = "",
                    Employer = ""
                },
                new Speaker() {
                    ID = 8,
                    FirstName = "",
                    LastName = "",
                    Email = "",
                    MobileNumber = "",
                    Specialization = "",
                    City = "",
                    Province = "",
                    Employer = ""
                },
                new Speaker() {
                    ID = 9,
                    FirstName = "",
                    LastName = "",
                    Email = "",
                    MobileNumber = "",
                    Specialization = "",
                    City = "",
                    Province = "",
                    Employer = ""
                },
            };

            return speakers;
        }
    }
}