using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bb : MonoBehaviour
{
    public Levelincrement a;
    private int j = 0;
    private int k = 1;

    private int s;




    // Start is called before the first frame update
    void Start()
    {
        while (s <= 3)
        {
            a.spawnallpoints();
            s++;
        }

        StartCoroutine(ExampleCoroutine());

    }

    // Update is called once per frame
    void Update()
    {
        if (j == k)
        {
            a.spawnallpointsp();
            j++;

        }


    }
    IEnumerator ExampleCoroutine()
    {
        while (j <= k)
        {
            a.spawnallpoints();
            yield return new WaitForSeconds(10);
            j++;



        }

    }

}
