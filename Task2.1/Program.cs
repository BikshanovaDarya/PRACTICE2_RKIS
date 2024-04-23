namespace Task2._1;
class Program1_Student
{
    static void Main()
    {
        var student = new Student();
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
                    Edit(student);
                    continue;
                case "P":
                    Console.Clear();
                    Print(student);
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
    static void Edit(Student student)
    {
        while (true)
        {
            Console.WriteLine("Данные:");
            Console.WriteLine("[N] - Фамилия");
            Console.WriteLine("[B] - Дата рождения");
            Console.WriteLine("[G] - Номер группы");
            Console.WriteLine("[P] - Успеваемость");
            Console.WriteLine("[Q] - Выход");
            string? property = Console.ReadLine();
            switch (property.ToUpper())
            {
                case "N":
                    Console.Clear();
                    Console.Write("Введите фамилию: ");
                    student.LastName = Console.ReadLine() ?? "";
                    Console.Clear();
                    break;
                case "B":
                    Console.Clear();
                    Console.Write("Введите дату рождения (дд.мм.гггг): ");
                    int[]? date = Console.ReadLine()?.Split('.').ToArray().Select(int.Parse).ToArray();
                    student.SetDate(date[0], date[1], date[2]);
                    Console.Clear();
                    break;
                case "G":
                    Console.Clear();
                    Console.Write("Введите номер группы: ");
                    student.Group = int.Parse(Console.ReadLine() ?? "0");
                    Console.Clear();
                    break;
                case "P":
                    Console.Clear();
                    Console.Write("Введите успеваемость: ");
                    int[]? performanse = Console.ReadLine()?.Split(' ').ToArray().Select(int.Parse).ToArray();
                    student.Performanse = performanse;
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
    static void Print(Student student)
    {
        while (true)
        {
            Console.WriteLine("Данные:");
            Console.WriteLine("[N] - Фамилия");
            Console.WriteLine("[B] - Дата рождения");
            Console.WriteLine("[G] - Номер группы");
            Console.WriteLine("[P] - Успеваемость");
            Console.WriteLine("[Q] - Выход");
            string? property = Console.ReadLine();
            switch (property.ToUpper())
            {
                case "N":
                    Console.Clear();
                    Console.WriteLine($"Фамилия: {student.LastName}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "B":
                    Console.Clear();
                    Console.WriteLine($"Дата рождения: {student.BirthDate}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "G":
                    Console.Clear();
                    Console.WriteLine($"Номер группы: {student.Group}");
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "P":
                    Console.Clear();
                    Console.WriteLine($"Успеваемость: {string.Join(",", student.Performanse)}");
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