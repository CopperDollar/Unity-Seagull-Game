using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;




public class PoopScript : MonoBehaviour
{
    //public LogicScript logic;

    public Slider poopMeter;
    public GameObject poopPrefab;
    public GameObject seagull;
    public GameObject newPoop;
    public Rigidbody2D myRigidbody;


    public int maxPoop;
    public int currentPoop;
    public bool poopInstantiated = false;
    public float deadZone = -3;






    void Start()
    {
        //logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        seagull = GameObject.Find("Seagull");
        poopPrefab = GameObject.Find("Poop");
        //poopMeter = (Slider)FindObjectOfType(typeof(Slider));

        poopMeter.maxValue = 20;
        maxPoop = Convert.ToInt32(poopMeter.maxValue);
        currentPoop = maxPoop;
      




    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {


                Poop();
                //poopInstantiated = true;

            

            DecreasePoop();
            SetPoopAmount();

            }


        if (newPoop != null && newPoop.transform.position.y < deadZone)
        { 
            DestroyPoop();
            //poopInstantiated = false;
        }
                
        
        

    }




    public void SetPoopAmount()
    {
 
        poopMeter.value = Convert.ToInt32(currentPoop);


    }


    public void Poop()
    {
        Vector3 spawnPosition = seagull.transform.position + new Vector3(-0.3f, -0.8f, 0);
        newPoop = Instantiate(poopPrefab, spawnPosition, Quaternion.identity);
        myRigidbody = newPoop.GetComponent<Rigidbody2D>();


    }


    public void DecreasePoop()
    {
        currentPoop -= 1;

    }

    public void DestroyPoop()
    {
        Destroy(newPoop);

    }








    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    // logic.addScore();

    //}
}


