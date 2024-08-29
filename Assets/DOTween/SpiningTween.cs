using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that start infinite spinning animation on the object
/// </summary>
public class SpiningTween : MonoBehaviour
{
    [SerializeField] private float _duration = 0.5f;

    void Start()
    {
        transform.DOLocalRotate(new Vector3(0, 360f, 0), _duration, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
    }
}
