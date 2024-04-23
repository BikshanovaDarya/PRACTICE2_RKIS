namespace Task3._2;
public static class Program3_Calculation
{
    public static void Main()
    {
        var line = new Calculation();
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Данные:");
            Console.WriteLine("S - Новая строка");
            Console.WriteLine("L - Новый символ строки");
            Console.WriteLine("G - Вывести строку");
            Console.WriteLine("K - Вывести последний символ");
            Console.WriteLine("D - Удалить последний символ");
            Console.WriteLine("Q - Выйти");
            string? command = Console.ReadLine();
            switch (command.ToUpper())
            {
                case "S":
                    Console.Clear();
                    Console.Write("Введите новую строку: ");
                    line.SetCalculationLine(Console.ReadLine() ?? string.Empty);
                    Console.Clear();
                    continue;
                case "L":
                    Console.Clear();
                    Console.Write("Введите новый символ строки: ");
                    line.SetLastSymbolCalculationLine(Console.ReadLine()![0]);
                    Console.Clear();
                    continue;
                case "G":
                    Console.Clear();
                    line.GetCalculationLine();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "K":
                    Console.Clear();
                    line.GetLastSymbol();
                    Console.Write("Нажмите Enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                case "D":
                    line.DeleteLastSymbol();
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