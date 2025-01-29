
public class SellAction : IAction
{
    public ActionType GetActionType() => ActionType.Shop;

    private ShopCurrency _shopCurrency;
    private Unit _soldUnit;
    private int _unitIndex;

    public SellAction(ShopCurrency shopCurrency, int unitIndex)
    {
        _shopCurrency = shopCurrency;
        _unitIndex = unitIndex;
    }

    public void Execute()
    {
        _soldUnit = _shopCurrency.SellUnit(_unitIndex);
    }

    public void Undo()
    {
        if (_soldUnit != null)
        {
            _shopCurrency.RebuyUnit(_soldUnit, _unitIndex);
        }
    }
}
