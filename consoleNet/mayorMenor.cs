using System;
using System.Collections.Generic;
using System.Linq;

/*Dados cinco enteros positivos, encuentre los valores mínimo y máximo que se pueden calcular sumando exactamente cuatro de los cinco enteros. Luego imprima los respectivos valores mínimo y máximo como una sola línea de dos enteros largos separados por espacios.
**/

namespace consoleNet
{
    class Program
    {
        public static void miniMaxSum(List<int> arr)
        {
            long numMax = 0;
            long numMin = 0;
            int maxList = arr.Max();
            int minList = arr.Min();
            int indMax = arr.IndexOf(maxList);
            int indMin = arr.IndexOf(minList);
            Console.WriteLine($"MaxIten: {maxList}\nMinIten: {minList}");
            Console.WriteLine($"MaxIdex: {indMax}\nMinIndex: {indMin}");
            // if (indMin == 0) indMin -= 1;
            // if (indMax == 1) indMax -= 1;
            Console.WriteLine("verf min:" + arr[indMin]);
            arr.Remove(arr[indMin]);
            List<int> nlMax = new List<int>();
            foreach (int iten in arr)
            {
                nlMax.Add(iten);
                numMax += iten;
                Console.WriteLine(iten);
            }
            // numMax = Convert.ToInt64(nlMax.Sum());
            numMin = Convert.ToInt64(numMax - maxList + minList);
            Console.WriteLine(numMin + " " + numMax);
        }

        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 769082435, 210437958, 673982045, 375809214, 380564127 };
            miniMaxSum(list);
        }
    }
}