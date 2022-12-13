using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 60 == 0)
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}
