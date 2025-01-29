
public class PurchaseAction : IAction
{
    public ActionType GetActionType() => ActionType.Shop;

    private ShopCurrency _shopCurrency;
    private Unit _soldUnit;
    private int _shopIndex;

    public PurchaseAction(ShopCurrency shopCurrency, int shopIndex)
    {
        _shopCurrency = shopCurrency;
        _shopIndex = shopIndex;
    }

    public void Execute()
    {
        _shopCurrency.PurchaseUnit(_shopIndex);
    }

    public void Undo()
    {
        _shopCurrency.SellUnit(_shopIndex);
    }
}
