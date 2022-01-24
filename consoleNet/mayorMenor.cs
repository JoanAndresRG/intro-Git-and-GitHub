// using System;
// using System.Collections.Generic;
// using System.Linq;

// /*Dados cinco enteros positivos, encuentre los valores mínimo y máximo que se pueden calcular sumando exactamente cuatro de los cinco enteros. Luego imprima los respectivos valores mínimo y máximo como una sola línea de dos enteros largos separados por espacios.
// **/

// namespace consoleNet
// {
//     public class mayorMenor
//     {
//          /*
//      * Complete the 'miniMaxSum' function below.
//      *
//      * The function accepts INTEGER_ARRAY arr as parameter.
//      */

//     public static void miniMaxSum(List<int> arr)
//     {
//         List<int> newlist = new List<int>();
//         foreach (int i in arr) {
//            newlist.Add(i);
//         }
//         int max1 = newlist.Max();
//         int min1 = newlist.Min();
//         newlist.Reverse();
//         int cont = 0;
//         for (int i = 0; i < newlist.Count; ++i)   
//         {
//             if (newlist[i] == min1)   
//             {
//                 Console.WriteLine(min1);
//                 newlist.RemoveAt(cont);
//                 newlist.Sort();
//                 int res1 = newlist.Sum();
//                 Console.Write(res1+" ");
//             }
//             if (newlist[i] == max1) 
//             {
//                 // Console.WriteLine(max1);
//                 newlist.RemoveAt(cont);
//                 newlist.Sort();    
//                 int res2 = newlist.Sum();
//                 Console.WriteLine(res2+" ");
//             }
//             cont ++;
//         }
//         Console.WriteLine(cont);
//     }
//     }
// }