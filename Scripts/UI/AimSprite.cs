using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class AimSprite : MonoBehaviour
{
    [SerializeField] private Aim _aim;

    private RawImage _rawImage;

    private void Awake()
    {
        _rawImage = GetComponent<RawImage>();
    }

    private void OnEnable()
    {
        _aim.Aimed += OnAimed;
    }

    private void OnDisable()
    {
        _aim.Aimed -= OnAimed;
    }

    private void OnAimed(bool isAimed)
    {
        _rawImage.enabled = isAimed;
    }
}
