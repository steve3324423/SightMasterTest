using System;
using UnityEngine;
using Zenject;

public class ShootHandler : MonoBehaviour
{
    [SerializeField] private Aim _aim;

    private IInputWeapon _inputWeapon;
    private bool _isAimed;

    public event Action Shooted;

    [Inject]
    public void Construct(IInputWeapon inputWeapon)
    {
        _inputWeapon = inputWeapon;
    }

    private void OnEnable()
    {
        _aim.Aimed += OnAimed;
    }

    private void OnDestroy()
    {
        _aim.Aimed -= OnAimed;
    }

    private void Update()
    {
        if (_isAimed && _inputWeapon.IsShoot())
            Shooted?.Invoke();
    }

    private void OnAimed(bool isAimed)
    {
        _isAimed = isAimed;
    }
}
