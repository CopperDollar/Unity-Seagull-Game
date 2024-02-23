using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class DetectCollisionScript : MonoBehaviour
{



    private AudioSource poopSound;

    void Start()
    {


        //poopSound = GetComponent<AudioSource>();




    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Walker"))
        {
 
            PointCounter.instance.addScore();

            //PlayPoopSound();
            //Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Car"))
        {
            PointCounter.instance.addScore();

            //PlayPoopSound();
            //Destroy(gameObject);
        }
    }



    //void PlayPoopSound()
    //{
    // poopSound.Play();

    // }


}
