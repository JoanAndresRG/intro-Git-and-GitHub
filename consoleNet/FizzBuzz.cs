// See https://aka.ms/new-console-template for more information


public class fizzBuzz
{   
    //Se declara el arreglo type int[] y se inicializa con 15 valores
    int[] listNum = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

    static void Main(string[] args)
    {
        fizzBuzz lista = new fizzBuzz();
        int[] list = lista.listNum;
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] % 3 == 0 && list[i] % 5 ==  0) Console.WriteLine("FizzBuzz");
            else if (list[i] % 3 == 0) Console.WriteLine("Fizz");
            else if (list[i] % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(list[i]);
            
        }
        
    }
}





