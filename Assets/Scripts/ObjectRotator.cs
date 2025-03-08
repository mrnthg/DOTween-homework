using UnityEngine;
using DG.Tweening;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private Vector3 _newRotationAngle;
    [SerializeField] private float _durarion;
    [SerializeField] private int _repeats;

    private void Start()
    {
        transform
            .DORotate(_newRotationAngle, _durarion, RotateMode.FastBeyond360)
            .SetLoops(_repeats, LoopType.Restart);
    }
}
