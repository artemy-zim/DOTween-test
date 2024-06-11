using UnityEngine;

public abstract class TweenEffector : MonoBehaviour
{
    [SerializeField] private LoopTweenConfigurer _tweenConfigurer;
    [SerializeField] private float _duration;

    protected float Duration => _duration;
    protected LoopTweenConfigurer TweenConfigurer => _tweenConfigurer;

    private void Start()
    {
        ApplyTween();
    }

    protected abstract void ApplyTween();
}
