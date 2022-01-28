using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float _thrust = 30.0f;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction, float speed)
    {
        _rigidbody.AddForce(direction * speed);
    }
    public void Jump()
    {
        _rigidbody.AddForce(transform.up * _thrust, ForceMode.Impulse);
    }
}
