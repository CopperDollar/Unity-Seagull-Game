using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class DetectCollisionScript : MonoBehaviour
{


    private Renderer poop;
    private AudioSource poopSound;
    private Rigidbody2D rb;

    void Start()
    {

        poop = GetComponent<Renderer>();
        poopSound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();



    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Walker"))
        {

      
            poop.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            PointCounter.instance.addScore();
            poopSound.Play();
            Destroy(gameObject, 0.4f);
        }

        if (other.gameObject.CompareTag("Car"))
        {
            
            poop.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            PointCounter.instance.addScore();
            poopSound.Play();
            Destroy(gameObject, 0.4f);
        }
    }






}
