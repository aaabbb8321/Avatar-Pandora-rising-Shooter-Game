using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballcollision : MonoBehaviour
{
    public float damageenemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
        {
            Playerhealth.currenthealth -= damageenemy;
        }
    }
}
      
