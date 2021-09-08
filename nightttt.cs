using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightttt : MonoBehaviour
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
                mm.gameObject.SetActive(true);
                nn.gameObject.SetActive(false);
            }
        }
    }
}
