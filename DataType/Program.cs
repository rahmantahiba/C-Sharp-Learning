using System; 

namespace DataType
{
    class Program 

    {
        static void Main(string[] args) 
        {
            //basic type variables
            int i = 10;
            float f = 2.0f; 
            decimal d = 10.0m; 
            bool b = true; 
            char c = 'c'; 
            string str = "A string"; 

            //Implicit variables 
            var x = 10; 
            var z = "Hello!"; 

            //Making an array 
            int[] vals = new int[5]; 
            string[] strs = {"one", "two", "three"}; //array of string so [] needed

            //Printing 
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", i, c, b, str, f, d, x, z); //expecting strig so array is in ""

            //printing null means "no value"
            object obj = null; 
            Console.WriteLine(obj); 

            //implicit conversion between types 
            long bignum; //declaring type bignum variable is long
            bignum = 1; 

            //explicit conversions (Typecasting similar to Java and Python)
            float i_to_f = (float)i; 
            Console.WriteLine("{0}", i_to_f); 
            int f_to_i = (int)f; 
            Console.WriteLine("{0}", f_to_i); 

        }
    }
}
