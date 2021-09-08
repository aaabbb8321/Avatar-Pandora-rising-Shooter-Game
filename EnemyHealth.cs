using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Animator anim;
    public float enemyhealth = 100f;
   
    
    public bool isdead;
    public int p;
    public int n=1;





    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
        isdead = false;

    } 

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("death", false);

    }

    public void DeductHealth(float deducthealth)
    {
  
        deducthealth = 10;
        enemyhealth -= deducthealth;

        if(enemyhealth<=0)
        {
          

            anim.SetBool("death", true);
            isdead = true;
            while(p<n)
            {
                Coin.score += 3;
                PlayerPrefs.SetInt("score", Coin.score);
                Coin.mainscore += 1;
                PlayerPrefs.SetInt("mainscore", Coin.mainscore);
                Stt.r--;
                p++;

            }
           

           


            EnemyDead();
        }
    }

    public void EnemyDead()
    {
        
        Destroy(gameObject,6f);
        Debug.Log("22");
        





    }
    public void pp()
    {
   

    }

}
