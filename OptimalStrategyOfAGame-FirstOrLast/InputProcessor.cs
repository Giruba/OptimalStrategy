using System;
using System.Collections.Generic;
using System.Text;

namespace OptimalStrategyOfAGame_FirstOrLast
{
    class InputProcessor
    {
        public static int[] GetArrayFromInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try{
                int sizeOfArray = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements of the array separated" +
                    " by space, semi-colon or comma");
                String[] elements = Console.ReadLine().Split(' ', ',', ';');
                array = new int[sizeOfArray];
                for (int index = 0; index < sizeOfArray; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return array;
        }

        public static int PrintWinAmount(int[] array) {

            int[,] table = new int[array.Length, array.Length];

            for (int index = 0; index < array.Length; index++) {
                for (int startIndex = 0, endIndex = index; endIndex < array.Length;
                                            startIndex++, endIndex++) {

                    int x = ((startIndex + 2) <= endIndex) ? table[startIndex + 2, endIndex] : 0;
                    int y = ((startIndex + 1) <= (endIndex - 1)) ? table[startIndex + 1, endIndex - 1] : 0;
                    int z = (startIndex <= (endIndex - 2)) ? table[startIndex, endIndex - 2] : 0;

                    table[startIndex, endIndex] = Math.Max(array[startIndex]+Math.Min(x,y),
                        array[endIndex]+Math.Min(y,z));
                }
            }

            return table[0, array.Length-1];
        }
    }
}
