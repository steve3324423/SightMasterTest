using System;
using UnityEngine;

public class EnemyHealth : MonoBehaviour , IDamageObject
{
    private int _health = 100;

    public event Action<int> ChangedHealth; 

    public virtual void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Disable();

        ChangedHealth?.Invoke(_health);
    }

    protected virtual void Disable()
    {
        Destroy(gameObject);
    }
}
