using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwitcher : MonoBehaviour
{

    public Material[] material;
    public Renderer rend;
    public int matRandom;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        //rend.sharedMaterial = material[0];
    }

    void Update()
    {
       rend.sharedMaterial = material[matRandom];

    }
    // Update is called once per frame

}