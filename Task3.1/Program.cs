namespace Task3._1;
public static class Program1_Worker
{
    public static void Main()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine() ?? string.Empty;
        Console.Write("Введите ставку: ");
        int rate = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите кол-во отработанных дней: ");
        int days = int.Parse(Console.ReadLine() ?? "0");
        var worker = new Worker(name, surname, rate, days);
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Данные:");
            Console.WriteLine("[N] - Имя");
            Console.WriteLine("[S] - Фамилия");
            Console.WriteLine("[R] - Ставка");
            Console.WriteLine("[D] - Количество отработанных дней");
            Console.WriteLine("[P] - Зарплата");
            Console.WriteLine("[Q] - Выйти");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "N":
                    Console.Clear();
                    worker.GetName();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "S":
                    Console.Clear();
                    worker.GetSurname();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "R":
                    Console.Clear();
                    worker.GetRate();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "D":
                    Console.Clear();
                    worker.GetDays();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "P":
                    Console.Clear();
                    worker.GetSalary();
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