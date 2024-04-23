public class Program1_Roman
{
    public static void Main(string[] args) 
    {
        Console.Write("Введите римское число: ");
        string RomanNum = Console.ReadLine();
        int res = RomanInt(RomanNum);
        Console.WriteLine("Целочисленное значение: " + res);
    }
    public static int RomanInt(string num) 
    {
        int result = 0;
        for (int i = 0; i < num.Length; i++)
        {
            int oldnum = RomanChar(num[i]);
            if (i + 1 < num.Length) 
            {
                int newnum = RomanChar(num[i + 1]);
                
                if (oldnum >= newnum) 
                {
                    result += oldnum;
                } else 
                {
                    result += newnum - oldnum;
                    i++;
                }
            } else 
            {
                result += oldnum;
            }
        }
        return result;
    }
    public static int RomanChar(char c)
    {
        switch (c) 
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}