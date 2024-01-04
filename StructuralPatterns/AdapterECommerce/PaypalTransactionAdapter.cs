namespace StructuralPatterns.AdapterECommerce;

public class PaypalTransactionAdapter: ITransaction
{
    private IPaypal _paypalAdapter;
    public PaypalTransactionAdapter(IPaypal paypalService)
    {
        this._paypalAdapter = paypalService;
    }
    public void Transact()
    {
        this._paypalAdapter.SendPayment();
    } 
}