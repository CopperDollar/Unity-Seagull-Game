using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFillSound : MonoBehaviour
{
    public AudioSource fillSound;
    void Start()
    {
        fillSound = GetComponent<AudioSource>();
    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            fillSound.Play();

        }

        if (other.gameObject.CompareTag("Orange"))
        {
            fillSound.Play();

        }

        if (other.gameObject.CompareTag("Pineapple"))
        {
            fillSound.Play();

        }
    }
}
