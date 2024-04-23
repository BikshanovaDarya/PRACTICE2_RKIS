class Program2
{
    static void Main (string[] args) 
    {
        Console.Write("Введите элементы массива через пробел: ");
        int[] candidates = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
        Console.Write("Введите число (цель): ");
        int target = Convert.ToInt32(Console.ReadLine());
        List<List<int>> result = sum(candidates, target);
        Console.WriteLine("[");
        foreach (List<int> combination in result) 
        {
            Console.WriteLine("[" + string.Join(", ", combination) + "]");
        }
        Console.WriteLine("]");
    }
    static List<List<int>> sum(int[] candidates, int target) 
    {
        Array.Sort(candidates);
        List<List<int>> result = new List<List<int>>();
        findcomb(candidates, target, 0, new List<int>(), result);
        return result;
    }
    static void findcomb(int[] candidates, int target, int start, List<int> current, List<List<int>> result) 
    {
        if (target == 0) 
        {
            result.Add(new List<int>(current));
            return;
        }
        for (int i = start; i < candidates.Length; i++) {
            if (i > start && candidates[i] == candidates[i - 1]) 
            {
                continue;
            }
            if (target - candidates[i] >= 0) 
            {
                current.Add(candidates[i]);
                findcomb(candidates, target - candidates[i], i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}