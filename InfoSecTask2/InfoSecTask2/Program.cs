using System.Runtime.InteropServices;

namespace InfoSecTask2
{
    internal class Program : DecryptionFunctions
    {
        static string input;
        static bool inputMode;
        static void Main(string[] args)
        {
            Console.Write("Select input mode:\n1. Console only\n2. File system\n");
            if (Console.ReadLine() == "1")
            {
                inputMode = true;
            }
            else
            {
                inputMode = false;
            }
            while (input != "q")
            {
                Console.WriteLine("Please select encryption algorithm\n1. ECB\n2. CBC\n3. CFB");
                input = Console.ReadLine();
                if(input == "1")
                {
                    ECB(inputMode);
                }
                else if(input == "2")
                {
                    CBC(inputMode);
                }
                else if( input == "3")
                {
                    CFB(inputMode);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }

            }
        }
    }
}