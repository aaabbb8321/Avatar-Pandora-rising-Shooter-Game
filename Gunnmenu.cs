using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gunnmenu : MonoBehaviour
{
    [SerializeField]
    private AudioSource pp;
    [SerializeField]
    private AudioSource vv;



    [SerializeField]
    public Button aa;


    //2//
    [SerializeField]
    private Button gunb;
    [SerializeField]
    private Button bb;
    //3//
    [SerializeField]
    private Button gunc;
    [SerializeField]
    private Button cc;
    //4//
    [SerializeField]
    private Button gund;
    [SerializeField]
    private Button dd;
    //5
    [SerializeField]
    private Button gune;
    [SerializeField]
    private Button ee;
    //6//
    [SerializeField]
    private Button gunf;
    [SerializeField]
    private Button ff;




    private int ismet=1;
    private int isb;
    private int isc;
    private int isd;
    private int ise;
    private int isf;


    void Start()
    {
        pp.PlayDelayed(75f);
        vv.PlayDelayed(85f);
        if (isb == 1)
        {
            gunb.gameObject.SetActive(false);
        }
        if (isc == 1)
        {
            gunc.gameObject.SetActive(false);
        }
        if (isd == 1)
        {
            gune.gameObject.SetActive(false);
        }
        if (ise == 1)
        {
            gune.gameObject.SetActive(false);
        }
        if (isf == 1)
        {
            gunf.gameObject.SetActive(false);
        }



    }



    // Start is called before the first frame update
    void Update()
    {

        ismet = PlayerPrefs.GetInt("ismet");
        isb = PlayerPrefs.GetInt("isb");
        isc = PlayerPrefs.GetInt("isc");
        isd = PlayerPrefs.GetInt("isd");
        ise = PlayerPrefs.GetInt("ise");
        isf = PlayerPrefs.GetInt("isf");
   


        //1

        //2
        if (Coin.score > 50 && isb == 0)
        {
            gunb.interactable = true;

        }
        else
        {
            gunb.interactable = false;



        }
        //2
        if (isb == 0)
        {
            bb.gameObject.SetActive(false);

        }
        //3
        if (Coin.score > 100 && isc == 0)
        {
            gunc.interactable = true;

        }
        else
        {
            gunc.interactable = false;



        }

        if (isc == 0)
        {
            cc.gameObject.SetActive(false);

        }
        //4
        if (Coin.score > 200 && isd == 0)
        {
            gund.interactable = true;

        }
        else
        {
            gund.interactable = false;



        }

        if (isd == 0)
        {
            dd.gameObject.SetActive(false);

        }
        //5
        if (Coin.score > 300 && ise == 0)
        {
            gune.interactable = true;

        }
        else
        {
            gune.interactable = false;



        }

        if (ise == 0)
        {
            ee.gameObject.SetActive(false);

        }
        //6
        if (Coin.score > 400 && isf == 0)
        {
            gunf.interactable = true;

        }
        else
        {
            gunf.interactable = false;



        }

        if (isf == 0)
        {
            ff.gameObject.SetActive(false);

        }


    }


    public void buyguna()
    {
        PlayerPrefs.SetInt("ismet", 1);

        Coin.score -= 0;
        



    }
   

    public void buygunb()
    {
        PlayerPrefs.SetInt("isb", 1);

        Coin.score -= 50;
 

        gunb.gameObject.SetActive(false);
        bb.gameObject.SetActive(true);


    }

    public void buygunc()
    {
        PlayerPrefs.SetInt("isc", 1);

        Coin.score -= 100;
     

        gunc.gameObject.SetActive(false);
        cc.gameObject.SetActive(true);


    }

    public void buygund()
    {
        PlayerPrefs.SetInt("isd", 1);

        Coin.score -= 200;
       

        gund.gameObject.SetActive(false);
        dd.gameObject.SetActive(true);


    }

    public void buygune()
    {
        PlayerPrefs.SetInt("ise", 1);

        Coin.score -= 300;
   

        gune.gameObject.SetActive(false);
        ee.gameObject.SetActive(true);


    }

    public void buygunf()
    {
        PlayerPrefs.SetInt("isf", 1);

        Coin.score -= 400;
       

        gunf.gameObject.SetActive(false);
        ff.gameObject.SetActive(true);


    }

    public void mrr()
    {






    }
  
}
