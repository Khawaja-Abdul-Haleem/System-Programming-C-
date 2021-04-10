using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ
{
    // Multi-Attribute DataType
    // Student - A User-Defined Class
    // Object Class of C# is Parent of Student ByDefault
    class Student { 
        public string AridNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public float CGPA { get; set; }
        public char Gender { get; set; }
        public string Disclipline { get; set; }

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5},{6}", AridNo, FirstName, LastName, Age, CGPA, Gender, Disclipline);
        }
    }// class ended bracket


    class Program
    {
        static void Main(string[] args)
        {
            ApplyAggregates();
            ApplyWhere();
            ApplyOrderBy();
            ApplyMultipleOrderBy();
            Console.ReadKey();
        }

        static void ApplyAggregates() {

            var Std = new List<Student>
            {
                new Student {AridNo = "18-Arid-0121", FirstName = "Ayesha", LastName = "Faisal", Age = 21, CGPA = 3.1F, Gender = 'F', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-0092", FirstName = "Khawaja", LastName = " Abdul Haleem", Age = 22, CGPA = 3.56F, Gender = 'M', Disclipline = ""},
                new Student {AridNo = "18-Arid-2110", FirstName = "Zainia", LastName = "Kamran", Age = 24, CGPA = 2.11F, Gender = 'M', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-0112", FirstName = "Fuzail", LastName = "Raza", Age = 24, CGPA = 3.32F, Gender = 'M', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-2120", FirstName = "Saira", LastName = "Bibi", Age = 21, CGPA = 2.80F, Gender = 'F', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-1231", FirstName = "Kaleem", LastName = "Shah", Age = 23, CGPA = 2.93F, Gender = 'M', Disclipline = "BsCS"},
                new Student {AridNo = "18-Arid-0093", FirstName = "Aqsa", LastName = "Ejaz", Age = 25, CGPA = 3.67F, Gender = 'F', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-0066", FirstName = "Zeeshan", LastName = "Zaheer", Age = 26, CGPA = 3.32F, Gender = 'M', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-1450", FirstName = "Junaid", LastName = "Khan", Age = 23, CGPA = 2.21F, Gender = 'M', Disclipline = "MCS"}
            };


            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*\t\t\tAggregate Functions\t\t\t*");
            Console.WriteLine("*****************************************************************");

            // 1.1 SQL Query - Select count(*) from Students
            // LINQ Method Count
            var total_students = Std.Count();
            Console.WriteLine("Total Students: {0}", total_students);
            
            var max_cgpa = Std.Max(s => s.CGPA);
            Console.WriteLine("MAX Cgpa: {0}", max_cgpa);

            var min_cgpa = Std.Min(s => s.CGPA);
            Console.WriteLine("Min CGPA: {0}", min_cgpa);

            var sum_students = Std.Sum(s => s.CGPA);
            Console.WriteLine("Sum Of ALL Student's CGPA: {0}", sum_students);

            var avg_cgpa = Std.Average(s => s.CGPA);
            Console.WriteLine("Average CGPA: {0}", avg_cgpa);
            Console.WriteLine();
        } //  ApplyAggregates() ended Bracket

        static void ApplyWhere() 
        {
            var Std = new List<Student>
            {
                new Student {AridNo = "18-Arid-0121", FirstName = "Ayesha", LastName = "Faisal", Age = 21, CGPA = 3.1F, Gender = 'F', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-0092", FirstName = "Khawaja", LastName = " Abdul Haleem", Age = 22, CGPA = 3.56F, Gender = 'M', Disclipline = ""},
                new Student {AridNo = "18-Arid-2110", FirstName = "Zainia", LastName = "Kamran", Age = 24, CGPA = 2.11F, Gender = 'M', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-0112", FirstName = "Fuzail", LastName = "Raza", Age = 24, CGPA = 3.32F, Gender = 'M', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-2120", FirstName = "Saira", LastName = "Bibi", Age = 21, CGPA = 2.80F, Gender = 'F', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-1231", FirstName = "Kaleem", LastName = "Shah", Age = 23, CGPA = 2.93F, Gender = 'M', Disclipline = "BsCS"},
                new Student {AridNo = "18-Arid-0093", FirstName = "Aqsa", LastName = "Ejaz", Age = 25, CGPA = 3.67F, Gender = 'F', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-0066", FirstName = "Zeeshan", LastName = "Zaheer", Age = 26, CGPA = 3.32F, Gender = 'M', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-1450", FirstName = "Junaid", LastName = "Khan", Age = 23, CGPA = 2.21F, Gender = 'M', Disclipline = "MCS"}
            };
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("\t\t\tApply Where\t\t\t\t*");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine();


            // 2.1 SQL-Query - Select * from Student where Gender = 'M'
            Console.WriteLine("\t\tALL Male Students\n");
            var male_students = Std.Where(s => s.Gender == 'M');
            // Where Always returns IEnumerable Type - a List Type
            // so we used loop to print
            foreach(var v in male_students)
            {
                Console.WriteLine(v);
            }
            
            Console.WriteLine("\n\t\tALL Female Students\n");
            var female_students = Std.Where(s => s.Gender == 'F');
            // Where Always returns IEnumerable Type - a List Type
            // so we used loop to print
            foreach (var v in female_students)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\t\tALL Female Students & cgpa above 3.0\n");
            var f_std_maxcga = Std.Where(s => s.Gender == 'F' && s.CGPA >= 3.0);
            foreach(var v in f_std_maxcga)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\t\tALL Stuednt Names Start with 'S'\n");
            var start_s = Std.Where(s => s.FirstName.StartsWith("S"));
            foreach(var v in start_s)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();

        }// ApplyWhere Ended Bracket

        static void ApplyOrderBy() 
        {
            var Std = new List<Student>
            {
                new Student {AridNo = "18-Arid-0121", FirstName = "Ayesha", LastName = "Faisal", Age = 21, CGPA = 3.1F, Gender = 'F', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-0092", FirstName = "Khawaja", LastName = " Abdul Haleem", Age = 22, CGPA = 3.56F, Gender = 'M', Disclipline = ""},
                new Student {AridNo = "18-Arid-2110", FirstName = "Zainia", LastName = "Kamran", Age = 24, CGPA = 2.11F, Gender = 'M', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-0112", FirstName = "Fuzail", LastName = "Raza", Age = 24, CGPA = 3.32F, Gender = 'M', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-2120", FirstName = "Saira", LastName = "Bibi", Age = 21, CGPA = 2.80F, Gender = 'F', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-1231", FirstName = "Kaleem", LastName = "Shah", Age = 23, CGPA = 2.93F, Gender = 'M', Disclipline = "BsCS"},
                new Student {AridNo = "18-Arid-0093", FirstName = "Aqsa", LastName = "Ejaz", Age = 25, CGPA = 3.67F, Gender = 'F', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-0066", FirstName = "Zeeshan", LastName = "Zaheer", Age = 26, CGPA = 3.32F, Gender = 'M', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-1450", FirstName = "Junaid", LastName = "Khan", Age = 23, CGPA = 2.21F, Gender = 'M', Disclipline = "MCS"}
            };
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("\t\t\tApplyOrderBY\t\t\t\t*");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine();

            // 3.1 SQL-Query - Select *from Student OrderBy CGPA ASC
            Console.WriteLine("\n\t\tALL Students OrderBy CGPA Asc\n");
            var asc_cgpa = Std.OrderBy(s => s.CGPA);
            foreach(var v in asc_cgpa)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\t\tALL Students OrderBy CGPA DESC\n");
            var desc_cgpa = Std.OrderByDescending(s => s.CGPA);
            foreach (var v in desc_cgpa)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\t\tALL Male Students OrderBy FirstName ASC\n");
            var asc_fname = Std.Where(s => s.Gender == 'M').OrderBy(s => s.FirstName);
            foreach (var v in asc_fname)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();

        }// ApplyOrderBy closing Barcket
        static void ApplyMultipleOrderBy()
        {
            var Std = new List<Student>
            {
                new Student {AridNo = "18-Arid-0121", FirstName = "Ayesha", LastName = "Faisal", Age = 21, CGPA = 3.1F, Gender = 'F', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-0092", FirstName = "Khawaja", LastName = " Abdul Haleem", Age = 22, CGPA = 3.56F, Gender = 'M', Disclipline = ""},
                new Student {AridNo = "18-Arid-2110", FirstName = "Zainia", LastName = "Kamran", Age = 24, CGPA = 2.11F, Gender = 'M', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-0112", FirstName = "Fuzail", LastName = "Raza", Age = 24, CGPA = 3.32F, Gender = 'M', Disclipline = "BsCs"},
                new Student {AridNo = "18-Arid-2120", FirstName = "Saira", LastName = "Bibi", Age = 21, CGPA = 2.80F, Gender = 'F', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-1231", FirstName = "Kaleem", LastName = "Shah", Age = 23, CGPA = 2.93F, Gender = 'M', Disclipline = "BsCS"},
                new Student {AridNo = "18-Arid-0093", FirstName = "Aqsa", LastName = "Ejaz", Age = 25, CGPA = 3.67F, Gender = 'F', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-0066", FirstName = "Zeeshan", LastName = "Zaheer", Age = 26, CGPA = 3.32F, Gender = 'M', Disclipline = "MCS"},
                new Student {AridNo = "18-Arid-1450", FirstName = "Junaid", LastName = "Khan", Age = 23, CGPA = 2.21F, Gender = 'M', Disclipline = "MCS"}
            };

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("\t\t\tApplyMultipleOrderBy\t\t\t*");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine();

            // 4.1 SQL-Query - Select *from Student Orderby FirstName, LastName Asc
            Console.WriteLine("\n\t\tALL Students OrderBy FirstName then Lastname ASC\n");
            var asc_fname_lname = Std.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
            foreach(var v in asc_fname_lname)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\t\tALL Students OrderBy FirstName then Lastname DESC\n");
            var desc_fname_lname = Std.OrderBy(s => s.FirstName).ThenByDescending(s => s.LastName);
            foreach (var v in desc_fname_lname)
            {
                Console.WriteLine(v);
            }
        }// ApplyMultipleOrderBy Closing Bracket

    }
}
