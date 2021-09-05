using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/* Sits on all InventorySlots. */

public class InventorySlot : MonoBehaviour {

    public Image icon;
    public GameObject itemInventory;
    public GameObject actionsAndInfosPanel;
    public Text nameItem;
    public Text actionType;

    public DetailsItem detailsItem;
    
    Item item;	// Current item in the slot
    

    // Add item to the slot
    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.image;
        icon.enabled = true;
        
    }

    // Clear the slot
    public void ClearSlot ()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        
    }

    // If the remove button is pressed, this function will be called.
    public void RemoveItemFromInventory ()
    {
        InventoryScript.instance.Remove(item);
    }

    // Use the item
    public void UseItem ()
    {
        if (item != null)
        {
            item.Use();
        }
    }
    
    //Show actions & infos panel of item if item button is pressed
    public void ShowActionsAndInfosItem()
    {
        if (item != null)
        {
            if (!actionsAndInfosPanel.activeSelf)
            {
                actionsAndInfosPanel.SetActive(true);
                nameItem.text = item.nameItem;
                actionType.text = item.GetAction();
            }
            else
            {
                actionsAndInfosPanel.SetActive(false);
            }
        }
    }
    
    //Show details of item if details button is pressed
    public void ShowDetailsItem()
    {
        if (item != null)
        {
            detailsItem.ShowDetails(item);
        }
        else
        {
            Debug.LogWarning("ici");
        }
        
    }
    
    
    
    

}