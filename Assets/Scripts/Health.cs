using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] protected float _hitPoints = 10.0f;
    [SerializeField] private bool _destroyOnDeath = true;

    public UnityAction OnDead, OnHealthChange;

    public float HitPoints { get { return _hitPoints; } }

    public void TakeDamage(float damagePoints)
    {
        _hitPoints -= damagePoints;
        Debug.Log(HitPoints);

        OnHealthChange?.Invoke();

        if(_hitPoints <= 0)
        {
            OnDead?.Invoke();
            if(_destroyOnDeath)
            {
                Destroy(gameObject);
            }
        }
    }

    public bool IsDead()
    {
        return _hitPoints <= 0;
    }
}
