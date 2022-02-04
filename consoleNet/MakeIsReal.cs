// namespace consoleNet
// {
//     public class MakeIsReal
//     {
//         public static void Main(string[] args)
//         {
//             Console.Write("Please enter your age: ");
//             int entry = Convert.ToInt32(Console.ReadLine());
//             Console.Write("Please enter your ingresos: ");
//             int ent = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Sus impuestos son: "+CalcularImpuestos(entry,ent));

//         }
//         static int CalcularImpuestos(int edad, int ingresos)
//         {
//             if (edad >= 18 && ingresos >= 1000)
//             {
//                 int result = ingresos * 40 / 100;
//                 return result;
//             }
//             else return 0;
//         }
//     }
// }