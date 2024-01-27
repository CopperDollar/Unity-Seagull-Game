using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using System.Reflection;




public class PoopScript : MonoBehaviour
{
    //public LogicScript logic;

    public Slider poopMeter;
    public GameObject poopPrefab;
    public GameObject seagull;
    public GameObject newPoop;
    public Rigidbody2D myRigidbody;


    public List<GameObject> poopList = new List<GameObject>();
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
                poopList.Add(newPoop);
            

            DecreasePoop();
            SetPoopAmount();

            }

        for (int i = 0; i < poopList.Count; i++)
        //if (newPoop != null && newPoop.transform.position.y < deadZone)
        {

            if (poopList[i] != null && poopList[i].transform.position.y < deadZone)
            {
                DestroyPoop(i);
            }
            
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

    public void DestroyPoop(int index)
    {
        //Destroy(newPoop);
        Destroy(poopList[index]);
        poopList.RemoveAt(index);

    }








    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    // logic.addScore();

    //}
}


