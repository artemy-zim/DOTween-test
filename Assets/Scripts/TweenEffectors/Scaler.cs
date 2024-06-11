using DG.Tweening;
using UnityEngine;

public class Scaler : TweenEffector
{
    [SerializeField] private float _delta;

    protected override void ApplyTween()
    {
        Tween tween = transform.DOScale(_delta, Duration);
        TweenConfigurer.SetTweenParams(tween);

        tween.Play();
    }
}
