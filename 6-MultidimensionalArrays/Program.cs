using System;

namespace _6_MultidimensionalArrays
{
    class Program
    {
        static void Main()
        {
            //int[,] a = new int[3, 4] {
            // {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */

            // {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
            // {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
            //                            };

            //int[,,,] arr4d1 = new int[1, 1, 2, 2]{
            //    {
            //        { { 1, 2}, { 3, 4} }
            //    }
            //};

            //Console.WriteLine(arr4d1[0, 0, 0, 0]);  // returns 1
            //Console.WriteLine(arr4d1[0, 0, 0, 1]); // returns 2
            //Console.WriteLine(arr4d1[0, 0, 1, 0]); // returns 3
            //Console.WriteLine(arr4d1[0, 0, 1, 1]); // returns 4
           

            //Jagged Array
            //int[][] jArray1 = new int[2][]; // can include two single-dimensional arrays 
            //int[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays 

            //int[][] jArray = new int[2][];

            //jArray[0] = new int[3] { 1, 2, 3 };

            //jArray[1] = new int[4] { 4, 5, 6, 7 };

            //int[][][] intJaggedArray = new int[2][][]
            //                {
            //                    new int[2][]
            //                    {
            //                        new int[3] { 1, 2, 3},
            //                        new int[2] { 4, 5}
            //                    },
            //                    new int[1][]
            //                    {
            //                        new int[3] { 7, 8, 9}
            //                    }
            //                };

            //Console.WriteLine(intJaggedArray[0][0][0]); // 1

            //Console.WriteLine(intJaggedArray[0][1][1]); // 5

            //Console.WriteLine(intJaggedArray[1][0][2]); // 9
        }
    }
}
