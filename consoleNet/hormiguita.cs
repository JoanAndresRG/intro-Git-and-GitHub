// namespace consoleNet
// {
//     public class hormiguita
//     {
//         static void Main(string[] args)
//         {
//             Boolean run = true;
//             while (run)
//             {
//                 string text = "\nTengo una hormiguita en la patica que me esta haciendo cosquillitas y no me deja dormir...";
//                 Console.WriteLine(text);
//                 Console.WriteLine("--------------------------------------------------------------------------------------------");
//                 Console.Write("\nPor favor ingrese una vocal: ");
//                 char value = Convert.ToChar(Console.ReadLine().ToLower());
//                 char[] abc = { 'a', 'e', 'i', 'o', 'u' };
//                 text = string.Join(value, text.Split(abc));
//                 Console.WriteLine(text);
//                 Console.WriteLine("--------------------------------------------------------------------------------------------");
//                 Console.Write("\nDesea coninuar? Y o N: ");
//                 var res = Convert.ToChar(Console.ReadLine().ToLower());
//                 try
//                 {
//                     if (res == 'n')
//                     {
//                         run = false;
//                     }
//                     else if (res == 'y')
//                     {
//                         run = true;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Entrada invalida");
//                     }

//                 }
//                 catch (System.Exception e)
//                 {

//                     Console.WriteLine("Error: "+e);
//                 }
//             }
//         }

//     }
// }