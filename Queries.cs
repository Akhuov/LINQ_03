using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LINQ_004
{
    public class Queries
    {
        public static void Run()
        {
            var allEmployees = Employee.GetAllEmployees();
            var allStaffs = Staff.GetAllStaffs();

            //Select &&
            //SelectMany


            //var selectResult = allEmployees.Select(emp => new
            //{
            //    EmployeeId = emp.Id,
            //    EmployeeName = $"{emp.FirstName} {emp.LastName}",
            //    ProLaguages = string.Join(" ",emp.ProLanguages),
            //    WorldLanguages = string.Join(" ",emp.WorldLanguages),

            //}) ;
            //foreach ( var emp in selectResult)
            //{
            //    Console.WriteLine("{0} {1}\nProLanguages=> {2}\nWorldLanguages=> {3}\n\n",emp.EmployeeId,emp.EmployeeName, emp.ProLaguages,emp.WorldLanguages );
            //}


            //var selectManyResult = allEmployees.SelectMany(emp => emp.ProLanguages, (parent, child) => new
            //{
            //    Name = $"{parent.FirstName} {parent.LastName}",
            //    Language = child,
            //});

            //foreach (var emp in selectManyResult)
            //{
            //    Console.WriteLine($"{emp.Name} \nProLanguage=> {emp.Language}\n\n\n");
            //}


            //var selectManyResult = allEmployees.SelectMany(emp => emp.ProLanguages,(parent, child) => new
            //{
            //    Name = $"{parent.FirstName} {parent.LastName}",
            //    Language = child,
            //    WorldLanguages = parent.WorldLanguages,
            //})
            //    .SelectMany(emp => emp.WorldLanguages, (parent, child) => new
            //    {
            //        Name = parent.Name ,
            //        Language = parent.Language,
            //        WorldLanguage = child,
            //    });

            //foreach (var emp in selectManyResult)
            //{
            //    Console.WriteLine($"{emp.Name} => {emp.Language} => {emp.WorldLanguage}");
            //}


            //Any,All,Contains


            





        }
    }
}
