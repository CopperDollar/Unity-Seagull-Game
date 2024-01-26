using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public float moveSpeed = 7;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);

        }

    }

