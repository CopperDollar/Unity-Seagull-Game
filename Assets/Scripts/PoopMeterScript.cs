using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoopMeterScript : MonoBehaviour
{
    public Slider slider;
    public GameObject poop;
    public PoopScript PoopScript;
    public int currentPoop;
    public int maxPoop;
    public int maxValue;




    public void SetPoopAmount(int currentPoop)
    {

        slider.value = currentPoop;
    }

    void Start()

    {
        maxValue = 15;
        PoopScript = GameObject.FindGameObjectWithTag("Poop").GetComponent<PoopScript>();
        //currentPoop = GetComponent<PoopScript>().currentPoop;
    }

    void Update()
    {
        SetPoopAmount(currentPoop);
    }



}
