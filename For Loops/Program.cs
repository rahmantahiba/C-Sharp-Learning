using System; 

namespace ForLoop {

    class Program {
        static void Main(string[] args) {
            
            int myVal = 15; 
            int[] nums = new int[] {3,14,15,92,6}; //an array 
            string str = "The quick brown fox jumps over the lazy dog"; 

            //for loop syntax 
            Console.WriteLine("The basic for loop: "); 
            for (int i = 0; i < myVal; i++) {
                Console.WriteLine("i is currently {0}", i); //it will stop at 14 since myval is set to less than i not less than or equal to.
            }

            foreach (int i in nums) {
                Console.WriteLine("i is currently {0}", i); 
            }

        //Count the number of o in the string 

            var count = 0; 
            foreach (char c in str) {
            if (c == 'o') {
            count++; 
            }

            }
                
            Console.WriteLine("Amount of times 'o' appeared: {0}", count);

        }
    }
}
