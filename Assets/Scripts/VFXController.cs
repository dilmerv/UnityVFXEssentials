using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class VFXController : MonoBehaviour
{
    [SerializeField]
    private VisualEffect visualEffect;

    [SerializeField, Range(0, 5)]
    private float meteorIntensity = 0;

    [SerializeField]
    private Gradient meteorGradient = null;

    [SerializeField, Range(0, 0.5f)]
    private float meteorSize = 0;

    void Update()
    {
        visualEffect.SetFloat("MeteorIntensity", meteorIntensity);
        visualEffect.SetFloat("MeteorSize", meteorSize);
        visualEffect.SetGradient("MeteorGradient", meteorGradient);
    }
}
