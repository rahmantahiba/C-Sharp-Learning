using System; 

    namespace BreakContinue 
    {
        class Program {

            static void Main(string[] args) {
                //the break and continue statement controls the flow of the conditions where we can continue or stop the condition at any moment.

                int[] values = {15,7,12,23,41,28,9,17,36}; 
                Console.WriteLine("Using break and continue: "); 
                foreach (int val in values) { //iterating through the array.
                    if (val >= 20 && val <= 29) {
                        continue; //excludes values in the 20s and goes to 40s because of the continue statement.
                    }
                    Console.WriteLine($"val is currently {val}"); 
                }

                Console.WriteLine("Using break and continue: "); 
                foreach(int val in values) {
                    if (val >= 40) {
                        break; //the condition will "stop" once the value greater than 40 is found.
                        
                    }
                    Console.WriteLine($"val is currently {val}"); //Just needed to put this line outside the conditional for all the arrays to print
                }
            }
        }
    }
