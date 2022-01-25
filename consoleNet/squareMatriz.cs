// using System;
// using System.Linq;
// using System.Collections;
// using System.Collections.Generic;
// namespace consoleNet
// {
//     public class squareMatriz
//     {
//         /*Solución a reto de haker rank hace 
//         falta los valores de entrada que los obtiene del programa*/
//         public static void Main(string[] args)
//         {
//             int leftRight = 0;
//             int rightLeft = 0;
//             int row = 0;
//             int fin = 0;
//             foreach (var l in arr) fin++;

//             fin = fin;
//             Console.WriteLine(fin);
//             foreach (var list in arr)
//             {
//                 int col = 0;
//                 foreach (int num in list)
//                 {
//                     if (row == 0 && col == 0) leftRight += num;
//                     if (row == fin - 1 && col == fin - 1) leftRight += num;
//                     if (row == 0 && col == fin - 1) rightLeft += num;
//                     if (row == fin - 1 && col == 0) rightLeft += num;
//                     if (fin % 2 != 0)
//                     {
//                         if (row == Math.Abs(fin / 2) && col == Math.Abs(fin / 2))
//                         {
//                             leftRight += num;
//                             Console.WriteLine(num);
//                             rightLeft += num;
//                         }
//                     }
//                     if (row > 0 && row < fin - 1 && col > 0 && col < fin - 1 && row == col)
//                     {
//                         leftRight += num;
//                         Console.WriteLine("lr: " + num);
//                     }
//                     if (row > 0 && row < fin - 1 && col > 0 && col < fin - 1 && (row + col) + 1 == fin)
//                     {
//                         rightLeft += num;
//                         Console.WriteLine("rl: " + num);
//                     }
//                     col++;
//                 }
//                 row++;
//             }

//             int result = Math.Abs(leftRight - rightLeft);
//             return result;
//         }
//     }
// }
// }