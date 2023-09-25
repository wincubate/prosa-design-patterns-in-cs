namespace Wincubate.SingletonExamples;

sealed class Magic
{
    public int Number { get; }

    public static Magic Instance
    {
        get
        {
            lock (_sync)
            {
                if (_instance is null)
                {
                    _instance = new Magic();
                }
                return _instance;
            }
        }
    }
    private static Magic? _instance;

    private static readonly object _sync = new();

    private Magic()
    {
        int[] numbers = { 42, 87, 112, 176, 1880 };

        Thread.Sleep(20); // <-- emulates that number is resource-intensive to create

        Random random = new(DateTime.Now.Millisecond);
        Number = numbers[random.Next(numbers.Length)];
    }
}
