using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    class Customer
    {
        int _CustId;
        string _CName;
        bool _IsActive;
        double _Balance;
        // The underscores are used to let the reader know that these variables have properties to set them

        // One of the advantages of properties is we can conditionllay assign them values

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

        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
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



        public  Customer(int CustId, string CName, bool IsActive,double Balance)
        { 
            this._CustId = CustId;
            this._Balance = Balance; 
            this._CName = CName;
            this._IsActive = IsActive;
            
        }
            
    }
    

    internal class Properties2
    {
        static void Main()
        {
            Customer C = new Customer(1, "Yohan", true, 10000);

            Console.WriteLine("Customer Name " + C.CName);

            Console.WriteLine("Changing name to Yohan Blake using property");

            C.CName = "Yohan Blake";

            Console.WriteLine("Customer new name is " + C.CName);

            Console.WriteLine("Chagning User name to Yohan Bake to not active so change name not possible");

            C.IsActive = false;

            C.CName = "Bolt";


        }
       
        

    }
}
