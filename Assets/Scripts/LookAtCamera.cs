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
        //transform.rotation *= Quaternion.FromToRotation(Vector3.up, Vector3.forward);
    }
}
