
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePoop : MonoBehaviour
{
    public GameObject projectile;
    public GameObject poop;
    public AudioSource poopingSound;

    private void Start()
    {
        poopingSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (PoopMeterManager.instance.CheckIfEmpty() == false)
            {
                GameObject poop = Instantiate(projectile, transform.position, transform.rotation);
                poopingSound.Play();
                PoopMeterManager.instance.DecreasePoop();
            }
            

        }
    }
}