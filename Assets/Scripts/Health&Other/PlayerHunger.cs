using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHunger : MonoBehaviour
{
    public float maxHunger = 100f;
    
    public float currentHunger;
    public static PlayerHunger instance;
    public HungerBar hungerBar;
    // Start is called before the first frame update
    
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerHunger dans la scène");
            return;
        }

        instance = this;
    }
    void Start()
    {
        currentHunger = maxHunger;
        hungerBar.SetHunger(currentHunger);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakeOrLoseHh(-20f);
        }

        if (PlayerEndurance.instance.currentEndurance <= 0.01f)
        {
            TakeOrLoseHh(-0.01f);
        }
    }

    public void TakeOrLoseHh(float hungerPoints)
    {
        if ((currentHunger + hungerPoints) > maxHunger)
        {
            currentHunger = maxHunger;
        }
        else if ((currentHunger + hungerPoints) < 0f)
        {
            currentHunger = 0;
            //Health --;
        }
        else
        {
            currentHunger += hungerPoints;
            
        }
        hungerBar.SetHunger(currentHunger);
    }
}
