using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    // This is the class whose instances we have to sort but cannot use IComparable because class modification is not allowed
    class Teachers
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Salary { get; set; }
    }

    // make a new class inherit from IComparer then define compare method

    class CompareTeachersSalaryClass : IComparer<Teachers>
    {
        public int Compare(Teachers? x, Teachers? y)
        {
            if(x.Salary > y.Salary) { return 1; }
            else if(x.Salary < y.Salary) { return -1; }
            else { return 0; }
            
        }
    }

    internal class Collections3IComparer
        {      
            public static void Main()
            {
                // Creating instances of Teachers

                Teachers t1 = new Teachers { Name="Asma",Class="10th",Salary=40000 };
                Teachers t2 = new Teachers { Name = "Mina", Class = "12th", Salary = 10000 };
                Teachers t3 = new Teachers { Name = "Neha", Class="9th", Salary = 90000 };

                //Adding The Teachers instances to a list and then trying to sort them using their Salary

                List<Teachers> Staff = new List<Teachers>() { t1,t2,t3};

            // Creating instance of IComparer method

            CompareTeachersSalaryClass CompareTeacherSalary = new CompareTeachersSalaryClass();
            // Use this above method in sort below;

            Staff.Sort(CompareTeacherSalary);
            Staff.Reverse(); // Reverse sort to get descending order


                foreach(Teachers member in Staff)
                {
                    Console.WriteLine(member.Name + " " + member.Salary);
                }
            }

        }
    
}
