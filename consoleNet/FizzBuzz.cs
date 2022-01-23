// See https://aka.ms/new-console-template for more information


public class fizzBuzz
{
    //Se declara el arreglo type int[] y se inicializa con 15 valores

    public int[] Valores(int num)
    {
        int[] listNum = new int[num];
        for (int i = 1; i < num; i++)
        {
            listNum[i - 1] = i;
        }
        return listNum;
    }


    static void Main(string[] args)
    {
        try
        {
            fizzBuzz lista = new fizzBuzz();
            Console.Write("Please enter a namber: ");
            var value = Convert.ToInt32(Console.ReadLine());
            int[] list = lista.Valores(value);
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] % 3 == 0 && list[i] % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (list[i] % 3 == 0) Console.WriteLine("Fizz");
                else if (list[i] % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(list[i]);
            }
        }
        catch (System.Exception e)
        {
            Console.WriteLine("Error: "+ e);
        }
    }
}





