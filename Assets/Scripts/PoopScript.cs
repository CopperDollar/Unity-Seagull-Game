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


    //public SeagullScript seagullScript;
    public GameObject newPoop;
    public Rigidbody2D myRigidbody;


    public float deadZone = -1;



    void Start()
    {
        SeagullScript seagullScript = GetComponent<SeagullScript>();

  


    }


    void Update()
    {



        //if (newPoop == null)
        //{
        Debug.Log("newPoop is null");
        //}

        //if (newPoop != null && newPoop.transform.position.y < deadZone)
        //{

          //  Destroy(newPoop);
        //}



    }


}


