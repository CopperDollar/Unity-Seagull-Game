using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class SeagullScript : MonoBehaviour
{
    
    public Rigidbody2D myRigidbody;

    void Start()
    {
        
    }

    
    void Update()
    {

        
        if (Input.GetKey(KeyCode.Space))
        {
            
            myRigidbody.velocity = Vector2.up * 6;
        }
    }




}