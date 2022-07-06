using System;

namespace _5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Array Declare methods
            
            string[] car;
            int[] carint;
            char[] charArray;
            long[] longArray;

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "opel" };
            
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);
            //int[] myNum = { 10, 20, 30, 40 };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string iten in cars)
            {
                Console.WriteLine(iten);
            }

            ////sort
            string[] carss = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(carss);

            foreach (string i in carss)
            {
                Console.WriteLine(i);
            }


            //// Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }


            int[] myNumberss = { 5, 1, 8, 9 };

            //Console.WriteLine(myNumbers.Max());  // returns the largest value
            //Console.WriteLine(myNumbers.Min());  // returns the smallest value
            //Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            //Create an array of four elements, and add values later
            string[] carsssss = new string[8];
            for (int i = 0; i < carsssss.Length; i++)
            {
                carsssss[i] = (i * i).ToString();
            }

            //Create an array of four elements and add values right away

            string[] carsss = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            carsss[4] = "new";//its ok or not
            carsss[4] = "new5";

            foreach (string item in carsss)
            {
                Console.WriteLine(item);
            }

            carsss.GetValue(3);
            carsss.GetLength(0);
            carsss.SetValue("", 2);



            //  // Create an array of four elements without specifying the size 
            //  string[] carssss = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] carssssss = { "Volvo", "BMW", "Ford", "Mazda" };

            
            // Declare an array
            string[] cats;

            // Add values, using new
            cats = new string[] { "Volvo", "BMW", "Ford" };

            // Add values without using new (this will cause an error)
            //cats = { "Volvo", "BMW", "Ford"};

            int[,,] arr3d1 = new int[1, 2, 2]{
                { { 1, 2}, { 3, 4} }
            };

            int[,,] arr3d2 = new int[2, 2, 2]{
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            };

            int[,,] arr3d3 = new int[2, 2, 3]{
                { { 1, 2, 3}, {4, 5, 6} },
                { { 7, 8, 9}, {10, 11, 12} }
            };

            Console.WriteLine(arr3d2[0, 0, 0]); // returns 1 
            Console.WriteLine(arr3d2[0, 0, 1]); // returns 2 
            Console.WriteLine(arr3d2[0, 1, 0]); // returns 3 
            Console.WriteLine(arr3d2[0, 1, 1]); // returns 4 
            Console.WriteLine(arr3d2[1, 0, 0]); // returns 5 
            Console.WriteLine(arr3d2[1, 0, 1]); // returns 6 
            Console.WriteLine(arr3d2[1, 1, 0]); // returns 7 
            Console.WriteLine(arr3d2[1, 1, 1]); // returns 8 

        }
        public class Arrayss
        {

            //int[] array1 = new int[5];
            //Int array244] = new int[];
            //int[5] array44[] = new int[5];
            //int[] arr4ay1 = new int[5];
            //int arr44ay1 = new int();


            // Declare and set array element values.
            int[] array2 = new int[5] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 },
                                              { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            // jaggedArray[0] = new int[4] { 1, 2, 3, 4 };



            int[][] jagArray = { new int[] { 10, 20, 30 }, new int[] { 11, 22 } };

            int[][] jagged_arr ={
                                   new int[] {1, 2, 3, 4},
                                   new int[] {11, 34, 67},
                                   new int[] {89, 23},
                                   new int[] {0, 45, 78, 53, 99}
};



        }
    }


}



