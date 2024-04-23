class Program1
{
    static void Main(string[] args)
    {
        string jewels = Console.ReadLine();
        string stones = Console.ReadLine();
        int result = 0;
        foreach (char search in stones) 
        {
            if (jewels.IndexOf(search) >= 0) 
            {
                ++result;
            }
        }
        Console.WriteLine(result);
    }
}