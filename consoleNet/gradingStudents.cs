namespace gitPruebasComandos.consoleNet;

public class gradingStudents
{
    public static void Main(string[] args)
    {
        static List<int> gradingStudents(List<int> grades)
        {
            List<int> nList = new List<int>();
            foreach (int grade in grades)
            {
                int mulFive = ((grade / 5 + 1) * 5);
                if (mulFive >= 40 && (mulFive - grade) < 3) nList.Add(mulFive);
                else nList.Add(grade);
            }
            return nList;
        }
    }

}