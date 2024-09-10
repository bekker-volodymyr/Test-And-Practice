using UnityEngine;

public class ChangeShaderProperty : MonoBehaviour
{
    [SerializeField]
    private Material _material;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _material.SetColor("_Color", Color.magenta);
        }
    }
}
