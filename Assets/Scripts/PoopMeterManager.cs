using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Reflection;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PoopMeterManager : MonoBehaviour
{
    public static PoopMeterManager instance; //TÄMÄ mahdollistaa poopmeterin kutsumisen aivan mistä tahansa.
    public Slider poopMeter;
    public int maxPoop;
    public int currentPoop;

    private void Awake()
    {
        instance = this; //Awake tapahtuu jopa ennen Starttia. Tässä luodaan poopmeteristä instanssi, johon voi vaikuttaa mistä tahansa.
    }

    void Start()
    {
        poopMeter = (Slider)FindObjectOfType(typeof(Slider));
        poopMeter.maxValue = 20;
        maxPoop = Convert.ToInt32(poopMeter.maxValue);
        currentPoop = maxPoop;
    }

    public void DecreasePoop()
    {
        currentPoop -= 1;
        SetPoopAmount();
    }

   // public void IncreasePoop()
   // {
     //   currentPoop += 1;
       // SetPoopAmount();
   // }

    public void SetPoopAmount()
    {
        poopMeter.value = Convert.ToInt32(currentPoop);
    }

    public bool CheckIfEmpty()
    {
        if (poopMeter.value == 0)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

}