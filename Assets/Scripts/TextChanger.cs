using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _durarion;

    private float _durarionStartingMethod = 2f;

    private void Start()
    {
        Invoke("SubstitutionText", _durarionStartingMethod);
    }

    private void SubstitutionText()
    {
        _text.DOText("���� ��������!", _durarion);

        Invoke("AdditionText", _durarionStartingMethod);
    }

    private void AdditionText()
    {
        _text.DOText("��� �����?", _durarion)
             .SetRelative();

        Invoke("OverrideSubstitutionEffectText", _durarionStartingMethod);
    }

    private void OverrideSubstitutionEffectText()
    {
        _text.DOText("��� �, ���� ���� �� �����.", _durarion, true, ScrambleMode.Numerals);
    }
}
