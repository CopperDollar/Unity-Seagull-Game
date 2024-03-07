using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class FoodSpawnerScript : MonoBehaviour
{
    public static List<GameObject> foodList = new List<GameObject>();
    int foodListSize;

    public GameObject apple;
    public GameObject orange;
    public GameObject pineapple;
    public GameObject selectedFood;

    Random randomNum = new Random();
    System.Random randomFood = new System.Random();

    public int spawnRate;
    private float timer = 0;
    void Start()
    {
        spawnRate = randomNum.Next(3, 5);
        foodList.Add(apple);
        foodList.Add(orange);
        foodList.Add(pineapple);

        foodListSize = foodList.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {

            SpawnRandomFood();
            spawnRate = randomNum.Next(20, 40);
            timer = 0;
        }
    }

    void SpawnRandomFood()
    {
        int randomIndex = randomFood.Next(0, foodListSize);
        selectedFood = foodList[randomIndex];
        Instantiate(selectedFood, transform.position, transform.rotation);
    }
}
