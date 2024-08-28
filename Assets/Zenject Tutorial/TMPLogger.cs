using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMPLogger : ILogger
{
    public void Log(string message)
    {
        TextMeshProUGUI logField = GameObject.FindGameObjectWithTag("LogField").GetComponent<TextMeshProUGUI>();

        logField.text = message;
    }
}
