using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogger : ILogger
{
    public void Log(string message)
    {
        Debug.Log(message);
    }
}
