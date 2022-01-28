// /*
//      * Complete the 'birthdayCakeCandles' function below.
//      *
//      * The function is expected to return an INTEGER.
//      * The function accepts INTEGER_ARRAY candles as parameter.
//      */
// namespace consoleNet;
// class Program
// {
//     public static int birthdayCakeCandles(List<int> candles)
//     {
//         int maxCandle = candles.Max();
//         int cont = 0;
//         foreach (int i in candles)
//         {
//             if (i == maxCandle) cont += 1;
//         }
//         return cont;
//     }
//     public static void Main(string[] args)
//     {
//         List<int> candle = new List<int>() { 2, 5, 8, 6, 8, 1, 8};
//         Console.WriteLine("Cantidad de velas de mayor tamaño: "+birthdayCakeCandles(candle) );
//     }
// }