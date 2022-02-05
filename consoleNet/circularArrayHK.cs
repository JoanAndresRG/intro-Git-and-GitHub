
// namespace consoleNet

// /*
//      * Complete the 'circularArrayRotation' function below.
//      *
//      * The function is expected to return an INTEGER_ARRAY.
//      * The function accepts following parameters:
//      *  1. INTEGER_ARRAY a
//      *  2. INTEGER k
//      *  3. INTEGER_ARRAY queries
//      */
// {
//     public class circularArrayHK
//     {
//         public static void Main(string[] args)
//         {
//             List<int> a = new List<int>() { 3, 4, 5 };
//             int k = 2;
//             List<int> q = new List<int>() {  1, 2 };
//             Console.WriteLine(circularArrayRotation(a, k, q));
//         }

//         public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
//         {
//             k = k % a.Count;
//             int l = a.Count;
//             for (int i = 0; i < queries.Count; i++)
//             {
//                 int pos = (queries[i] - k + l) % l;
//                 queries[i] = a[pos];
//                 Console.WriteLine(queries[i]);
//             }
//             return queries;
//         }

//     }
// }
