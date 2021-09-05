using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHunger : MonoBehaviour
{
    public float maxHunger = 100f;
    
    public float currentHunger;

    public HungerBar hungerBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHunger = maxHunger;
        hungerBar.SetHunger(currentHunger);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            TakeDamage(20f);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHunger -= damage;
        hungerBar.SetHunger(currentHunger);
    }
}
