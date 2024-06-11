using DG.Tweening;
using UnityEngine;

public class Yoyo : LoopTweenConfigurer
{
    public override void SetTweenParams(Tween tween)
    {
        tween.SetLoops(LoopsAmount, LoopType.Yoyo);
    }
}
