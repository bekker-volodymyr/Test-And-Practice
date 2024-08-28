using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Messanger : MonoBehaviour
{
    [Inject] ILogger _logger;

    void Start()
    {
        _logger.Log("Logger have been injected to messanger");
    }

}
