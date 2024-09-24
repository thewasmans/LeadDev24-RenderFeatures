using DG.Tweening;
using UnityEngine;

public class OpenDoorOnPlayerDetection : MonoBehaviour
{
    [SerializeField] private Transform _door;
    [SerializeField] private float _rotationValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        _door.DORotate(Vector3.up * -_rotationValue, 1).SetEase(Ease.InOutBack);
    }
}
