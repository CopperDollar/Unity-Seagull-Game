using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class DetectCollisionScript : MonoBehaviour
{


    private Renderer poop;
    private Rigidbody2D rb;
    public AudioSource splatSound;

    void Start()
    {

        poop = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody2D>();
        splatSound = GetComponent<AudioSource>();


    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Walker"))
        {

      
            poop.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            PointCounter.instance.addScore();
            splatSound.Play();
            Destroy(gameObject, 0.4f);
        }

        if (other.gameObject.CompareTag("Car"))
        {
            
            poop.enabled = false;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            PointCounter.instance.addScore();
            splatSound.Play();
            Destroy(gameObject, 0.4f);
        }
    }







}
