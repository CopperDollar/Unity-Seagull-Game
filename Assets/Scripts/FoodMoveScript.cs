using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMoveScript : MonoBehaviour
{

    public float moveSpeed = 4;
    public float deadZone = -10;


    void Start()
    {

    }


    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < deadZone)
        {

            Destroy(gameObject);




        }

    }
}
