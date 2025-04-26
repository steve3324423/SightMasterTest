using System;
using UnityEngine;

public interface IInput
{
    Vector3 GetDirection(Transform transform);

    Quaternion GetCameraRotation();
}
