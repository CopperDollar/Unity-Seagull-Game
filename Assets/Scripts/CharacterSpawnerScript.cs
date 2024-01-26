using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using Random = System.Random;

public class CharacterSpawnerScript : MonoBehaviour
{
    public GameObject character;
    Random randomNum = new Random();

    public int spawnRate;
    private float timer = 0;





    void Start()
    {

        spawnRate = randomNum.Next(3, 15);
        spawnCharacter();
    }


    void Update()
    {


        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {

            spawnCharacter();
            spawnRate = randomNum.Next(3, 15);
            timer = 0;
        }


    }
    void spawnCharacter()
    {

        GameObject newCharacter = Instantiate(character, transform.position, transform.rotation);

    }


}

