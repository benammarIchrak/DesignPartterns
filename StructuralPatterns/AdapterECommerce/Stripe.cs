namespace StructuralPatterns.AdapterECommerce;

public class Stripe :IStripe
{
    public void MakePayment()
    {
        Console.WriteLine("Stripe payment succeed!");
    }
}