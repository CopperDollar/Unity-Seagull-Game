using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    

    public float deadZone = -5;

    void Update()
    {
        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
            //PoopMeterManager.instance.IncreasePoop(); //Kutsutaan poopmetermanageria. Koska se on static instance, sitä voidaan kutsua ilman sen ihmeempiä kiertelyitä.
        }
    }
}