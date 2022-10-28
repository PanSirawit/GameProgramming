using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPbar : MonoBehaviour
{
    private Slider slider;
    [SerializeField] private TMP_Text textDP;
    private int MaxValue;




    void Awake()
    {
        slider = GetComponent<Slider>();
    }
    public void Setup(int maxvalue)
    {
        this.MaxValue = maxvalue;
        slider.maxValue = maxvalue;
        slider.value = maxvalue;
        SetValue(maxvalue);
    }
    public void SetValue(int value)
    {
        slider.value = value;
        textDP.text = value + "/" + MaxValue;
    }
}
