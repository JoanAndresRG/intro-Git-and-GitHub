
/*
     * Complete the 'circularArrayRotation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER k
     *  3. INTEGER_ARRAY queries
     */
namespace consoleNet;
public class circularArrayHK
{
    public static void Main(string[] args)
    {
        List<int> a = new List<int>(){1,2,3};
        int k = 2;
        List<int> q = new List<int>(){0,1,2};
        Console.WriteLine(circularArrayRotation(a, k, q));
    }

    public static List<int> circularArrayRotation(List<int> a, int k,List<int> queries)
    {
        List<int> newList = new List<int>();
        int cont = 0;
        foreach (int i in a)
        {
            newList[cont] = i;
        }
        return newList;
    }

}
