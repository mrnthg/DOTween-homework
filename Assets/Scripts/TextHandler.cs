using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextHandler : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _durarion;
    [SerializeField] private float _durarionInterval;

    private Sequence _textSequence;

    private void Start()
    {
        _textSequence = DOTween.Sequence();

        _textSequence
            .Append(_text.DOText("ћен€ измен€ют!", _durarion))
            .PrependInterval(_durarionInterval)
            .Append(_text.DOText(" то здесь?", _durarion)
                            .SetRelative())
            .PrependInterval(_durarionInterval)
            .Append(_text.DOText("Ёто €, твой друг не бойс€.", _durarion, true, ScrambleMode.Numerals));
    } 
}
