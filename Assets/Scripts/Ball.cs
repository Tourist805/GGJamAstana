using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private Health _health;
    [SerializeField]private float _fireDamage = 1.0f;
    [SerializeField] private float _thrust = 30.0f;
    private bool _onGround;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _onGround = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Surface surface))
        {
            _onGround = true;
        }
        if(other.TryGetComponent(out Damagable damagable))
        {
            _health.TakeDamage(_fireDamage);
            Debug.Log(_health.HitPoints);
        }
    }
    public void Jump()
    {
        _rigidbody.velocity = Vector3.zero;
       
        _rigidbody.AddForce(transform.up * _thrust, ForceMode.Impulse);
    }
}
