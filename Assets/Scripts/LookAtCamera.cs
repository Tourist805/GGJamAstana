using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private float _movementSpeed;

    private void LateUpdate()
    {
        transform.LookAt(target.transform);
        transform.position = transform.position + new Vector3(0, 0, _movementSpeed * Time.deltaTime);
    }
}
