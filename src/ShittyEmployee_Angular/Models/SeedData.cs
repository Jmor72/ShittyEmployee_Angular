using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShittyEmployee_Angular.Models;

namespace ShittyEmployee_Angular.Models
{
   public static void Initialize(EmployeeContext db)
   {
       if (!db.Employees.Any())
       {
           db.Employees.Add(new Employee
           {
               Id = 2,
               Name = "Employee 2",
               Department = "Engineering",
               Supervisor = "supervisor 2",
               Salary = 36789,
               Address = "1234 Fake St.",
               Employed = 12

               //If you wanted to do a Start Date
               //StartDate = Convert.ToDateTime("2015/09/09")
           });


           db.SaveChanges();
       }
   }
}