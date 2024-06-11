using DG.Tweening;
using UnityEngine;

public abstract class LoopTweenConfigurer : MonoBehaviour
{
    private int _loopsAmount;

    protected int LoopsAmount => _loopsAmount;

    private void Awake()
    {
        _loopsAmount = -1; 
    }

    public abstract void SetTweenParams(Tween tween);
}
