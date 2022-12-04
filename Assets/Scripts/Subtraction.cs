using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Subtraction : MonoBehaviour
{
    public Vector3 V1;
    public Vector3 V2;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        DrawVector(transform.position, V1);
        Gizmos.color = Color.blue;
        DrawVector(transform.position, V2);
        Gizmos.color = Color.black;
        DrawVector(transform.position + V2,  V1 - V2);
        Vector3 V3 = V1 - V2;
        double length = Math.Pow((Math.Pow(V3.x, 2) + Math.Pow(V3.y, 2) + Math.Pow(V3.z, 2)), 0.5);

        Debug.Log("Distance between Base and the Generator " + length);


    }
    private void DrawVector(Vector3 start, Vector3 vector)
    {
        Gizmos.DrawRay(start, vector);
        Gizmos.DrawSphere(start + vector, 0.25f);

    }
}
