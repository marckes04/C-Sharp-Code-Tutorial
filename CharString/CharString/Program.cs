using System;

namespace CharString
{
    class Program
    {
        static void Main(string[] args)
        {
            //char myChar = 'A';
            //Console.WriteLine(myChar);

            string name1 = "Jesse";
            string name2 = "Bob";
        
            bool namesEqual = string.Equals(name1,name2);
            Console.WriteLine("Name Equals {0}", namesEqual);

            Console.WriteLine("{0} has {1} characters", name1, name1.Length);

            string firstCharacterOfName = name1.Substring(0,1);//0 begin position and 1 end position
            Console.WriteLine(firstCharacterOfName);

            string middleOfSectionOfName = name1.Substring(1, 3);
            Console.WriteLine(middleOfSectionOfName);

            bool StartsWith = name1.StartsWith("J");
            Console.WriteLine(StartsWith);
        }
    }
}
