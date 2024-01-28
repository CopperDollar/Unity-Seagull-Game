using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Reflection;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class SeagullScript : MonoBehaviour
{
    
    public Rigidbody2D myRigidbody;

    public GameObject seagull;
    public GameObject poopPrefab;
    public GameObject newPoop;
    public Slider poopMeter;

    public int maxPoop;
    public int currentPoop;



    void Start()
    {
        poopMeter = (Slider)FindObjectOfType(typeof(Slider));
        poopPrefab = GameObject.Find("Poop");
        poopMeter.maxValue = 20;
        maxPoop = Convert.ToInt32(poopMeter.maxValue);
        currentPoop = maxPoop;
    }

    
    void Update()
    {

        
        if (Input.GetKey(KeyCode.Space))
        {
            
            myRigidbody.velocity = Vector2.up * 6;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {

            Poop();
            DecreasePoop();
            SetPoopAmount();

        }


    }


    public void Poop()
    {
        Vector3 spawnPosition = seagull.transform.position + new Vector3(-0.3f, -0.8f, 0);
        newPoop = Instantiate(poopPrefab, spawnPosition, Quaternion.identity);

    }

    public void DecreasePoop()
    {
        currentPoop -= 1;

    }

    public void SetPoopAmount()
    {

        poopMeter.value = Convert.ToInt32(currentPoop);

    }





}