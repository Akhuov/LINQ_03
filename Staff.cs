using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_004
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> employees { get; set; }

        public static ICollection<Staff> GetAllStaffs()
        {
            var list = new List<Staff>() 
            {
                new Staff { Id = 1,Name ="Moliya"},
                new Staff { Id = 2,Name ="Uquv bo`lim"},
                new Staff { Id = 3,Name ="Marketing"},
            };
            return list;
        }
    }
}
