using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionScript : MonoBehaviour
{

    public GameObject walker;


  private void OnCollisionEnter(Collision collision)
  {
        if (collision.gameObject.tag == "Walker")
       {
            Debug.Log("Osuma!");
            //PointCounter.instance.addScore();
       }

    }
}
