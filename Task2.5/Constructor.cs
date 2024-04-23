namespace Task2._5;
public class Constructor
{
    public int Counter { get; }
    public string Name { get; }
    public Constructor(int counter, string name)
    {
        Counter = counter;
        Name = name;
    }
    public Constructor()
    {
        Random rnd = new Random();
        Counter = rnd.Next(50);
        Name = "Даша";
    }
    ~Constructor()
    {
        Console.WriteLine($"Счетчик: {Counter}, Имя: {Name} id удален");
    }
}