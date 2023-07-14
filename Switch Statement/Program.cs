using System; 

namespace Switch
{

    class Program {
    static void Main(string[] args) {
        int theVal = 50; 

        //inside the switch statement the variable has to be defined then broken down into different cases.
        //The break statement finishes each cases. 
        //Once 50 is found the other cases aren't checked because of the break statement. 
        switch (theVal) {
        case 50: 
            Console.WriteLine("The value is 50"); 
            break; 
        case 51: 
            Console.WriteLine("The value is 51"); 
            break; 
        case 52:
        case 53:
        case 54: 
            Console.WriteLine("The value is between 52 and 54"); 
            break; 
        //Default is used when none other cases match the expression. 
        default: 
            Console.WriteLine("The value is something else."); 
            break; 
        }

        int secondv = 53; 
        switch (secondv) {
        case 50: 
            Console.WriteLine("The value is 50"); 
            break; 
        case 51: 
            Console.WriteLine("The value is 51"); 
            break; 
        //Goes onto the additional cases to find the value 53. 
        case 52:
        case 53:
        case 54: 
            Console.WriteLine("The value is between 52 and 54"); 
            break;  
        default: 
            Console.WriteLine("The value is something else."); 
            break; 
        }

        int sixty = 60; 
        switch (sixty) {
        case 50: 
            Console.WriteLine("The value is 50"); 
            break; 
        case 51: 
            Console.WriteLine("The value is 51"); 
            break; 
        case 52:
        case 53:
        case 54: 
            Console.WriteLine("The value is between 52 and 54"); 
            break; 
        //The default value is executed since 60 doesn't match any of the case values. 
        default: 
            Console.WriteLine("The value is something else."); 
            break; 
        }

    }

    }


}
