namespace StructuralPatterns.AdapterECommerce;

public class SquareTransactionAdapter: ITransaction {
    private ISquare _squareAdapter;    public SquareTransactionAdapter(ISquare squareService)
    {
        this._squareAdapter = squareService;
    }
    public void Transact()
    {
        this._squareAdapter.CreateTransaction();
    }
}