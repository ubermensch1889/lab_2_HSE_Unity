using System;
using System.Collections.Generic;
using UnityEngine;

public class CardLayout : MonoBehaviour
{
    [SerializeField] 
    private int _layoutId;

    [SerializeField] 
    private Vector3 _offsеt;

    public void Update()
    {
        
        foreach (var card in CardGame.GetInstance().GetCardsInLayout(_layoutId))
        {
            CardGame.GetInstance().dictionary[card].transform.SetParent(transform);

            CardGame.GetInstance().dictionary[card].transform.position =
                transform.position + _offsеt * card.CardPosition;

            CardGame.GetInstance().dictionary[card].transform.SetSiblingIndex(card.CardPosition);
        }
    }
}