using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

public class ShakingFloorTween : MonoBehaviour
{
    private float _duration;
    private float _strength;
    private int _vibrato;
    private float _randomness;

    async void Start()
    {
        _duration = Random.Range(0.5f, 1.5f);
        _strength = 0.5f;
        _vibrato = 10;
        _randomness = 20f;

        // transform.DOShakePosition(_duration, _strength, _vibrato).SetLoops(-1);
        await Task.Delay(Random.Range(50, 1000));
        Sequence seq = DOTween.Sequence().SetLoops(-1);
        seq.Append(transform.DOShakePosition(_duration, _strength, _vibrato, _randomness, false, true, ShakeRandomnessMode.Harmonic));
        seq.AppendInterval(Random.Range(1f, 2f));
    }
}
