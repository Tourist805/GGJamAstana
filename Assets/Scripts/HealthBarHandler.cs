using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHandler : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Image _healthBarImage;

    public void UpdateHealthBar()
    {
        _healthBarImage.fillAmount = Mathf.Clamp(_health.HitPoints / _health.MaxHealth, 0, 1f);
    }
}
