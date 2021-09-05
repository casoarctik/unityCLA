using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

/* This object manages the inventory UI. */

public class InventoryUI : MonoBehaviour {

    public GameObject inventoryUI;	// The entire UI
    public Transform itemsParent;	// The parent object of all the items

    InventoryScript inventory;	// Our current inventory

    void Start ()
    {
        inventory = InventoryScript.instance;
        inventory.onItemChangedCallback += UpdateUI;
    }

    // Check to see if we should open/close the inventory
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            UpdateUI();
        }
    }

    // Update the inventory UI by:
    //		- Adding items
    //		- Clearing empty slots
    // This is called using a delegate on the Inventory.
    public void UpdateUI ()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
                slots[i].itemInventory.SetActive(true);

            }
            else
            {
                slots[i].ClearSlot();
            }
            
            if (slots[i].itemInventory.activeSelf && slots[i].icon.enabled == false)
            {
                slots[i].itemInventory.SetActive(false);
            }

        }
    }

    public void UpdateUIForFood()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();
        List<Item> foodItems = inventory.ShowFoodListItem();
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < foodItems.Count)
            {
                slots[i].AddItem(foodItems[i]);
                slots[i].itemInventory.SetActive(true);

            }
            else
            {
                slots[i].ClearSlot();
            }

            if (slots[i].itemInventory.activeSelf && slots[i].icon.enabled == false)
            {
                slots[i].itemInventory.SetActive(false);
            }

        }
    }
    
    public void UpdateUIForMeds()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();
        List<Item> medsItems = inventory.ShowMedsListItem();
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < medsItems.Count)
            {
                slots[i].AddItem(medsItems[i]);
                slots[i].itemInventory.SetActive(true);

            }
            else
            {
                slots[i].ClearSlot();
            }
            
            if (slots[i].itemInventory.activeSelf && slots[i].icon.enabled == false)
            {
                slots[i].itemInventory.SetActive(false);
            }

        }
    }
    
    public void UpdateUIForEquipement()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();
        List<Item> equipementItems = inventory.ShowEquipementListItem();
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < equipementItems.Count)
            {
                slots[i].AddItem(equipementItems[i]);
                slots[i].itemInventory.SetActive(true);

            }
            else
            {
                slots[i].ClearSlot();
            }
            
            if (slots[i].itemInventory.activeSelf && slots[i].icon.enabled == false)
            {
                slots[i].itemInventory.SetActive(false);
            }
        }
    }
    public void UpdateUIForClothes()
    {
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();
        List<Item> clothesItems = inventory.ShowClothesListItem();
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < clothesItems.Count)
            {
                slots[i].AddItem(clothesItems[i]);
                slots[i].itemInventory.SetActive(true);

            }
            else
            {
                slots[i].ClearSlot();
            }
            
            if (slots[i].itemInventory.activeSelf && slots[i].icon.enabled == false)
            {
                slots[i].itemInventory.SetActive(false);
            }

        }
    }
}