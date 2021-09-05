using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnduranceBar : MonoBehaviour
{
    public Slider slider;
   
    public void SetMaxEndurance(float endurance)
    {
        slider.maxValue = endurance;
        slider.value = endurance;
    }

    public void SetEndurance(float endurance)
    {
        slider.value = endurance;
    }
}
