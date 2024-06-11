using DG.Tweening;
using UnityEngine;

public class Mover : TweenEffector
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _delta;

    private Vector3 _normalizedDirection;

    private void Awake()
    {
        _normalizedDirection = _direction.normalized;
    }

    protected override void ApplyTween()
    {
        Tween tween = transform.DOMove(transform.position + (_normalizedDirection * _delta), Duration);
        TweenConfigurer.SetTweenParams(tween);

        tween.Play();
    }
}
