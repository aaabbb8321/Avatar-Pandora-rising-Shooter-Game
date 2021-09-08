using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelincrement : MonoBehaviour
{

    private int j;
    public Transform[] spawnlocation;
    public GameObject[] objectto;
    [SerializeField]
    private Transform enemya;
    [SerializeField]
    private Transform enemyaa;
    [SerializeField]
    private Transform enemyb;
    [SerializeField]
    private Transform enemybb;
    [SerializeField]
    private Transform enemyc;
    [SerializeField]
    private Transform enemycc;










    // Start is called before the first frame update
    void Awake()
    {




    }

    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {

    }
    public void spawnallpoints()
    {
        Debug.Log("meet");
        int x = Random.Range(0, spawnlocation.Length);
        Instantiate(objectto[UnityEngine.Random.Range(0, objectto.Length)], spawnlocation[x].position, Quaternion.identity);
        Stt.r++;
      
    }
    public void spawnallpointsp()
    {
        Debug.Log("p");
        int x = Random.Range(0, spawnlocation.Length);
        Instantiate(objectto[UnityEngine.Random.Range(0, objectto.Length)], spawnlocation[x].position, Quaternion.identity);
        

    }

    public void spawnallpointsy()
    {
      
        Instantiate(enemya, enemyaa.position, Quaternion.identity);
        Stt.r++;
        Instantiate(enemyb, enemybb.position, Quaternion.identity);
        Stt.r++;
        Instantiate(enemyc, enemycc.position, Quaternion.identity);
        Stt.r++;

    }



}
