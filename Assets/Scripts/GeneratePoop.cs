
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePoop : MonoBehaviour
{
    public GameObject projectile;
    public GameObject poop;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (PoopMeterManager.instance.CheckIfEmpty() == false)
            {
                GameObject poop = Instantiate(projectile, transform.position, transform.rotation);
                PoopMeterManager.instance.DecreasePoop();
            }

            else
            {
                Debug.Log("kakkaa ei ole jäljellä");
            }
            

        }
    }
}