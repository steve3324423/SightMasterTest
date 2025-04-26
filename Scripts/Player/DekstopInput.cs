using System;
using UnityEngine;

public class DekstopInput : IInput
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";
    private const string MouseX = "Mouse X";
    private const string MouseY = "Mouse Y";

    private float _xRotation;
    private float _yRotation;
    private float _zRotation = 0f;
    private float _degree = 60f;

    public Vector3 GetDirection(Transform transform)
    {
        float horizontal = Input.GetAxis(Horizontal);
        float vertical = Input.GetAxis(Vertical);

        return transform.right * horizontal + transform.forward * vertical;
    }

    public Quaternion GetCameraRotation()
    {
        float mouseX = Input.GetAxis(MouseX);
        float mouseY = Input.GetAxis(MouseY);

        _yRotation += mouseX;
        _xRotation -= mouseY;

        _yRotation = Mathf.Clamp(_yRotation, -_degree, _degree); 
        _xRotation = Mathf.Clamp(_xRotation, -_degree, _degree);

        return Quaternion.Euler(_xRotation, _yRotation, _zRotation);
    }
}
