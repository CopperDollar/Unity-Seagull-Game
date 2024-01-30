using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using Random = System.Random;

public class CharacterSpawnerScript : MonoBehaviour
{
    static List<GameObject> characterList = new List<GameObject>();
    int characterListSize;
   // public randomCharacter;
    public GameObject redShirtBoy;
    public GameObject messyHairBoy;
    public GameObject redShirtChild;

    public GameObject selectedCharacter;
    
    Random randomNum = new Random();
    System.Random randomCharacter = new System.Random();

    public int spawnRate;
    private float timer = 0;





    void Start()
    {

        spawnRate = randomNum.Next(3, 5);
        characterList.Add(messyHairBoy);
        characterList.Add(redShirtBoy);
        characterList.Add(redShirtChild);

        characterListSize = characterList.Count;



    }


    void Update()
    {


        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {

            SpawnRandomCharacter();
            spawnRate = randomNum.Next(3, 5);
            timer = 0;
        }


    }




    void SpawnRandomCharacter()
    {
        int randomIndex = randomCharacter.Next(0, characterListSize);
        selectedCharacter = characterList[randomIndex];
        Instantiate(selectedCharacter, transform.position, transform.rotation);
    }




}

