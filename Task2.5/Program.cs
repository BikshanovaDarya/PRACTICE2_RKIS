namespace Task2._5;
class Program5_Constructor
{
    public static void Main()
    {
        Console.Write("Введите число: ");
        int count = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? string.Empty;
        Constructor сonstructor = new Constructor(count, name);
        Console.Write("Нажмите Enter");
        Console.ReadLine();
        Console.Clear();
    }
}