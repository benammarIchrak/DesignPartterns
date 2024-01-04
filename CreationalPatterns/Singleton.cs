namespace CreationalPatterns;

public class Singleton
{
    private static readonly object _lock = new object();
    private static Singleton? _instance;
    public string Value { get; set; } = null!;

    private Singleton()
    {
    }

    public static Singleton GetInstance(string value)
    {
        if (_instance != null) return _instance;
        lock (_lock)
        {
            Console.WriteLine("current Thread{0}", Thread.CurrentThread.Name);
            if (_instance != null) return _instance;
            _instance = new Singleton
            {
                Value = value
            };
        }

        return _instance;
    }
}

