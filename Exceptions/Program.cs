using System; 

namespace Exceptions {

    class Program {

        static void Main(string[] args) {

            int x = 1002; 
            int y = 0; 
            int result; 
        
        //Catch the error 

        try {
            if (x > 1000) {
                throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less"); //throw in another condition for error catching.
            }
            result = x/y; 
            Console.WriteLine("The result is: {0}", result); 

        } catch (DivideByZeroException z) {
            Console.WriteLine("Can't divide by zero!"); 
            Console.WriteLine(z.Message); 

        } catch (ArgumentOutOfRangeException r) {
            Console.WriteLine("Sorry, 1000 is the limit"); 
            Console.WriteLine(r.Message); 
        }

        finally {
            Console.WriteLine("This code always runs."); //cleaning up the exceptions.
        }

        }
    }
}
