using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aa : MonoBehaviour
{
    public Levelincrement a;
    private int j=0;
    private float interpolationPeriod=12f;
    private float time = 0.0f;
    private int s;
    public static int m;



    // Start is called before the first frame update
    void Start()
    {
 
      
    }

    // Update is called once per frame
    void Update()
    {
        if(m<1)
        {
            while (s < Stt.p)
            {
                a.spawnallpoints();
                s++;
            }

            m++;
        }
       if(j==Sttint.k)
       {
            a.spawnallpointsp();
            j++;
            Debug.Log("lllllllllll");

       }
      
        time += Time.deltaTime;
        if (time == interpolationPeriod)
        {
            time = 0.0f;
            Debug.Log("time");
            while (j <= Sttint.k)
            {
                Debug.Log("pppppppppppppp");
                a.spawnallpoints();
               
                j++;



            }

            // execute block of code here
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
