using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] protected Image Slider;

    public void OnValueChanged(int value, int maxValue)
    {
        Slider.fillAmount = (float)value / maxValue;
    }
}
