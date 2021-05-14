using System;
using DotNet_Core_with_Entity_Framework_Core_With_MySql.Models.DBModels;

namespace MYSQL_and_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var context = new personeContext())
            {

                // To create the new entry in DataBase

                //var Emp = new Employee()
                //{
                //    //Idemployee = 5,
                //    FirstName = "Bill 1",
                //    LastName = "Gate",
                //    Age = 23
                //};
                //context.Employees.Add(Emp);
                //context.SaveChanges();

                foreach (var emp in context.Employees)
                {
                    Console.WriteLine("{0} | {1}", emp.FirstName, emp.LastName);
                }

                Console.ReadKey();
            }
        }
    }
}
