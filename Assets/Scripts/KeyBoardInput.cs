using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardInput : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;
    [SerializeField] private Ball _ball;
    [SerializeField] private float _acceleration = 2.0f;

    [Header("Particles")]
    [SerializeField] private GameObject _accelerationParticle;

    [Header("Audio Effect")]
    [SerializeField] private AudioSource _movingAudio = null;
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        _movement.Move(new Vector3(horizontal, 0, vertical));
        if(Input.GetKey(KeyCode.LeftShift))
        {
            _movement.Move(new Vector3(horizontal * _acceleration, 0, vertical * _acceleration));
            Instantiate(_accelerationParticle, transform.position, Quaternion.identity);
        }
        if(Input.GetButton("Jump"))
        {
            _ball.Jump();
        }
    }
}
