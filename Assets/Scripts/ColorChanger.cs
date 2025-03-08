using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _durarion;
    [SerializeField] private int _repeats;

    private void Start()
    {
        _meshRenderer.material.DOColor(_color, _durarion)
                              .SetLoops(_repeats, LoopType.Yoyo);
    }
}
