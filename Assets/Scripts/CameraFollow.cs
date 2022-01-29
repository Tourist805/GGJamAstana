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
    void Update()
    {
        transform.position = _ball.transform.position + offset;
    }
}
