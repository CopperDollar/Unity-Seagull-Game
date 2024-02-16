using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionScript : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Walker"))
        {
 
            PointCounter.instance.addScore();
        }

        if (other.gameObject.CompareTag("Car"))
        {
            PointCounter.instance.addScore();
        }
    }
}
