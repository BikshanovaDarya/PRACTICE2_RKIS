namespace Task2._3;
internal static class Program3_Numbers
{
    public static void Main()
    {
        var numbers = new Numbers();
        while (true)
        {
            Console.WriteLine("Команды:");
            Console.WriteLine("[E] - Редактировать");
            Console.WriteLine("[P] - Вывод");
            Console.WriteLine("[Q] - Выйти");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "E":
                    Console.Clear();
                    Edit(numbers);
                    continue;
                case "P":
                    Console.Clear();
                    Print(numbers);
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
    static void Edit(Numbers numbers)
    {
        while (true)
        {
            Console.WriteLine("Числа:");
            Console.WriteLine("[F] - Первое");
            Console.WriteLine("[S] - Второе");
            Console.WriteLine("[Q] - Выйти");
            string? property = Console.ReadLine();
            switch (property.ToUpper())
            {
                case "F":
                    Console.Clear();
                    Console.Write("Введите первое число: ");
                    numbers.SetFirst(int.Parse(Console.ReadLine() ?? "0"));
                    Console.Clear();
                    break;
                case "S":
                    Console.Clear();
                    Console.Write("Введите второе число: ");
                    numbers.SetSecond(int.Parse(Console.ReadLine() ?? "0"));
                    Console.Clear();
                    break;
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
    static void Print(Numbers numbers)
    {
        while (true)
        {
            Console.WriteLine("Вывести::");
            Console.WriteLine("[F] - Первое число");
            Console.WriteLine("[S] - Второе число");
            Console.WriteLine("[P] - Сумма чисел");
            Console.WriteLine("[M] - Наибольшее число");
            Console.WriteLine("[Q] - Выйти");
            string? property = Console.ReadLine();
            switch (property.ToUpper())
            {
                case "F":
                    Console.Clear();
                    numbers.PrintFirst();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "S":
                    Console.Clear();
                    numbers.PrintSecond();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "P":
                    Console.Clear();
                    Console.WriteLine($"Сумма: {numbers.Sum()}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "M":
                    Console.Clear();
                    Console.WriteLine($"Наибольшее число: {numbers.Maximal()}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "Q":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("ERROR");
                    continue;
            }
            break;
        }
    }
}