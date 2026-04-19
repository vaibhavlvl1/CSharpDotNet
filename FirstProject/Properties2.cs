using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    // Now declaruing a enum used in bwlow so that properties autocomplete when trying to change
    public enum Cities
    {
        Mumbai, Pune, Bengalaru, Odisha, Kullu, Delhi
    }

    class Customer
    {



        Cities _city;
        int _CustId;
        string _CName;
        bool _IsActive;
        double _Balance;
        // The underscores are used to let the reader know that these variables have properties to set them

        // One of the advantages of properties is we can conditionllay assign them values

        public Cities City
        {
            get { return _city; }
            set { _city = value; }
        }
        

        public int CustId{
            get { return _CustId; }
        }

        public double Balance
        {
            get { return _Balance; }

            set {

                if (_IsActive)
                {
                    _Balance = value;
                    Console.WriteLine("Balance Updated");
                }
                else
                {
                    Console.WriteLine("User Not Active Unable to update balance");
                }
            
            }
        }

        // In below function if you want to view status only without  logging and only admins can set it then 
        // modify methods as follows . Just add a access modifiers to get and set
        public bool IsActive
        {
            // can be viewed anywhere
            get { return _IsActive; }

            //can only be set in child class so this property will be commented in main method. since that is not child class
            protected set { _IsActive = value; }
        }

        public string CName
        {
            get { return _CName; }
            set {

                if (_IsActive) { _CName = value; }


                else {
                    Console.WriteLine("Name cannot be Changed because user inactive");
            }
            } }


        // Now lets define a property which will not set and get any declared variable. but this property will use variable declatred implicilty
        // this wll be country this propertyt will be assigned the entered variable in constructor as below
        // This is auto implemented

        public string Country{
            get;set;
        }


        // There is also a auto property initalizert which whill have specific value set withou needing to be passed in 
        // a constructor or via argumaets example
        //This is auto initializer

        public string Company { get; } = "HTC Global";


        public  Customer(int CustId, string CName, bool IsActive,double Balance,Cities City, String Country)
        { 
            this._CustId = CustId;
            this._Balance = Balance; 
            this._CName = CName;
            this._IsActive = IsActive;
            this._city = City;
            this.Country = Country;  // One is property and other is parameter passed down by constructor
            
        }
            
    }
    

    internal class Properties2
    {
        static void Main()
        {
            Customer C = new Customer(1, "Yohan", true, 10000,Cities.Delhi,"India");

            Console.WriteLine("Customer Name " + C.CName);

            Console.WriteLine("Changing name to Yohan Blake using property");

            C.CName = "Yohan Blake";

            Console.WriteLine("Customer new name is " + C.CName);

            Console.WriteLine("Chagning User name to Yohan Bake to not active so change name not possible");

            //C.IsActive = false; wont work because we set setter function to protected. so it will only waoek in a cild class

            C.CName = "Bolt";

            Console.WriteLine("The default city is " + C.City);

            // We have declared an enum for cities to autocomplete
            C.City = Cities.Mumbai;
            Console.WriteLine("City hhas been changed to " + C.City);

            // Now we will get the property set via auto property initailizer
            Console.WriteLine("This auto initilaized property not passed in constructor or the object" + C.Company);


        }
       
        

    }
}
