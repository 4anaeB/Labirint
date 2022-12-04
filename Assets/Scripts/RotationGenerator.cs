using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class RotationGenerator : MonoBehaviour
{
    public Transform LookAt;

    void Update()
    {
        Vector3 forward = (LookAt.position - transform.position).normalized;
        

        transform.rotation = Quaternion.LookRotation(forward);
    }
}
