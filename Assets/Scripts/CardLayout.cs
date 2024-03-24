using System;
using System.Collections.Generic;
using UnityEngine;

public class CardLayout : MonoBehaviour
{
    public int LayoutId { get; set; } = 0;
    
    public Vector2 Offsеt { get; set; }

    public void Update()
    {
        
        foreach (var card in CardGame.GetInstance().GetCardsInLayout(LayoutId)) 
        {
            
        }
    }
}