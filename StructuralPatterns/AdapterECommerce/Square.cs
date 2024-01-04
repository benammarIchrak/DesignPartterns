namespace StructuralPatterns.AdapterECommerce;

public class Square: ISquare
{
    public void CreateTransaction()
    {
        Console.WriteLine("Square payment succeed!");
    }
}