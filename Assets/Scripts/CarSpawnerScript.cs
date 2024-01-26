using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using Random = System.Random;

public class CarSpawnerScript : MonoBehaviour
{
    public GameObject car;
    Random randomNum = new Random();

    public int spawnRate;
    private float timer = 0;
   




    void Start()
    {
        
        spawnRate = randomNum.Next(3, 10);
        spawnCar();
    }


    void Update()
    {
        

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {

            spawnCar();
            spawnRate = randomNum.Next(3, 10);
            timer = 0;
        }


    }
    void spawnCar()
    {
       
        Instantiate(car, transform.position, transform.rotation);
        
    }


}

