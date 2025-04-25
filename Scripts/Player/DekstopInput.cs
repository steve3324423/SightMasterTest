using System;
using UnityEngine;

public class DekstopInput : IInput
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    private float _yPosition = 0f;

    public Vector3 GetDirection()
    {
        float horizontal = Input.GetAxis(Horizontal);
        float vertical = Input.GetAxis(Vertical);

        return new Vector3(horizontal, _yPosition, vertical);
    }
}
