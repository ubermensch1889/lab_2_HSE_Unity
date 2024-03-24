using UnityEngine;

public class CardView : MonoBehaviour
{
    private CardInstance _instance;

    public void Init(CardInstance instance)
    {
        _instance = instance;
    }
}