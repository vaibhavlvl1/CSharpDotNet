using System;
using System.Collections.Generic;
using System.Text;

namespace IndexersDemoProject
{
    internal class Employee
    {
        int Id;
        string Name, Address, City, Designation;
        double Salary;

        public Employee(int Id,string Name,string Address,string City,string Designation,double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.City = City;
            this.Designation = Designation;
            this.Salary = Salary;
        }

        // Now defining the indexer for Employee class to set and get

        // We can also use string name instead of int index; just make sure to use ToLower ot upper
        // as string name will be case sensitive

        public object this[int index]
        {   

            //to get value
            get
            {
                if (index == 0)
                {
                    return Id;
                }
                else if (index == 1)
                {
                    return Name;
                }
                else if (index == 2)
                {
                    return Address;
                }
                else if (index == 3)
                {
                    return City;
                }
                else if (index == 4)
                {
                    return Designation;
                }

                else if (index == 5)
                {
                    return Salary;
                }

                return null;
            }


            //to set value
            set
            {
                if (index == 0)
                {
                    Id = (int)value;
                }
                else if (index == 1)
                {
                    Name = (string)value;
                }
                else if (index == 2)
                {
                    Address = (string)value;
                }

                else if (index == 3)
                {
                    City = (string)value;
                }
                else if (index == 4)
                {
                    Designation = (string)value;
                }
                else if(index == 5)
                {
                    Salary = (int)value;
                }

            }
        }
    }
}
