using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailsItem : MonoBehaviour
{
    public GameObject detailsItem;
    public Text nameItem;
    public Text descriptionItem;
    public Text hpGiven;
    public Text fpGiven;
    public Text epGiven;
    public Text rarityItem;
    public Text priceItem;
    
    public void FillDetails(Item item)
    {
        nameItem.text = item.nameItem;
        descriptionItem.text = item.description;
        hpGiven.text = item.healthGiven.ToString();
        fpGiven.text = item.hungerGiven.ToString();
        epGiven.text = item.enduranceGiven.ToString();
        rarityItem.color = item.GetRarityColorCode();
        rarityItem.text = item.GetRarityName();
        priceItem.text = item.price + " €";

    }

    public void ShowDetails(Item item)
    {
        FillDetails(item);
        detailsItem.SetActive(true);
    }

    public void ExitDetails()
    {
        detailsItem.SetActive(false);
    }
    
}
