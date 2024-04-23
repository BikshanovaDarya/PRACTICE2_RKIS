namespace Task2._2;
class Program2_Train
{
    static void Main()
    {
        var train = new Train();
        while (true)
        {
            Console.WriteLine("Команды:");
            Console.WriteLine("[E] - Редактировать");
            Console.WriteLine("[P] - Вывод");
            Console.WriteLine("[Q] - Выйти");
            string command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "E":
                    Console.Clear();
                    Edit(train);
                    continue;
                case "P":
                    Console.Clear();
                    Print(train);
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
    static void Edit(Train train)
    {
        while (true)
        {
            Console.WriteLine("Данные:");
            Console.WriteLine("[D] - Пункт назначения");
            Console.WriteLine("[N] - Номер поезда");
            Console.WriteLine("[T] - Время отправления");
            Console.WriteLine("[Q] - Выйти");
            string? property = Console.ReadLine();
            switch (property.ToUpper())
            {
                case "D":
                    Console.Clear();
                    Console.Write("Введите пункт назначения: ");
                    train.Destination = Console.ReadLine() ?? "";
                    Console.Clear();
                    break;
                case "N":
                    Console.Clear();
                    Console.Write("Введите номер поезда: ");
                    train.TrainNumber = int.Parse(Console.ReadLine() ?? "0");
                    Console.Clear();
                    break;
                case "T":
                    Console.Clear();
                    Console.Write("Введите время отправления (дд.мм.гггг): ");
                    int[]? date = Console.ReadLine()?.Split('.').ToArray().Select(int.Parse).ToArray();
                    Console.Write("Введите время отправления (чч:мм): ");
                    int[]? time = Console.ReadLine()?.Split(':').ToArray().Select(int.Parse).ToArray();
                    train.SetDeparture(date[0], date[1], date[2], time[0], time[1]);
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
    static void Print(Train train)
    {
        while (true)
        {
            Console.WriteLine("Данные:");
            Console.WriteLine("[D] - Пункт назначения");
            Console.WriteLine("[N] - Номер поезда");
            Console.WriteLine("[T] - Время отправления");
            Console.WriteLine("[Q] - Выйти");
            string? property = Console.ReadLine();
            switch (property.ToUpper())
            {
                case "D":
                    Console.Clear();
                    Console.WriteLine($"Пункт назначения: {train.Destination}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "N":
                    Console.Clear();
                    Console.WriteLine($"Номер поезда: {train.TrainNumber}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "T":
                    Console.Clear();
                    Console.WriteLine($"Время отправления: {train.DepartureTime}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
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
}
