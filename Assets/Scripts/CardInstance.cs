

public class CardInstance
{
    private CardAsset _asset;

    public CardInstance(CardAsset asset)
    {
        _asset = asset;
    }

    public CardAsset GetAsset() => _asset;
    
    public int LayoutId { get; private set; }
    
    public int CardPosition { get; private set; }
    
    public void MoveToLayout(int layoutNumber)
    {
        LayoutId = layoutNumber;
        
    }
    
}