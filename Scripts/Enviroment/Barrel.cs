using UnityEngine;

public class Barrel : MonoBehaviour , IDamageObject
{
    [SerializeField] private GameObject _explosionEffect;

    private float _radius = 15f;
    private int _damage = 100;

    public void TakeDamage(int damage)
    {
        SetDamageEnviroment();
        Instantiate(_explosionEffect,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }

    private void SetDamageEnviroment()
    {
       // Collider[] hitColliders = Physics.OverlapSphere(transform.position, _radius);
       // foreach (var hitCollider in hitColliders)
       // {
         //   if(hitCollider.TryGetComponent(out IDamageObject damageObject))
         //   {
         //       damageObject.TakeDamage(_damage);
         //   }
       // }
    }
}
