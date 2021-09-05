using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    #region Singleton

    public static InventoryScript instance;

    void Awake ()
    {
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 15;	// Amount of item spaces

    // Our current list of items in the inventory
    public List<Item> items = new List<Item>();

    // Add a new item if enough room
    public void Add (Item item)
    {
        
        if (items.Count >= space) {
            Debug.Log ("Not enough room.");
            return;
        }

        items.Add (item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke ();
        
    }

    // Remove an item
    public void Remove (Item item)
    {
        items.Remove(item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }
    
    //All food Items
    public List<Item> ShowFoodListItem()
    {
        List<Item> foodItems = new List<Item>();
        foreach (Item item in items)
        {
            if (item.typeItem == 0)
            {
                foodItems.Add(item);
            }
        }

        return foodItems;

    }
    
    //All Meds Items
    public List<Item> ShowMedsListItem()
    {
        List<Item> medsItems = new List<Item>();
        foreach (Item item in items)
        {
            if (item.typeItem == 1)
            {
                medsItems.Add(item);
            }
        }

        return medsItems;

    }
    //All equipements Items
    public List<Item> ShowEquipementListItem()
    {
        List<Item> equipementItems = new List<Item>();
        foreach (Item item in items)
        {
            if (item.typeItem == 2)
            {
                equipementItems.Add(item);
            }
        }

        return equipementItems;

    }
    
    //All clothes Items
    public List<Item> ShowClothesListItem()
    {
        List<Item> clotheItems = new List<Item>();
        foreach (Item item in items)
        {
            if (item.typeItem == 3)
            {
                clotheItems.Add(item);
            }
        }

        return clotheItems;

    }

}