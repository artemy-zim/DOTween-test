using DG.Tweening;

public class LinearYoyo : LoopTweenConfigurer
{
    public override void SetTweenParams(Tween tween)
    {
        tween.SetEase(Ease.Linear).SetLoops(LoopsAmount, LoopType.Yoyo);
    }
}
