using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Messenger : MonoBehaviour
{
    // [Inject(Id = "Debug")] ILogger _logger;  // Injection to the field with id
    [Inject(Id ="Debug")] ILogger Logger { get; set; }       // Injection to prop

    [Inject]                                    // Method injection
    void Constract(ILogger logger)
    {
        Logger = logger;
    }

    void Start()
    {
        Logger.Log("Logger have been injected to messanger");
    }

}
