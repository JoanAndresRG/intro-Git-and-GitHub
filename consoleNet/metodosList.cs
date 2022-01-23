// using System.Collections.Generic;
// using System;
// using System.Linq;

// namespace consoleNet
// {
//     class Program
//     {

//         // public static int balancedSum(List<int> arr)
//         // {

//         //     int sum = 0;

//         //     for (int i = 0; i < arr.Count; i++)
//         //     {
//         //     var subArr =  arr.Slice(sum,i);
//         //        Console.Write(arr[i]+ " - ");
//         //     }

//         //     return 0;
//         // }

//         static void Main(string[] args)
//         {
//             List<int> valores = new List<int>();

//             valores.Add(1);
//             valores.Add(2);
//             valores.Add(3);
//             valores.Add(4);
//             valores.Add(6); // método para adicionar a la lista
//             Console.Write("Lista: ");
//             foreach (int i in valores) Console.Write(i + " - "); // ciclo for para imprimir los valores de la lista
//             int count = valores.Count; Console.WriteLine("\nNúmero de elementos: " + count);  // numero de elementos en la Collection
//             int max = valores.Max(); Console.WriteLine("Núemro mayor: " + max); // numero mayor de la lista
//             int min = valores.Min(); Console.WriteLine("Núemro menor: " + min); // numero menorr de la lista
//             double sum = 0;
//             foreach (var item in valores)
//             {
//                 sum += item;
//             }
//             double media = sum / valores.Count; Console.WriteLine("Media: " + media);
//             int contiene = 3; Console.WriteLine("Contiene?: "+valores.Contains(contiene));  // this method looks for an element in the collection, return true  or false 
//             Console.WriteLine("Indice: "+ valores.IndexOf(contiene)); // method returns the index of the element in the collection, else return -1
//             valores.Insert(3,5); // insert a new item into the collection at a specific index
//             Console.Write("Nueva Lista: ");
//             foreach (var item in valores)
//             {
//                 Console.Write(item +" - ");
//             }
//             Console.Write("\nÚltima Lista: ");
//             valores.RemoveAt(3);
//             foreach (var item in valores)
//             {
//                 Console.Write(item +" - ");
//             }


//         }
//     }
// }