using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace consoleNet
{
    public class squareMatriz
    {
        public static void Main(string[] args)
        {
            //Se intancia un objeto de la clase Randon
            Random rand = new Random();

            List<List<int>> Matriz = new List<List<int>>();
            for (int i = 0; i < 3; i++)
            {
                int numRandom = rand.Next(1, 21);
                List<int> Data = new List<int>();
                Data.Add(numRandom);
                Data.Add(numRandom);
                Data.Add(numRandom);
                Matriz.Add(Data);
            }
            foreach (var list in Matriz)
            {
                Console.Write("|");
                foreach (var element in list)
                {
                    Console.Write(element + "|");
                }
                Console.WriteLine();
            }
            diagonalDifference(Matriz);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            static void diagonalDifference(List<List<int>> arr)
            {
                int lr = 0;
                int rl = 0;
                int cont1 = 0;
                int cont2 = 0;
                foreach (var list in arr)
                {
                    foreach (var element in list)
                    {
                        if (cont1 == 0 && cont2 == 0) lr += element;
                        else if (cont1 == 0 && cont2 == 2) rl += element;
                        else if (cont1 == 1 && cont2 == 1) {
                            lr += element;
                            rl += element;
                        }
                        else if (cont1 == 2 && cont2 == 0) rl += element;
                        else if (cont1 == 2 && cont2 == 2) lr += element;
                        cont2 ++;
                    }
                    cont1 ++;
                }
                Console.WriteLine("LeftRight: "+lr+"\nRightLeft: "+rl);

            }
            
        }



    }
}