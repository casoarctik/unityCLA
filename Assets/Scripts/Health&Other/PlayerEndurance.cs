using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerEndurance : MonoBehaviour
{
    public float maxEndurance = 100f;
    
    public float currentEndurance;
    public static PlayerEndurance instance;
    
    public EnduranceBar enduranceBar;

    public PlayerMovement playerMovement;
    
    
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerEndurance dans la scène");
            return;
        }

        instance = this;
    }
    
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

        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeOrLoseHe(-20f);
        }

        Fill();

    }

    void LoseEnduranceOnRun()
    {
        if (currentEndurance > 0f)
        {
            currentEndurance = currentEndurance - 0.015f;
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
    public void TakeOrLoseHe(float endurancePoints)
    {
        if ((currentEndurance + endurancePoints) > maxEndurance)
        {
            currentEndurance= maxEndurance;
        }
        else if ((currentEndurance + endurancePoints) < 0f)
        {
            currentEndurance = 0;
            //hunger++;
        }
        else
        {
            currentEndurance += endurancePoints;
            
        }
        enduranceBar.SetEndurance(currentEndurance);
    }
}
