using System.Collections;
using UnityEngine;

public class CameraShakeHandler : MonoBehaviour
{
    [SerializeField] private ShootHandler _shootHandler;

    private Vector3 _recoilDirection = new Vector3(-.4f, 0, 0f);
    private float _speed = 5f;

    private void OnEnable()
    {
        _shootHandler.Shooted += OnShooted;
    }

    private void OnDisable()
    {
        _shootHandler.Shooted -= OnShooted;
    }

    private void OnShooted()
    {
        StartCoroutine(Recoil());
    }

    private IEnumerator Recoil()
    {
        float time = .2f;
        Vector3 initialRotation = transform.localEulerAngles;

        while (time > 0)
        {
            transform.localEulerAngles = Vector3.Lerp(transform.localEulerAngles + _recoilDirection, transform.localEulerAngles,_speed * Time.deltaTime);
            time -= Time.deltaTime;
            yield return null;
        }

        transform.localEulerAngles = initialRotation;
    }
}
