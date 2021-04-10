using System;
using System.Collections.Generic;
using System.Linq;

namespace UserDefine_datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<int>
            {
                1,4,2,3,5
            };
            var emp = new List<Employee> 
            {
              new Employee { Name = "K.A.H", Gender = "M", Age = 22, Salary = 75000},
              new Employee { Name = "Sara", Gender = "F", Age = 25, Salary = 75000},
              new Employee { Name = "Khalid", Gender = "M", Age = 26, Salary = 33000}, 
              new Employee { Name = "Zara", Gender = "F", Age = 32, Salary = 55000},
              new Employee { Name = "Junaid", Gender = "M", Age =26, Salary = 72000},
              new Employee { Name = "Sana", Gender = "F", Age = 22, Salary = 50000},

            };
            // aggregate to user defined datatype
            var ans1 = emp.Max(e => e.Salary);
            Console.WriteLine("Max Salary: {0}", ans1);

            var ans2 = emp.Max(e => e.Age);
            Console.WriteLine("Max Age: {0}", ans2);

            // similarly we can apply all other aggregate functions 
            // like Avg, sum, min, count etc

            // OrderBy , OrderByDescending

            var q = emp.OrderBy(e => e.Name);
            // or
            // IOrderedEnumerable <Employee> q = emp.OrderBy(e => e.Name);
            Console.WriteLine("\nList of Employees on Basis of Name Ascending");

            foreach (var e in q) {
                Console.WriteLine("{0},{1},{2},{3}", e.Name, e.Gender, e.Age, e.Salary);
            }

            var q1 = emp.OrderByDescending(e => e.Name);
            Console.WriteLine("\nList of Employees on Basis of Name Descending");

            foreach (var e in q1)
            {
                Console.WriteLine("{0},{1},{2},{3}", e.Name, e.Gender, e.Age, e.Salary);
            }

            // display male list first
            
            Console.WriteLine("\nList of Employees (MAle First)");

            var q2 = emp.OrderByDescending(e => e.Gender); // M / F
            foreach (var e in q2)
            {
                Console.WriteLine(e);
               // Console.WriteLine("{0},{1},{2},{3}", e.Name, e.Gender, e.Age, e.Salary);
            }
            
            Console.WriteLine("\nList of Employees (MAle First) in ASC");
            var q3 = emp.OrderByDescending(e => e.Gender).ThenBy(e => e.Name); // M / F
            foreach (var e in q3)
            {
                Console.WriteLine(e);
               // Console.WriteLine("{0},{1},{2},{3}", e.Name, e.Gender, e.Age, e.Salary);
            }

            Console.WriteLine("\nList of Employees based on gender, Name");
            var q4 = emp.OrderBy(e => e.Gender).ThenBy(e => e.Name); // M / F
            foreach (var e in q4)
            {
                Console.WriteLine(e);
                // Console.WriteLine("{0},{1},{2},{3}", e.Name, e.Gender, e.Age, e.Salary);
            }

            Console.WriteLine("\nList of Employees based on gender, Name Dec");
            var q5 = emp.OrderBy(e => e.Gender).ThenByDescending(e => e.Name); // M / F
            foreach (var e in q4)
            {
                Console.WriteLine(e);
                // Console.WriteLine("{0},{1},{2},{3}", e.Name, e.Gender, e.Age, e.Salary);
            }

            // now i want to print only female employees from seq
            var q6 = emp.Where(e => e.Gender == "F");
            Console.WriteLine("\nOnly Female Employee");
            Console.WriteLine("List of Employees based on gender, Name");
            foreach (var e in q6)
            {
                Console.WriteLine(e);
                // Console.WriteLine("{0},{1},{2},{3}", e.Name, e.Gender, e.Age, e.Salary);
            }

            // print all employee having age b/w 30 and 40 and salary > 50k

            var q7 = emp.Where(e => e.Age > 30 && e.Age < 40 && e.Salary > 50000);
            Console.WriteLine("\nprint all employee having age b/w 30 and 40 and salary > 50k");
            foreach (var e in q7)
            {
                Console.WriteLine(e);
                // Console.WriteLine("{0},{1},{2},{3}", e.Name, e.Gender, e.Age, e.Salary);
            }

            // want hihest salary emp detail
            // ans1 is highest salary
            var q8 = emp.Where(e => e.Salary == ans1);
            Console.WriteLine("\nHihest salary Detail");
            foreach (var e in q8)
            {
                Console.WriteLine(e);
            }

            // i need only 1 record among highest salary employee list

            var q9 = emp.First(e => e.Salary == ans1);
            Console.WriteLine("\nHihest salary Detail");
                Console.WriteLine(q9);

            var q10 = emp.Where(e => e.Salary == ans1).Select(e => e.Name);
            Console.WriteLine("\nHihest salary Detail (.select) e.name ");
            foreach (var e in q10)
            {
                Console.WriteLine(e);
            }



            Console.ReadKey();
        }
    }
}
