namespace Task3._1;
class Worker(string name, string surname, int rate, int days)
{
    private string Name { get; } = name;
    private string Surname { get; } = surname;
    private int Rate { get; } = rate;
    private int Days { get; } = days;

    public int GetSalary()
    {
        Console.WriteLine($"Зарплата: {Rate * Days}");
        return Rate * Days;
    }

    public string GetName()
    {
        Console.WriteLine($"Имя: {Name}");
        return Name;
    }
    public string GetSurname()
    {
        Console.WriteLine($"Фамилия: {Surname}");
        return Surname;
    }
    public int GetRate()
    {
        Console.WriteLine($"Ставка: {Rate}");
        return Rate;
    }
    public int GetDays()
    {
        Console.WriteLine($"Количество отработанных дней: {Days}");
        return Days;
    }
}