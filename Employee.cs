using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_004
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StaffId { get; set; }
        public ICollection<string> ProLanguages { get; set; }
        public ICollection<string> WorldLanguages { get; set; }
        
        public override int GetHashCode() => FirstName.GetHashCode();

        public override bool Equals(object? obj)
        {
            if (obj is Employee employee) return FirstName == employee.FirstName;
            return false;
        }

        public static ICollection<Employee> GetAllEmployees()
        {
            ICollection<Employee> list = new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Abror",
                    LastName = "Atxamov",
                    StaffId = 1,
                    ProLanguages = new List<string> { "C", "C++", "Java", "SQL" },
                    WorldLanguages = new List<string> { "English", "Russian", "Arabic" }
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Sevara",
                    LastName = "Karimova",
                    StaffId = 1,
                    ProLanguages = new List<string> { "Python", "C++", "C#" },
                    WorldLanguages = new List<string> { "Russian", "Uzbek", "German" }
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Atxam",
                    LastName = "Goibnazarov",
                    StaffId = 2,
                    ProLanguages = new List<string> { "C++", "JavaScript", "PHP" },
                    WorldLanguages = new List<string> { "English", "Spanish" }
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Karim",
                    LastName = "Latipov",
                    StaffId = 3,
                    ProLanguages = new List<string> { "C", "Python", "JavaScript", "Rust" },
                    WorldLanguages = new List<string> { "Korean", "Russian" }
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Xasan",
                    LastName = "Qaxxorov",
                    StaffId = 3,
                    ProLanguages = new List<string> { "C", "C#", "SQL" },
                    WorldLanguages = new List<string> { "German", "Spanish" }
                }
            };
            return list;
        }
    }
}
