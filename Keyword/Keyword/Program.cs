using System;

namespace Keyword
{
    class Program
    {
        static void Main(string[] args)
        {

           // Ref keyword
            int CreditNumber = 75;
            GiveExtracredit(ref CreditNumber);
            Console.WriteLine(CreditNumber);
            // params

            int[] myArray = { 1, 2, 3, 4, 5 };
            IntroduceArray(myArray);

        }
    
        public static void GiveExtracredit(ref int CreditNumber)
        {
            CreditNumber += 3;
        }

        public static void IntroduceArray(params int[] myarray)
        {
            for(int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }
        }
    }
}
