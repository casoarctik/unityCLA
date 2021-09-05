using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Image hunger0;

    public Image hunger1;

    public Image hunger2;

    public Image hunger3;

    public Image hunger4;
    
    public void SetHunger(float hunger)
    {
        switch (hunger)
        {
            case var n when (n >= 80f) :
                hunger0.enabled = true;
                hunger1.enabled = true;
                hunger2.enabled = true;
                hunger3.enabled = true;
                hunger4.enabled = true;
                break;
            
            case var n when (n < 80f && n>=60f) :
                hunger0.enabled = true;
                hunger1.enabled = true;
                hunger2.enabled = true;
                hunger3.enabled = true;
                hunger4.enabled = false;
                break;
            
            case var n when (n < 60f && n>=40f) :
                hunger0.enabled = true;
                hunger1.enabled = true;
                hunger2.enabled = true;
                hunger3.enabled = false;
                hunger4.enabled = false;
                break;
            
            case var n when (n < 40f && n>=20f) :
                hunger0.enabled = true;
                hunger1.enabled = true;
                hunger2.enabled = false;
                hunger3.enabled = false;
                hunger4.enabled = false;
                break;
            
            case var n when (n < 20f && n>0f) :
                hunger0.enabled = true;
                hunger1.enabled = false;
                hunger2.enabled = false;
                hunger3.enabled = false;
                hunger4.enabled = false;
                break;
            
            case var n when (n <= 0f) :
                hunger0.enabled = false;
                hunger1.enabled = false;
                hunger2.enabled = false;
                hunger3.enabled = false;
                hunger4.enabled = false;
                break;
        }
        
    }
    
}
