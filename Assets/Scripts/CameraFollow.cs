using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Vector3 offset;

    private void Start()
    {
        offset = transform.position - _ball.transform.position;
    }
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = _ball.transform.position + offset;
    }
}
