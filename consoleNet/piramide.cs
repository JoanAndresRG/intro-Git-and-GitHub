// namespace consoleNet;
// class Piramide2
// {
//     static void crearPiramide2(int numeroInp)
//     {
//         for (int i = 0; i < numeroInp; i++)
//         {
//             //con ciclo for (mas lento)
//             /*for (int j = i; j <= numeroInp; j++)
//             {
//                 Console.Write("  ");               
//             }*/
//             string res = string.Concat(Enumerable.Repeat("  ", numeroInp - i));
//             string resultado = string.Concat(Enumerable.Repeat("* ", i * 2 + 1));
//             Console.Write(res);
//             Console.Write(resultado);
//             Console.WriteLine();
//         }
//     }
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.Write("Ingrese en número de filas a crear: ");
//             int entry = Int32.Parse(Console.ReadLine());
//             crearPiramide2(entry);
//         }
//     }
// }

