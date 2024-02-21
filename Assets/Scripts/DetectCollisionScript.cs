using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionScript : MonoBehaviour
{

    private ParticleSystem burst;
    private AudioSource poopSound;

    void Start()
    {
        poopSound = GetComponent<AudioSource>();
        burst = GetComponent<ParticleSystem>();
        if (burst == null)
        {
            Debug.LogError("burst effect not found!");
        }



    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Walker"))
        {
 
            PointCounter.instance.addScore();
            BurstPoop();
            PlayPoopSound();
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Car"))
        {
            PointCounter.instance.addScore();
            BurstPoop();
            PlayPoopSound();
            Destroy(gameObject);
        }
    }

    void BurstPoop()
    {
        burst.transform.position = gameObject.transform.position;
        burst.Play();
    }

    void PlayPoopSound()
    {
        if (poopSound != null)
        {
            Debug.Log("poopsound ei ole null");
            poopSound.Play();
        }

    }
}
