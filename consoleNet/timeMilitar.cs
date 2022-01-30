// namespace consoleNet;

// class Program
// {
//     /*
//      * Complete the 'timeConversion' function below.
//      *
//      * The function is expected to return a STRING.
//      * The function accepts STRING s as parameter.
//      */

//     public static string timeConversion(string s)
//     {
//         string conti = s.Remove(s.Length-2, 2);
//         string[] nStr = conti.Split(':');
//         string hrs = nStr[0];
//         string min = nStr[1];
//         string seg = nStr[2];
//         if (s.Contains("PM") && hrs != "12") 
//         {
//             int nHrs = Convert.ToInt32(hrs);
//             nHrs += 12;
//             return $"{nHrs}:{min}:{seg}";
//         }else if (s.Contains("AM") && hrs == "12")
//         {
//             hrs = "00";
//         }
//         return $"{hrs}:{min}:{seg}";
//     }

//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Please enter time in this format: (hh:mm:ss'PM or AM')");
//         var time = Console.ReadLine();
//         Console.WriteLine("Time 24hrs is: "+timeConversion(time));
//     }
// }