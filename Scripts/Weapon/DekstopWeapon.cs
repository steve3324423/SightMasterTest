using UnityEngine;

public class DekstopWeapon : IInputWeapon
{
    public bool IsAimed()
    {
        return Input.GetMouseButton(1);
    }

    public bool IsShoot()
    {
        return Input.GetMouseButton(0);
    }
}
