using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Colorer : TweenEffector
{
    [SerializeField] private Color _color;

    private Material _material;

    private void Awake()
    {
        ChangeMaterial();
    }

    protected override void ApplyTween()
    {
        Tween tween = _material.DOColor(_color, Duration);
        TweenConfigurer.SetTweenParams(tween);

        tween.Play();
    }

    private void ChangeMaterial()
    {
        Renderer renderer = GetComponent<Renderer>();
        _material = new Material(renderer.material);
        renderer.material = _material;
    }
}
