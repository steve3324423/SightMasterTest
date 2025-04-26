using UnityEngine;
using Zenject;

public class CameraMover : CameraHandler
{
    [SerializeField] private Transform _target;

    private float _speed = 3f;
    private float _height = 3f;
    private float _rearDistance = 5f;

    private void Start()
    {
        transform.position = new Vector3(_target.position.x, _target.position.y + _height, _target.position.z - _rearDistance);
        transform.rotation = Quaternion.LookRotation(_target.position - transform.position);
    }

    private void Update()
    {
        Vector3 currentVector = new Vector3(_target.position.x, _target.position.y + _height, _target.position.z - _rearDistance);
        transform.position = Vector3.Lerp(transform.position, currentVector, _speed * Time.deltaTime);
    }

    protected override void OnAimed(bool isAimed)
    {
        Camera.enabled = !isAimed;
    }
}
