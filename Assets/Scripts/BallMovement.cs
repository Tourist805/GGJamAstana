using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Ball _ball;
    private bool grounded = false;
    public float MovementSpeed = 10;
    public float TurningSpeed = 60;
    private void Start()
    {
        _ball = FindObjectOfType<Ball>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Surface surface))
        {
            grounded = true;
            Debug.Log(grounded);
        }
            
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _ball.Jump();
        }
        float horizontal = Input.GetAxis("Horizontal") * TurningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * MovementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
