namespace StructuralPatterns.AdapterECommerce;

public class Paypal : IPaypal
{
    public void SendPayment()
    {
        Console.WriteLine("Paypal payment succeed!");
    }
}