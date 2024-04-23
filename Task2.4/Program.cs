namespace Task2._4;
static class Program4_Count
{
    public static void Main()
    {
        Console.Write("Введите начальное значение: ");
        string? element = Console.ReadLine();
        Random rnd = new Random();
        var counter = new Count(element != "" ? int.Parse(element) : rnd.Next(100));
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Команды:");
            Console.WriteLine("[U] - Увелечить на 1");
            Console.WriteLine("[D] - Уменьшить на 1");
            Console.WriteLine("[P] - Вывести");
            Console.WriteLine("[Q] - Выйти");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "U":
                    Console.Clear();
                    counter.UpCounter();
                    continue;
                case "D":
                    Console.Clear();
                    counter.DownCounter();
                    continue;
                case "P":
                    Console.Clear();
                    Console.WriteLine($"Значение счетчика: {counter.CounterValue}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "Q":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Ошибка.");
                    continue;
            }
            break;
        }
    }
}