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
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myMaterial = myRenderer.material;

        PeakColor = myMaterial.GetColor("P_Color");
        ValleyColor = myMaterial.GetColor("V_Color");
        FresnelColor = myMaterial.GetColor("F_Color");
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.SetColor("P_Color", PeakColor);
        myMaterial.SetColor("V_Color", ValleyColor);
        myMaterial.SetColor("F_Color", FresnelColor);
    }
}
