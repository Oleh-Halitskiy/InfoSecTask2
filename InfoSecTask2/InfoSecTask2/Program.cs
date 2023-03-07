namespace InfoSecTask2
{
    internal class Program : DecryptionFunctions
    {
        static string input;
        static void Main(string[] args)
        {
            while (input != "q")
            {
                Console.WriteLine("Please select encryption algorithm\n1. ECB\n2. CBC\n3. CFB");
                input = Console.ReadLine();
                if(input == "1")
                {
                   DecryptionFunctions.ECB();
                }
                else if(input == "2")
                {
                    CBC();
                }
                else if( input == "3")
                {
                    CFB();
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }

            }
        }
    }
}