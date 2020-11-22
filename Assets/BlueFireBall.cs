using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFireBall : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
    {
     if(col.gameObject.tag == "Red Mage")
     {
        RedMage.health -= 20;
     }
        Destroy(gameObject);
    }
}
