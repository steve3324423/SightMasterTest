using UnityEngine;

public class HeadEnemy : EnemyHealth
{
    private int _damage = 100;

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(_damage);
    }

    protected override void Disable()
    {
        Destroy(transform.parent.gameObject);
    }
}
