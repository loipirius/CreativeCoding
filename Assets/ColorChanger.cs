using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public MeshRenderer myRenderer;
    public Material myMaterial;
    public Color PeakColor;
    public Color ValleyColor;
    public Color FresnelColor;
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        
        PeakColor = myMaterial.GetColor("P_Color");
        ValleyColor = myMaterial.GetColor("V_Color");
        FresnelColor = myMaterial.GetColor("F_Color");
    }

    // Update is called once per frame
    void Update()
    {
        PeakColor = Color.HSVToRGB(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        //ValleyColor = Color.HSVToRGB(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        //FresnelColor = Color.HSVToRGB(transform.rotation.x, transform.rotation.y, transform.rotation.z);

        myMaterial.SetColor("P_Color", PeakColor);
        //myMaterial.SetColor("V_Color", ValleyColor);
        //myMaterial.SetColor("F_Color", FresnelColor);
    }
}
