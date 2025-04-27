using UnityEngine;

public class EnemyHealth : MonoBehaviour , IDamageObject
{
    private int _health = 100;

    public virtual void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Disable();
    }

    protected virtual void Disable()
    {
        Destroy(gameObject);
    }
}
