using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOUiIntUpdate : MonoBehaviour
{
    public SOInt sOInt;
    public TextMeshProUGUI uiTextValue;

    void Start()
    {
        uiTextValue.text = sOInt.value.ToString();
    }

    
    void Update()
    {
        uiTextValue.text = sOInt.value.ToString();
    }
}
