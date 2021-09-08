using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelenemyincrement : MonoBehaviour
{
    
    public int[] initialenemy;
    public int[] totalenemy;
    private int j;
    public Transform[] spawnlocation;
    public GameObject[] objectto;

    private int k;

    private int h;

    public Mainmenu a;
    




    // Start is called before the first frame update
    void Awake()
    {
        
        initialenemy = new int[4];
        initialenemy[0]= 4;
        initialenemy[1]= 5;
        initialenemy[2]= 6;
        initialenemy[3]= 7;

        totalenemy = new int[4];
        totalenemy[0] = 6;
        totalenemy[1] = 7;
        totalenemy[2] = 8;
        totalenemy[3] = 9;
       


    }

    void Start()
    {
        
      


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAllpoints()
    {
      
        int x = Random.Range(0, spawnlocation.Length);
        Instantiate(objectto[UnityEngine.Random.Range(0,objectto.Length)], spawnlocation[x].position, Quaternion.identity);
    }

    public void level1()
    {
        
        while (j <= initialenemy[0])
        {   
            SpawnAllpoints();
            j++;    
        }

      

        if(j == initialenemy[0] && k == totalenemy[0])
        {

        }

    }



}
