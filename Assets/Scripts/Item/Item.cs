using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public int id;
    public string nameItem;
    public string description;
    public Sprite image;
    public bool isQuestItem; 
    public int rarity;
    public int typeItem;
    public int price; 
    public float healthGiven;
    public bool isMultiplicationHealthGiven;
    public float enduranceGiven;
    public bool isMultiplicationEnduranceGiven;
    public float hungerGiven;
    public bool isMultiplicationHungerGiven;
    
    // Called when the item is pressed in the inventory
    public virtual void Use ()
    {
        if (typeItem == 0 || typeItem == 1)
        {
            PlayerHealth.instance.TakeOrLoseHp(healthGiven);
            PlayerEndurance.instance.TakeOrLoseHe(enduranceGiven);
            PlayerHunger.instance.TakeOrLoseHh(hungerGiven);
            RemoveFromInventory();
        }

        if (typeItem == 2 || typeItem == 3)
        {
            Debug.Log("Feature en mise à jour");
        }
    }

    // Call this method to remove the item from inventory
    public void RemoveFromInventory ()
    {
        InventoryScript.instance.Remove(this);
    }
    
    //Show action type for the item
    public string GetAction()
    {
        string action; 
        switch (typeItem)
        {
            case 0:
                action = "manger";
                break;
            case 1 :
                action = "consommer";
                break;
            case 2:
                action = "équiper";
                break;
            case 3:
                action = "porter";
                break;
            default:
                action = "inconnu";
                break;
        }

        return action;
    }

    public string GetRarityName()
    {
        string rarityName;
        switch (rarity)
        {
            case 0:
                rarityName = "commun";
                break;
            case 1:
                rarityName = "rare";
                break;
            case 2:
                rarityName = "epic";
                break;
            case 3:
                rarityName = "légendaire";
                break;
            default:
                rarityName = "inconnu";
                break;
        }

        return rarityName;
    }
    public Color GetRarityColorCode()
    {
        Color rarityColor = new Color();
        switch (rarity)
        {
            case 0:
                rarityColor.r = 46 / 225f;
                rarityColor.g = 46 / 255f;
                rarityColor.b = 46 / 255f;
                rarityColor.a = 255 / 255f;
                break;
            case 1:
                rarityColor.r = 73 / 255f;
                rarityColor.g = 193 / 255f;
                rarityColor.b = 238 / 255f;
                rarityColor.a = 255 / 255f;
                break;
            case 2:
                rarityColor.r = 84 / 255f;
                rarityColor.g = 29 / 255f;
                rarityColor.b = 175 / 255f;
                rarityColor.a = 255 / 255f;
                break;
            case 3:
                rarityColor.r = 215 / 255f;
                rarityColor.g = 209 / 255f;
                rarityColor.b = 21 / 255f;
                rarityColor.a = 255 / 255f;
                break;
            default:
                rarityColor.r = 0 / 255f;
                rarityColor.g = 0 / 255f;
                rarityColor.b = 0 / 255f;
                rarityColor.a = 255 / 255f;
                break;
        }

        return rarityColor;
    }
}
