using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : TweenEffector
{
    [SerializeField] private Text _text;

    private Sequence _sequence;
    private string _textChange;
    private string _textAdd;
    private string _textChangeScrumble;

    private void Awake()
    {
        _sequence = DOTween.Sequence();
        _textChange = "Текст заменился";
        _textAdd = "Текст добавился";
        _textChangeScrumble = "Текст заменился перебором";
    }

    protected override void ApplyTween()
    {
        _sequence.Append(_text.DOText(_textChange, Duration))
                 .Append(_text.DOText(_textAdd, Duration).SetRelative())
                 .Append(_text.DOText(_textChangeScrumble, Duration, true, ScrambleMode.Uppercase));
        TweenConfigurer.SetTweenParams(_sequence);

        _sequence.Play();
    }
}
