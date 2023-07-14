using System; 

namespace Conditionals 
{
    class Program {
        static void Main(string[] args) {

            //First Method: if statement (True)
            int val = 50; 
            if (val == 50) {
                Console.WriteLine("True"); 
            } else {
                Console.WriteLine("False"); 
            }

            //First Method: if statement (False)
            int value = 51; 
            if (value == 50) {
                Console.WriteLine("True"); 
            } else {
                Console.WriteLine("False"); 
            }

            //First Method: if statement (Adding else if)
            int v = 51; 
            if (v == 50) {
                Console.WriteLine("True"); 
            }
            else if (v >= 51 && v <= 60) {
                Console.WriteLine("The value is between 51 and 60"); 
            }

            else {
                Console.WriteLine("False"); 
            }

            //Ternary Operator (?) Short-hand if-else statements
            Console.WriteLine(v < 50 ? "The value is small" : "The value is large");
        }
    }
}
