namespace StructuralPatterns.AdapterECommerce;

public class StripeTransactionAdapter: ITransaction {
    private IStripe _stripeAdapter;    public StripeTransactionAdapter(IStripe stripeService)
    {
        this._stripeAdapter = stripeService;
    }
    public void Transact()
    {
        this._stripeAdapter.MakePayment();
    }
}