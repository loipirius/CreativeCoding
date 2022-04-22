using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifier : MonoBehaviour
{
    private Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        InvokeRepeating("SizeChange", 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SizeChange()
    {
        var sizeChanger = Random.Range(10f, 100f);
        myTransform.localScale = new Vector3(sizeChanger, 1, sizeChanger);
    }
}
