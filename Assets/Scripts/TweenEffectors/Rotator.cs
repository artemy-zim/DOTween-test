using DG.Tweening;
using UnityEngine;

public class Rotator : TweenEffector
{
    [SerializeField] private float _delta;

    private Vector3 _rotation;

    private void Awake()
    {
        _rotation = new Vector3(0, _delta, 0);
    }

    protected override void ApplyTween()
    {
        Tween tween = transform.DORotate(_rotation, Duration, RotateMode.FastBeyond360);
        TweenConfigurer.SetTweenParams(tween);

        tween.Play();
    }
}
