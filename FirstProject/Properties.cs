using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    class PropertiesDemo
    {   
        // This variable has to accessible to other classes
        double SecretKey = 245.17;  // If we set it public it will be accesible but can be changed as well

        // Underscore is needed if we are using a property to get and set

        double _SecretKey2 = 245.17;

        // defining methods to get and edit value of SecretKey

        public void SetSecretKey(double value)
        {
            SecretKey = value;
        }

        public double GetSecretKey()
        {
            return SecretKey;
        }

        // Lets make property which will combine above separate functions

        //public property To get field _SecretKey1

        public double SecretKey1Property
        {
            get { return _SecretKey2; }
            set {

                if (_SecretKey2 != value) { _SecretKey2 = value; }
                // This value is implicitly declared in run time.
            
            }


            // IF there are not coditions We can also write as follows. minimally

            // get;set;

        }

    }

     class PropertiesDemo1 
    {
        static void Main()
        {
            // Creating a instance of properties demo and access the secret key;
            PropertiesDemo pd = new PropertiesDemo();

            // pd.SecretKey = 21;    This values is not accessible since secretkey in private. So we use the defined methods.

            Console.WriteLine("Secret key defined in one class viewed inside other class " + pd.GetSecretKey());

            pd.SetSecretKey(10);

            Console.WriteLine("Secret key set in other class " + pd.GetSecretKey());

            // Instead of writint separate methods We can make a Property with both get and set fields instead of making
            // two separate properties

            Console.WriteLine("Getting secretKey 2  " + pd.SecretKey1Property);

            // Setting secret key 2
            pd.SecretKey1Property = 10;
            Console.WriteLine("Gettig Secret key again after setting  " + pd.SecretKey1Property);

        }
    }
}
