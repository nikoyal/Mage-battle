using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFireBall : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
    {
    if(col.gameObject.tag == "Blue Mage")
     {
        BlueMage.health -= 20;
     }
        Destroy(gameObject);
    }
}
