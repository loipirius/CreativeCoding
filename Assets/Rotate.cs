using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform myTransform;
    public Camera myCam;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        myCam = GetComponent<Camera>();
        myCam.clearFlags = CameraClearFlags.Nothing;
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.Rotate(0, 0, 0.01f);
    }
}
