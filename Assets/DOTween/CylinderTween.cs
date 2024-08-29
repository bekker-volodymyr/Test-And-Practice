using UnityEngine;
using DG.Tweening;

/// <summary>
/// Simple class that moves the object up and down when arrows is pressed.
/// </summary>
public class CylinderTween : MonoBehaviour
{
    [Space]
    [SerializeField] private float _minY;
    [SerializeField] private float _maxY;

    [Space]
    [SerializeField] private float _duration;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) transform.DOLocalMoveY(_minY, _duration).SetEase(Ease.InSine);
        if(Input.GetKeyDown(KeyCode.UpArrow)) transform.DOLocalMoveY(_maxY, _duration).SetEase(Ease.OutSine);
    }
}
