using System;

namespace MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] myArray = new int[3, 4];
            //myArray[0, 0] = 5;
            //myArray[0, 1] = 4;
            //myArray[0, 2] = 54;
            //myArray[0, 3] = 42;

            //myArray[1, 0] = 55;
            //myArray[1, 1] = 9;
            //myArray[1, 2] = 45;
            //myArray[1, 3] = 6;


            //myArray[2, 0] = 43;
            //myArray[2, 1] = 23;
            //myArray[2, 2] = 12;
            //myArray[2, 3] = 11;



            //for (int i =0; i < 3; i++)
            //{
            //    for(int j=0; j < 4; j++)
            //    {
            //        Console.Write(myArray[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            int[][] myArray = new int[3][];
            myArray[0] = new int[5]{0,1,2,3,4};
            myArray[1] = new int[10]{0, 1, 2, 3, 4,5,6,7,8,9};
            myArray[2] = new int[6]{1, 4, 6, 6, 7, 7};


            for(int i = 0; i < 3; i++)
            {
                for(int j = 0;j< myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
