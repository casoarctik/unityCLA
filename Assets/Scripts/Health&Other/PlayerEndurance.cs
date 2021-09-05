using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerEndurance : MonoBehaviour
{
    public float maxEndurance = 100f;
    
    public float currentEndurance;

    public EnduranceBar enduranceBar;

    public PlayerMovement playerMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        
        currentEndurance = maxEndurance;
        enduranceBar.SetMaxEndurance(maxEndurance);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.isRunning)
        {
            LoseEnduranceOnRun();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            TakeDamage(20f);
        }

        Fill();

    }

    void LoseEnduranceOnRun()
    {
        if (currentEndurance > 0f)
        {
            currentEndurance = currentEndurance - 0.010f;
            enduranceBar.SetEndurance(currentEndurance);
        }

        if (currentEndurance < 0f)
        {
            currentEndurance = 0f;
        }
    }

    void Fill()
    {
        if (currentEndurance < maxEndurance)
        {
            currentEndurance = currentEndurance + 0.005f;
            enduranceBar.SetEndurance(currentEndurance);
        }

        if (currentEndurance > maxEndurance)
        {
            currentEndurance = maxEndurance;
        }
    }
    void TakeDamage(float damage)
    {
        currentEndurance -= damage;
        enduranceBar.SetEndurance(currentEndurance);
    }
}
