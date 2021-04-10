using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new List<Employee>
            {
              new Employee { Name = "K.A.H", Gender = "M", Age = 22, Salary = 75000, City = "Isb"},
              new Employee { Name = "Sara", Gender = "F", Age = 25, Salary = 75000, City = "Isb"},
              new Employee { Name = "Khalid", Gender = "M", Age = 26, Salary = 33000, City = "Multan"},
              new Employee { Name = "Zara", Gender = "F", Age = 32, Salary = 55000, City = "Rwp"},
              new Employee { Name = "Junaid", Gender = "M", Age =26, Salary = 72000, City = "Multan"},
              new Employee { Name = "Sana", Gender = "F", Age = 22, Salary = 50000, City = "Rwp"},
              new Employee { Name = "Faisal", Gender = "M", Age =27, Salary = 75000, City = "Multan"},
              new Employee { Name = "Rimsha", Gender = "F", Age = 29, Salary =750000, City = "Rwp"},

            };

            // task_2
            Console.WriteLine("Order by City then gender then Name");
            var q1 = emp.OrderBy(e => e.City).ThenBy(e => e.Gender).ThenBy(e => e.Name);
            foreach (var e in q1) {
                Console.WriteLine(e);
            }


           
            var ans = emp.Max(e => e.Salary);
            Console.WriteLine("\nMax Salary:{0}", ans);

            // task_3
            Console.WriteLine("\nOrder by City(Multan and Rwp) and salary = max");
            var q3 = emp.Where(e => e.City == "Multan" && e.Salary == ans || e.City == "Rwp" && e.Salary == ans);
            foreach (var e in q3)
            {
                Console.WriteLine(e);
            }

            // task_4
            Console.WriteLine("\n Total Salary for Multan City");
            var q4 = emp.OrderBy(e => e.City == "Multan").Sum(e => e.Salary);

            Console.WriteLine(q4);

            // task_5
            var q5 = emp.Sum(e => e.Age);
            Console.WriteLine("\n SUM BASED on age");
            Console.WriteLine(q5);

            var q6 = emp.Count(e => e.Age == 22);
            Console.WriteLine("\n Count BASED on age");
            Console.WriteLine(q6);

            var q7 = emp.Average(e => e.Age);
            Console.WriteLine("\n Average BASED on age");
            Console.WriteLine(q7);

            var q8 = emp.Min(e => e.Age);
            Console.WriteLine("\n MIN BASED on age");
            Console.WriteLine(q8);

            var q9 = emp.Average(e => e.Age);
            Console.WriteLine("\n MAX BASED on age");
            Console.WriteLine(q9);


            Console.ReadKey();
        }
    }
}
