using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class network : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(Application.internetReachability != NetworkReachability.NotReachable)
        {
            Debug.Log("available");
        }
        else 
        {
            Debug.Log("not");
        }
        
    }

    // Update is called once per frame

}
