using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetStealth(int value)
    {
        slider.value = value;
    }

    public void SetMaxStealth(int maxValue)
    {
        slider.maxValue = maxValue;
    }
}
