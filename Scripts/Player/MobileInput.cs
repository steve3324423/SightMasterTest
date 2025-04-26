using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MobileInput : IInput
{
    public Vector3 GetDirection(Transform transform)
    {
        return Vector3.zero;
    }

    public Quaternion GetCameraRotation()
    {
        return Quaternion.identity;
    }
}
