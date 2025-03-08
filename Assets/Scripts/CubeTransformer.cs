using UnityEngine;
using DG.Tweening;

public class CubeTransformer : MonoBehaviour
{
    [SerializeField] private int _repeats;

    [Header("Scale")]
    [SerializeField] private Vector3 _newScale;
    [SerializeField] private float _durarionScale;

    [Header("Position")]
    [SerializeField] private Vector3 _newPosition;
    [SerializeField] private float _durarionPosition;

    [Header("Rotation")]
    [SerializeField] private Vector3 _newRotationAngle;
    [SerializeField] private float _durarionRotate;

    private void Start()
    {
        CubeScale();
        CubeMove();
        CubeRotate();
    }

    private void CubeScale()
    {
        transform
            .DOScale(_newScale, _durarionScale)
            .SetLoops(_repeats, LoopType.Yoyo);
    }

    private void CubeMove()
    {
        transform
            .DOMove(_newPosition, _durarionPosition)
            .SetLoops(_repeats, LoopType.Yoyo);
    }

    private void CubeRotate()
    {
        transform
            .DORotate(_newRotationAngle, _durarionRotate, RotateMode.FastBeyond360)
            .SetLoops(_repeats, LoopType.Restart);
    }
}
