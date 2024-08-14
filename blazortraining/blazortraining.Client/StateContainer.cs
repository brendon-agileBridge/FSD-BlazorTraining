public class StateContainer
{
    public int Total { get; set; } = 0;

    public event Action OnChange;

    public void Increment(int value)
    {
        Console.WriteLine("Test" + value.ToString());
        Total += value;
        NotifyStateChanged();
    }
    
    public void Set(int value)
    {
        Total = value;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}