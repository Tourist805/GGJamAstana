using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Ball _ball;

    private void Start()
    {
        _ball = FindObjectOfType<Ball>();
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            _ball.Jump();
        }
    }
}
