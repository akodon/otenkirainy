using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraraineffect : MonoBehaviour
{
    [SerializeField] private Shader shader;
    [SerializeField, Range(0, 1)] private float rainAmount = 0.5f;
    [SerializeField, Range(0, 1)] private float lighting = 1.0f;
    [SerializeField, Range(0, 1)] private float vignete = 1.0f;

    private Material mat;

    private void Awake()
    {
        mat = new Material(shader);
    }
    private void Update()
    {
        mat.SetFloat("_RainAmount", rainAmount);
        mat.SetFloat("_Lightning", lighting);
        mat.SetFloat("_Vignette", vignete);
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, mat);
    }

}
