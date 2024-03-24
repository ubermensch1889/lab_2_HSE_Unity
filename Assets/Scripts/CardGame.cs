using System.Collections.Generic;
using UnityEngine;

public class CardGame : MonoBehaviour
{
    public Dictionary<CardInstance, CardView> dictionary = new Dictionary<CardInstance, CardView>();
    
    [SerializeField]
    public List<CardAsset> startCards;

    private static CardGame _instance;

    // Чтобы указывать CardPosition при создании карт.
    private int position = 0;

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
        
        StartGame();
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

    private void CreateCardView(CardInstance instance)
    {
        GameObject prefab = Instantiate(instance.GetAsset().GetImage());
        prefab.AddComponent<CardView>();
        
        var view = prefab.GetComponent<CardView>();
        view.Init(instance);
        
        dictionary.Add(instance, view);
    }

    private void CreateCard(CardAsset asset, int layoutNumber)
    {
        var cardInstance = new CardInstance(asset);
        cardInstance.CardPosition = position++;
        
        CreateCardView(cardInstance);
        cardInstance.MoveToLayout(layoutNumber);
    }

    public List<CardInstance> GetCardsInLayout(int layoutId)
    {
        List<CardInstance> list = new List<CardInstance>();
        foreach (var card in dictionary.Keys) 
        {
            if (card.LayoutId == layoutId)
            {
                list.Add(card);
            }
        }

        return list;
    }
}