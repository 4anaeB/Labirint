using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuarternionPrisma : MonoBehaviour
{
    public Vector3 RotationVelocity;
    private void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(RotationVelocity * Time.deltaTime);
        transform.rotation = deltaRotation * transform.rotation;

    }
}
