class Program3 
{
    static void Main(string[] args) 
    {
        Console.Write("Введите элементы массива через пробел: ");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        Console.Write(repeatnums(nums) ? "true" : "false");
    }
    static bool repeatnums(int[] nums)
    {
        int maxNum = int.MinValue;
        foreach (int num in nums)
        {
            maxNum = Math.Max(maxNum, num);
        }
        bool[] search = new bool[maxNum + 1];
        foreach (int num in nums) 
        {
            if (search[num]) 
            {
                return true;
            } else 
            {
                search[num] = true;
            }
        }
        return false;
    }
}