using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _newPosition;
    [SerializeField] private float _durarion;
    [SerializeField] private int _repeats;

    private void Start()
    {
        transform
            .DOMove(_newPosition, _durarion)
            .SetLoops(_repeats, LoopType.Yoyo);
    }
}
