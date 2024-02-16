using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using Random = System.Random;

public class CarSpawnerScript : MonoBehaviour
{

    public static List<GameObject> carList = new List<GameObject>();
    int carListSize;

    public GameObject redCar;
    public GameObject blueVan;
    public GameObject blackCar;
    public GameObject greenVan;
    public GameObject blackVan;

    public GameObject selectedCar;

    Random randomNum = new Random();
    System.Random randomCar = new System.Random();

    public int spawnRate;
    private float timer = 0;
   




    void Start()
    {
        
        spawnRate = randomNum.Next(3, 10);

        carList.Add(redCar);
        carList.Add(blueVan);
        carList.Add(blackCar);
        carList.Add(greenVan);
        carList.Add(blackVan);
        carListSize = carList.Count;
        //spawnCar();
    }


    void Update()
    {
        

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {

            SpawnRandomCar();
            spawnRate = randomNum.Next(3, 10);
            timer = 0;
        }


    }
    void SpawnRandomCar()
    {
       
        int randomIndex = randomCar.Next(0, carListSize);
        selectedCar = carList[randomIndex];
        Instantiate(selectedCar, transform.position, transform.rotation);
     }
        
        
    


}

