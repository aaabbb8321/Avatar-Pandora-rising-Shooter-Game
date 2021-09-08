using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioscipt : MonoBehaviour
{
    [SerializeField]
    private AudioSource pp;
    [SerializeField]
    private AudioSource vv;
    [SerializeField]
    private AudioSource cc;
    [SerializeField]
    private AudioSource dd;
    // Start is called before the first frame update
    void Start()
    {
        pp.PlayDelayed(3f);
        vv.PlayDelayed(15f);
        cc.PlayDelayed(30f);
        dd.PlayDelayed(45f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
