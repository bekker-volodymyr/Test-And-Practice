using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that move and rotate object.
/// </summary>
public class SawBladeTween : MonoBehaviour
{
    [Space]
    [SerializeField] private float _startX;
    [SerializeField] private float _endX;

    [Space]
    [SerializeField] private float _duration = 5f;

    void Start()
    {
        // Sequence seq = DOTween.Sequence().SetLoops(-1);
        // seq.Append(transform.DOLocalMoveX(_endX, _duration).SetEase(Ease.Linear));
        // seq.Append(transform.DOLocalMoveX(_startX, _duration).SetEase(Ease.Linear));
        
        transform.DOLocalMoveX(_endX, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        
        transform.DOLocalRotate(new Vector3(0f, 0f, 360f),_duration/3, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1);
    }
}
