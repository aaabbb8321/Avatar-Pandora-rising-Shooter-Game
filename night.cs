using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class night : MonoBehaviour
{
    [SerializeField]
    private GameObject nn;
    [SerializeField]
    private GameObject mm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            {
                nn.gameObject.SetActive(true);
                mm.gameObject.SetActive(false);
            }
        }
    }
}
