using System;

namespace Variable_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";

            string sentence1 = "This is the first sentence.";

            string sentence2 = "This is the second sentence";

            string added = $"{sentence1} {sentence2}";

            Console.WriteLine(added);


        }
    }
}
