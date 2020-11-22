using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BluHealth : MonoBehaviour
{
    Text bluhp;
    void Start () {
        bluhp = gameObject.GetComponent<Text>(); 
    }
    void Update()
    {
        bluhp.text = "HP: " + BlueMage.health;
    }
}
