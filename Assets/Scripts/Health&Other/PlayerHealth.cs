using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    
    public static PlayerHealth instance;
    public float currentHealth;

    public HealthBar healthBar;
    
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerHealth dans la scène");
            return;
        }

        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeOrLoseHp(-20f);
        }

        if (PlayerHunger.instance.currentHunger == 0f)
        {
            TakeOrLoseHp(-0.002f);
        }
    }

    public void TakeOrLoseHp(float healthPoints)
    {
        if ((currentHealth + healthPoints) > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else if ((currentHealth + healthPoints) < 0f)
        {
            currentHealth = 0;
            //Die();
        }
        else
        {
            currentHealth += healthPoints;
            
        }
        healthBar.SetHealth(currentHealth);
    }
}
