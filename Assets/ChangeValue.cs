using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChangeValue : MonoBehaviour
{
    public Material myMaterial = null;
    public bool sphereVisible;
    public GameObject sphere;
    public Color PeakColor;
    public Color ValleyColor;
    public Color FresnelColor;

    public Vector3 minScale;
    public Vector3 maxScale;
    public float scaleSpeed = 1f;
    public float duration = 5f;

    IEnumerator LerpScape(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * scaleSpeed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            sphere.transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }
    
    private void Start()
    {
        if (myMaterial != null)
        {
            PeakColor = myMaterial.GetColor("P_Color");
            ValleyColor = myMaterial.GetColor("V_Color");
            FresnelColor = myMaterial.GetColor("F_Color");
        }

    }

    public void ChangeFresnel()
    {
        myMaterial.SetColor("F_Color", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));

    }
    
    public void ChangeValley()
    {
                myMaterial.SetColor("V_Color", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
    }

    public void SphereState()
    {
        myMaterial.SetColor("P_Color", Color.black);
        myMaterial.SetColor("V_Color", Color.black);
        myMaterial.SetColor("F_Color", Color.black);
    }

    public void SphereReduce()
    {
        StartCoroutine(LerpScape(maxScale, minScale, duration));
    }
}
