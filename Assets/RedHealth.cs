using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedHealth : MonoBehaviour
{
    Text redhp;
    void Start () {
        redhp = gameObject.GetComponent<Text>(); 
    }
    void Update()
    {
        redhp.text = "HP: " + RedMage.health;
    }
}
