// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace consoleNet
// {
//     public class masMenos
//     {
//         static void Main(string[] args)
//         {


//         }
//         /*
//      * Complete the 'plusMinus' function below.
//      *
//      * The function accepts INTEGER_ARRAY arr as parameter.
//      Dada una matriz de números enteros, calcule las proporciones de sus elementos que son positivos, negativos y cero. Imprime el valor decimal de cada fracción en una nueva línea con lugares después del decimal.
//      */

//     public static void plusMinus(List<int> arr)
//     {
//         List<int> positives = new List<int>();
//         List<int> negatives = new List<int>();
//         List<int> zeros = new List<int>();
//         foreach (int i in  arr)
//         {
//             if (i > 0)  positives.Add(i);
//             else if (i < 0) negatives.Add(i);
//             else zeros.Add(i);
//         }
//         double pos = Convert.ToDouble(positives.Count)/Convert.ToDouble(arr.Count);
//         double neg = Convert.ToDouble(negatives.Count)/Convert.ToDouble(arr.Count);
//         double zer = Convert.ToDouble(zeros.Count)/Convert.ToDouble(arr.Count);
//         Console.WriteLine("{0:N6}",pos);
//         Console.WriteLine("{0:N6}",neg);
//         Console.WriteLine("{0:N6}",zer);
//     }
//     }
// }