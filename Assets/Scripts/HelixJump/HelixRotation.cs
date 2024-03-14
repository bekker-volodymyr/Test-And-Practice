using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixRotation : MonoBehaviour
{
    public float rotationSpeed = 60f;
    private bool isRotating = false;
    private Vector3 lastMousePosition;

    [SerializeField] private bool addDpi = true;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            Vector3 mouseDelta = addDpi ? (Input.mousePosition - lastMousePosition) * Screen.dpi / 96f : (Input.mousePosition - lastMousePosition);

            //Vector3 mouseDelta = (Input.mousePosition - lastMousePosition) * Screen.dpi / 96f;
            //Vector3 mouseDelta = (Input.mousePosition - lastMousePosition) * Screen.dpi / 160f;
            //Vector3 mouseDelta = (Input.mousePosition - lastMousePosition) / Screen.dpi;
            //Vector3 mouseDelta = (Input.mousePosition - lastMousePosition);
            float rotationAmount = mouseDelta.x * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, -rotationAmount);

            lastMousePosition = Input.mousePosition;

            
        }
    }
}
