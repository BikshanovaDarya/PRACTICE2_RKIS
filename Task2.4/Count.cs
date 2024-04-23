namespace Task2._4;
public class Count(int value = 0)
{
    public int CounterValue { get; private set; } = value;

    public int UpCounter()
    {
        CounterValue++;
        return CounterValue;
    }
    public int DownCounter()
    {
        CounterValue--;
        return CounterValue;
    }
}