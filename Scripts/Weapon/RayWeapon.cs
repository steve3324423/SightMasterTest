using UnityEngine;

public class RayWeapon : MonoBehaviour
{
    [SerializeField] private WeaponAmmo _weaponAmmo;
    [SerializeField] private int _damage = 10;
    [SerializeField] private Transform _camera;

    private RaycastHit _hit;

    private void OnEnable()
    {
        _weaponAmmo.Shooted += OnShooted;
    }

    private void OnDestroy()
    {
        _weaponAmmo.Shooted -= OnShooted;
    }

    private void OnShooted()
    {
        if (Physics.Raycast(_camera.position,_camera.forward,out _hit) && _hit.collider.TryGetComponent(out IDamageObject damageObject))
        {
            damageObject.TakeDamage(_damage);
        }
    }
}
