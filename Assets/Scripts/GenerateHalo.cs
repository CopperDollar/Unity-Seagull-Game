using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEngine.ParticleSystem;

public class GenerateHalo : MonoBehaviour
{

    public ParticleSystem halo;

    void Start()
    {

        halo = GetComponentInChildren<ParticleSystem>();



    }


    void Update()
    {

     if (Input.GetKeyDown(KeyCode.H))
        {
            halo.Play();
        }

      
    
    
    }


}





