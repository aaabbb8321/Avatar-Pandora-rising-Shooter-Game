using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meethealth : MonoBehaviour
{

    Animator anim;
    public float enemyhealth = 100f;

    public GameObject player;
    public float damageenemy;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void DeductHealth(float deducthealth)
    {
        deducthealth = 10;
        enemyhealth -= deducthealth;
        

        if (enemyhealth <= 0)
        {
            EnemyDead();
        }
    }

    public void EnemyDead()
    {

        Destroy(player);
    }

   
       
}

