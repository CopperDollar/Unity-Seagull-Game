using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBurst : MonoBehaviour
{
    public GameObject poop;
    public ParticleSystem burst;

    void Start()
    {

        burst = GetComponentInChildren<ParticleSystem>();



    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Walker"))
        {

            Debug.Log("kakka osui ihmiseen");
            burst.Play();

   
            

        }

        if (other.gameObject.CompareTag("Car"))
        {

            Debug.Log("kakka osui autoon");
            burst.Play();


        }
    }

}
