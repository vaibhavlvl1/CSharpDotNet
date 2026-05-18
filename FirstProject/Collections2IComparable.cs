using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Marks { get; set; }


        // this is compareing method autoatically generated when ICamparable clicked on above line.
        // You have to implement If else if  else as follows to quash error.
        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
            {
                return 1;
            }
            else if (this.Sid < other.Sid)
            {
                return -1;
            }
            else return 0;
            
        }
    }

    public class CollectionsIComparable
    {
        public static void Main()
        {
            // Make a custom list of students
            Student s1 = new Student { Sid=5,Name="Vaibhav",Class="Royal",Marks=95};
            Student s2 = new Student { Sid=3,Name="Priya",Class="Gold",Marks=88};
            Student s3 = new Student { Sid=1,Name="Rajesh",Class="Silver",Marks=92};
            Student s4 = new Student { Sid=4,Name="Anjali",Class="Royal",Marks=85};
            Student s5 = new Student { Sid=6,Name="Amit",Class="Gold",Marks=78};
            Student s6 = new Student { Sid=2,Name="Sneha",Class="Silver",Marks=90};


            List<Student> Students = new List<Student>() {s1,s2,s3,s4,s5,s6};

            //Students.Sort();// The sorting wont work because it wont know where to compare on sid or class or name

            // Hence we use IComparable in the class used to make list here it is Student and make a compare function 

            // After adding IComparable and CompareTo method then Students.Sort() will work
            Students.Sort();
            // Now student list will be sorted according to Sid

            // We can also use

            Students.Reverse();

            foreach (Student item in Students) {
                Console.WriteLine(item.Name+" "+item.Sid);
            }

        }
    }
}
