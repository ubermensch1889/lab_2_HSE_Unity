using System.Collections.Generic;
using UnityEngine;

public class CardGame : MonoBehaviour
{
    private Dictionary<CardInstance, CardView> _dictionary;
    
    [SerializeField]
    public List<CardAsset> startCards;

    private static CardGame _instance;

    private CardGame()
    {
        
    }

    public void Awake()
    {
        if (_instance != null)       
        {
            Debug.LogWarning("Error");
        }
        _instance = this;    
    }

    public static CardGame GetInstance()
    {
        return _instance;
    }

    public void StartGame()
    {
        foreach (var asset in startCards)
        {
            CreateCard(asset, 0);
        }
    }

    public void CreateCardView(CardInstance instance)
    {
        GameObject prefab = GameObject.Instantiate(instance.GetAsset().GetImage());
        prefab.AddComponent<CardView>();
        prefab.GetComponent<CardView>().Init(instance);
        _dictionary.Add(instance, prefab.GetComponent<CardView>());
    }

    public void CreateCard(CardAsset asset, int layoutNumber)
    {
        var cardInstance = new CardInstance(asset);
        
        
        cardInstance.MoveToLayout(layoutNumber);
        
    }

    public List<CardInstance> GetCardsInLayout(int layoutId)
    {
        List<CardInstance> list = new List<CardInstance>();
        foreach (var card in _dictionary.Keys) 
        {
            if (card.LayoutId == layoutId)
            {
                list.Add(card);
            }
        }

        return list;
    }
}