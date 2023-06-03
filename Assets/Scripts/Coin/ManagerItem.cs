using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Singleton;
using TMPro;

public class ManagerItem : Singleton<ManagerItem>
{
    public SOInt coins;
    public SOInt potion;

    
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextPotions;

    private void Start()
    {
        Reset();
    }

   

    private void UpdateUI()
    {
        //uiTextCoins.text = coins.ToString();
    }

    private void Reset()
    {
        potion.value = 0;
        coins.value = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        UpdateUI();
        

    }
    public void AddPotions(int amount = 1)
    {
        potion.value += amount;
        UpdateUI();
    }
   
}
