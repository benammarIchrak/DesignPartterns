namespace StructuralPatterns.AdapterECommerce;

public class PaymentProvider
{
    private readonly IPaypal _paypalService;
    private readonly ISquare _squareService;
    private readonly IStripe _stripeService;

    public PaymentProvider(IStripe stripeService, ISquare squareService, IPaypal paypalService)
    {
        _stripeService = stripeService;
        _squareService = squareService;
        _paypalService = paypalService;
    }
    public void Pay(PaymentMethod choice)
    {
        switch (choice)
        {
            case PaymentMethod.PayPal:
            {
                ITransaction paypalTransactionAdapter = new PaypalTransactionAdapter(_paypalService);
                paypalTransactionAdapter.Transact();
                break;
            }
            case PaymentMethod.Square:
            {
                ITransaction squareTransactionAdapter = new SquareTransactionAdapter(_squareService);
                squareTransactionAdapter.Transact();
                break;
            }
            case PaymentMethod.Stripe:
            {
                ITransaction stripeTransactionAdapter = new StripeTransactionAdapter(_stripeService);
                stripeTransactionAdapter.Transact();
                break;
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(choice), choice, null);
        }
    }
}

public enum PaymentMethod
{
    PayPal,
    Square,
    Stripe
}