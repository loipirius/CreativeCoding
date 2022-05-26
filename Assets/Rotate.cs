using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform myTransform;
    public Camera myCam;
    public float rotationspeed = 10f;

void OnMouseDrag()
{
float rotx= Input.GetAxis("Mouse X") * rotationspeed;
float roty = Input.GetAxis("Mouse Y") * rotationspeed;

Vector3 right = Vector3.Cross(myCam.transform.up, transform.position - myCam.transform.position);
Vector3 up = Vector3.Cross(transform.position - myCam.transform.position, right);
transform.rotation = Quaternion.AngleAxis(-rotx, up) * transform.rotation;
transform.rotation = Quaternion.AngleAxis(roty, right) * transform.rotation;
}

}