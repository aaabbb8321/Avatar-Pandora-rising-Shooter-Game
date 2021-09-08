using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    public Slider healthslider;
    public float maxhealth;
    public static float currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth; 
    }

    // Update is called once per frame
    void Update()
    {
        healthslider.value = currenthealth;
        
    }

}
