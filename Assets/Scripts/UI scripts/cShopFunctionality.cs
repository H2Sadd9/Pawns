﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cShopFunctionality : MonoBehaviour
{
    LevelManager lmi;
    public float maxHealthObtainable = 500;
    private void Start()
    {
        lmi = LevelManager.instance;
    }

    public void BuyMaxHealth(float cost, int playerChar)
    {
        if (purchased(cost))
        {
            lmi.playerCharactersAlive[playerChar].playerAIScript.health = lmi.playerCharactersAlive[playerChar].playerAIScript.maxHealth;
        }
    }

    public void BuyIncreasedMaxHealth(float cost, int playerchar, float amount)
    {
        if (purchased(cost))
        {
            lmi.playerCharactersAlive[playerchar].playerAIScript.maxHealth += amount;
        }
    }

    bool purchased(float cost)
    {
        if (lmi.playersMoney - cost >= 0)
        {
            lmi.playersMoney -= cost;
            return true;
        }
        return false;
    }

}
