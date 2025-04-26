using UnityEngine;

[RequireComponent(typeof(Camera))]
public abstract class CameraHandler : MonoBehaviour
{
    [SerializeField] private Aim _aim;

    protected Camera Camera;

    private void Awake()
    {
        Camera = GetComponent<Camera>();
    }

    private void OnEnable()
    {
        _aim.Aimed += OnAimed;
    }

    private void OnDisable()
    {
        _aim.Aimed -= OnAimed;
    }

    protected virtual void OnAimed(bool isAimed)
    {
        Camera.enabled = isAimed;
    }
}
