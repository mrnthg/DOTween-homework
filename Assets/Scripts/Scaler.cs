using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _newScale;
    [SerializeField] private float _durarion;
    [SerializeField] private int _repeats;

    private void Start()
    {
        transform
            .DOScale(_newScale, _durarion)
            .SetLoops(_repeats, LoopType.Yoyo);
    }
}
