namespace Task2._1;
public class Student
{
    public string LastName { get; set; } = "";
    public DateOnly BirthDate { get; private set; }
    public int Group { get; set; }
    public int[]? Performanse { get; set; } = new int[5];

    public DateOnly SetDate(int day, int month, int year)
    {
        BirthDate = new DateOnly(year, month, day);
        return BirthDate;
    }
}