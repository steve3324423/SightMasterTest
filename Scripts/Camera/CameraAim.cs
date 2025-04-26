using UnityEngine;
using Zenject;

public class CameraAim : CameraHandler
{
    private IInput _input;

    [Inject]
    public void Construct(IInput input)
    {
        _input = input;
    }


    private void Update()
    {
        transform.localRotation = _input.GetCameraRotation();
    }
}
