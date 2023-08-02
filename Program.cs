using System;

namespace vscode_remote_try_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter input: num1, symbol, num2 on each line!");
           int input1 = Convert.ToInt32(Console.ReadLine());
           string x = Console.ReadLine();
           int input2 = Convert.ToInt32(Console.ReadLine());
           
           if (x == "+")
           {
               Console.WriteLine(input1 + input2);
           }
           else if(x == "-")
           {
               Console.WriteLine(input1 - input2);
           }
           else if(x == "*")
           {
               Console.WriteLine(input1 * input2);
           }
           else if(x == "/")
           {
              Console.WriteLine(input1 / input2); 
           }
           else if(x == "%")
           {
               Console.WriteLine(input1 % input2);
           }
           else
           {
               Console.WriteLine("Unknown input! \nUse only \"+, -, *, /, %\"");
           }
        }
    }
}