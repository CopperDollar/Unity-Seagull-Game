using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodKillScript : MonoBehaviour
{
    public GameObject seagull;

    void Start()
    {


    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Seagull"))
        {
            PoopMeterManager.instance.IncreasePoop();
            Destroy(gameObject);



        }

    }

}
