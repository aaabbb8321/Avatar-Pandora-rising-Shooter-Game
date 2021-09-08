using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public int j;
    public Transform[] spawnlocation;
    public GameObject enemy;
    private int h;
    // Start is called before the first frame update
    void Start()
    {
        while(j<5)
        {
            SpawnAllpoints();
            j++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAllpoints()
    {
       h = Random.Range(0, spawnlocation.Length);
       Instantiate(enemy, spawnlocation[h].position, Quaternion.identity);
    }
}
