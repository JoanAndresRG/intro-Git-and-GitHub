namespace consoleNet;

/*
     * Complete the 'permutationEquation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY p as parameter.
     */

public class permutationEqaHR
{
    public static void Main(string[] args)
    {
        List<int> p = new List<int>() { 5, 2, 1, 3, 4};
        var rsult = permutationEquation(p);
        foreach (int i in rsult) Console.WriteLine(i);
    }
    public  static List<int> permutationEquation(List<int> p)
    {
        List<int> res = new List<int>();
        for (int i = 1; i < p.Count+1; i++)
        {
            int idx1 = p.IndexOf(i) + 1;
            int idx2 = p.IndexOf(idx1) + 1;
            res.Add(idx2);
        }
        return res;
    }
}