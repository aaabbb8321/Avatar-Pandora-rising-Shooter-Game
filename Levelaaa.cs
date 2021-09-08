using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelaaa : MonoBehaviour
{
    public Levelincrement a;
    public static int j = 0;
    private float interpolationPeriod = 12f;
    private float time = 0.0f;
    public static int s;
    public static int m;
    public static int k;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (m < 1)
        {
            a.spawnallpointsy();
            while (s < Stt.p)
            {
              
                a.spawnallpoints();
                s++;
            }

            m++;
        }
        if (j == Sttint.k)
        {
            a.spawnallpointsp();
            j++;
            Debug.Log("lllllllllll");

        }
        if(k<1)
        {
            StartCoroutine(ExampleCoroutine());
            k++;
        }

       
        
    }
    IEnumerator ExampleCoroutine()
    {
        while (j <= Sttint.k)
        {
            Debug.Log("pppppppppppppp");
            a.spawnallpoints();
            yield return new WaitForSeconds(12);
            j++;



        }

    }

}
