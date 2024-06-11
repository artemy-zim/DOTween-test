using DG.Tweening;
using UnityEngine;

public class Linear : LoopTweenConfigurer
{
    public override void SetTweenParams(Tween tween)
    {
        tween.SetEase(Ease.Linear).SetLoops(LoopsAmount);
    }
}
