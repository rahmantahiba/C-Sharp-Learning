using System; 

namespace WhileLoops {

    class Program {

        static void Main(string[] args) {
            string inputStr = ""; 
            Console.WriteLine("Basic while() loop: "); 
            //Basic syntax of while loop that will continue as long as the condition is true by checking the condition first. 
            while (inputStr != "exit") { //the program will stop when the user types "exit" since it is set as false. 
                inputStr = Console.ReadLine(); 
                Console.WriteLine("You entered: {0}", inputStr); 

            string str = ""; 
            Console.WriteLine("The do-while loop: "); 
            do {
                str = Console.ReadLine(); 
                Console.WriteLine("You entered: {0}", str); 

            } while(str != "exiting"); //The do-while loop is guarantee to run at least one time since the while-loop is at the bottom before checking the condition.

            }
        }
    } 
}
