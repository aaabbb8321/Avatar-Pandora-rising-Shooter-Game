using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
    [SerializeField]
    private GameObject mainmenu;
    [SerializeField]
    private GameObject gun;
    [SerializeField]
    private GameObject dragon;
    [SerializeField]
    private GameObject network;
    [SerializeField]
    private GameObject load;
    [SerializeField]
    private GameObject lo;
    [SerializeField]
    private GameObject enemybutton;
    [SerializeField]
    private GameObject enemybuttonaa;
    [SerializeField]
    private GameObject a;
    [SerializeField]
    private GameObject ad;
    [SerializeField]
    private GameObject health;
    [SerializeField]
    private GameObject tharko;
    public static int pp;
    public static int cc;
    // Start is called before the first frame update
    void Awake()
    {
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(true);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        load.gameObject.SetActive(false);

        Playerhealth.currenthealth = 300f;
        enemybutton.gameObject.SetActive(false);
        a.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
        tharko.gameObject.SetActive(false);
        enemybuttonaa.gameObject.SetActive(false);



    }


    // Update is called once per frame
    void Update()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
           
            Debug.Log("available");
        }
        else
        {
            net();
            Debug.Log("not");
        }
        if (Stt.r == 0)
        {
            while(pp<1)
            {
                network.gameObject.SetActive(false);
                mainmenu.gameObject.SetActive(false);
                gun.gameObject.SetActive(false);
                dragon.gameObject.SetActive(false);

                load.gameObject.SetActive(false);
                enemybuttonaa.gameObject.SetActive(false);
                enemybutton.gameObject.SetActive(false);
                a.gameObject.SetActive(false);
                ad.gameObject.SetActive(true);
                health.gameObject.SetActive(false);
                tharko.gameObject.SetActive(false);
                pp++;
               

            }
    
        
        }
        if(Playerhealth.currenthealth <= 0f)
        {
            while (cc < 1)
            {
                network.gameObject.SetActive(false);
                mainmenu.gameObject.SetActive(false);
                gun.gameObject.SetActive(false);
                dragon.gameObject.SetActive(false);

                load.gameObject.SetActive(false);
                enemybuttonaa.gameObject.SetActive(false);
                enemybutton.gameObject.SetActive(false);
                a.gameObject.SetActive(false);
                ad.gameObject.SetActive(true);
                health.gameObject.SetActive(false);
                tharko.gameObject.SetActive(false);
                cc++;


            }
        }



    }

    public void opengun()
    {
        Playerhealth.currenthealth = 300f;
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(false);
        gun.gameObject.SetActive(true);
        dragon.gameObject.SetActive(false);
        enemybuttonaa.gameObject.SetActive(false);
        load.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
        enemybutton.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        tharko.gameObject.SetActive(false);
    }

    public void opendragon()
    {
        Playerhealth.currenthealth = 300f;
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(true);
        enemybuttonaa.gameObject.SetActive(false);
        load.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
        enemybutton.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        tharko.gameObject.SetActive(false);

    }

    public void openmainmenu()
    {
        Stt.r = 1;
        pp = 0;
        cc = 0;
        Playerhealth.currenthealth = 300f;
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(true);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(false);
        enemybuttonaa.gameObject.SetActive(false);
        load.gameObject.SetActive(false);

        enemybutton.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        tharko.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
    }

    public void loadlevel()
    {

        Playerhealth.currenthealth = 300f;
        load.gameObject.SetActive(false);
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(false);
        enemybutton.gameObject.SetActive(true);
        health.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
        tharko.gameObject.SetActive(false);
        enemybuttonaa.gameObject.SetActive(false);
    }

    public void loadlevelaa()
    {

        Playerhealth.currenthealth = 300f;
        load.gameObject.SetActive(false);
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(false);
        enemybutton.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
        tharko.gameObject.SetActive(false);
        enemybuttonaa.gameObject.SetActive(true);
    }

    public void enemybuttonn()
    {
        enemybuttonaa.gameObject.SetActive(false);

        load.gameObject.SetActive(true);
        Playerhealth.currenthealth = 300f;
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(false);
        enemybutton.gameObject.SetActive(false);
        a.gameObject.SetActive(true);
        health.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
        tharko.gameObject.SetActive(false);
    }
    public void healthh()
    {
        enemybuttonaa.gameObject.SetActive(false);
        Playerhealth.currenthealth = 300f;
        load.gameObject.SetActive(false);
        
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(false);
        enemybutton.gameObject.SetActive(false);
        a.gameObject.SetActive(false);
        health.gameObject.SetActive(true);
        tharko.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
    }

    public void dar()
    {
        enemybuttonaa.gameObject.SetActive(false);
        load.gameObject.SetActive(false);
        Playerhealth.currenthealth = 300f;
        network.gameObject.SetActive(false);
        mainmenu.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(false);
        enemybutton.gameObject.SetActive(false);
        a.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        tharko.gameObject.SetActive(true);
        ad.gameObject.SetActive(false);
    }
    public void net()
    {
        enemybuttonaa.gameObject.SetActive(false);
        Playerhealth.currenthealth = 300f;
        network.gameObject.SetActive(true);
        mainmenu.gameObject.SetActive(false);
        gun.gameObject.SetActive(false);
        dragon.gameObject.SetActive(false);
      
        load.gameObject.SetActive(false);

        enemybutton.gameObject.SetActive(false);
        a.gameObject.SetActive(false);
        ad.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        tharko.gameObject.SetActive(false);

    }


}

