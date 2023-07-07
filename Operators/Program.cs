using System; 

namespace Operators

{
    class Program 
    
    {
        
        static void Main()
        {
        //Mathematical Operations
        int x = 10, y = 5; 
        string a = "abcd", b="efgh"; 
        Console.WriteLine("----Basic Math----"); 
        Console.WriteLine((x/y) * x); 
        Console.WriteLine(a + b); 

        //Increment/Decrement Operators
        Console.WriteLine("---Shorthand---"); 
        //increment 
        x++;
        Console.WriteLine(x); 
        //decrement
        y--; 
        Console.WriteLine(y); 

        //a = a + b 
        a += b; 
        Console.WriteLine(a); 

        //Logical Operators (&&, ||)
        Console.WriteLine("----Logical Operators---"); 
        Console.WriteLine(x > y && y >= 5); //"and" both have to be true to return true
        Console.WriteLine(x > y || y >= 5); //"or" one or either have to be true to return true
        
        //null-?? operators 
        string str = null;
        Console.WriteLine(str ?? "Unknown String"); 
        //The output will be "Unknown string" since str is a null value

        //??= assigns the right operand if the left one is null
        str ??= "New String"; 
        Console.WriteLine(str); 
        }
    }
}
