using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public Text healthNumber;
    
    public void SetMaxHealth(float health)
    {
        SetNumberHealth(health);
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        SetNumberHealth(health);
        slider.value = health;
    }

    private void SetNumberHealth(float health)
    {

        this.healthNumber.text = health + "%";
    }
}
