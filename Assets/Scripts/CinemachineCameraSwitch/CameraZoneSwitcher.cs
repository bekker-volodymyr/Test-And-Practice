using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEditor;
using System;

public class CameraZoneSwitcher : MonoBehaviour
{
    public string triggerTag;

    public CinemachineVirtualCamera primaryCamera;

    public CinemachineVirtualCamera[] virtualCameras;

    void Start()
    {
        SwitchCamera(primaryCamera);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(triggerTag))
        {
            CinemachineVirtualCamera targetCamera = other.GetComponentInChildren<CinemachineVirtualCamera>();
            SwitchCamera(targetCamera);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag(triggerTag))
        {
            SwitchCamera(primaryCamera);
        }
    }

    private void SwitchCamera(CinemachineVirtualCamera targetCamera)
    {
        foreach(var cam in virtualCameras)
        {
            cam.enabled = cam == targetCamera;
        }
    }

    [ContextMenu("Get All Virtual Cameras")]
    private void GetAllVirtualCameras()
    {
        virtualCameras = GameObject.FindObjectsOfType<CinemachineVirtualCamera>();
    }
}
