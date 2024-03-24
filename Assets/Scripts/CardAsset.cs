using Enums;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "new Card", fileName = "Card")]
public class CardAsset : ScriptableObject
{
    [SerializeField]
    private CardNamesEnum _cardName;

    [SerializeField] 
    private CardColorsEnum _color;

    [SerializeField] 
    private Image _image;

    public CardColorsEnum GetColor() => _color;

    public CardNamesEnum GetName() => _cardName;

    public Image GetImage() => _image;
}