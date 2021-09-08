using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top : MonoBehaviour
{
    [SerializeField]
    private AudioSource pp;
    [SerializeField]
    private AudioSource vv;
    [SerializeField]
    public Button[] Levelbutton=new Button[21];
  
   
    public static int kk;
    [SerializeField]
    private Text scoretext;
    public int i;
    public static int p;
    [SerializeField]
    private GameObject a;
    [SerializeField]
    private GameObject b;
    [SerializeField]
    private GameObject c;
    [SerializeField]
    private GameObject d;
    [SerializeField]
    private GameObject e;
    [SerializeField]
    private GameObject f;
    [SerializeField]
    private GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        pp.PlayDelayed(55f);
        vv.PlayDelayed(65f);
        Levelbutton[0].interactable = false;
        Levelbutton[1].interactable = false;
        Levelbutton[2].interactable = false;
        Levelbutton[3].interactable = false;
        Levelbutton[4].interactable = false;
        Levelbutton[5].interactable = false;
        Levelbutton[6].interactable = false;
        Levelbutton[7].interactable = false;
        Levelbutton[8].interactable = false;
        Levelbutton[9].interactable = false;
        Levelbutton[10].interactable = false;
        Levelbutton[11].interactable = false;
        Levelbutton[12].interactable = false;
        Levelbutton[13].interactable = false;
        Levelbutton[14].interactable = false;
        Levelbutton[15].interactable = false;
        Levelbutton[16].interactable = false;
        Levelbutton[17].interactable = false;
        Levelbutton[18].interactable = false;
        Levelbutton[19].interactable = false;
        Levelbutton[20].interactable = false;
        

   
        kk = PlayerPrefs.GetInt("Reachedlevellkll", kk);

        
    }

    // Update is called once per frame
    void Update()
    {



        PlayerPrefs.SetInt("Reachedlevellkll", kk);
        scoretext.text = kk.ToString();
        
        
        if(kk<=4)
        {
            a.gameObject.SetActive(true);
            b.gameObject.SetActive(false);
            c.gameObject.SetActive(false);
            d.gameObject.SetActive(false);

            e.gameObject.SetActive(false);
            f.gameObject.SetActive(false);
            g.gameObject.SetActive(false);

        }
        if (kk > 6&& kk <= 12)
        {
            a.gameObject.SetActive(true);
            b.gameObject.SetActive(true);
            c.gameObject.SetActive(false);
            d.gameObject.SetActive(false);

            e.gameObject.SetActive(false);
            f.gameObject.SetActive(false);
            g.gameObject.SetActive(false);

        }
        if (kk > 12 && kk <= 18)
        {
            a.gameObject.SetActive(true);
            b.gameObject.SetActive(true);
            c.gameObject.SetActive(true);
            d.gameObject.SetActive(false);

            e.gameObject.SetActive(false);
            f.gameObject.SetActive(false);
            g.gameObject.SetActive(false);

        }
        if (kk > 18 && kk <= 24)
        {
            a.gameObject.SetActive(true);
            b.gameObject.SetActive(true);
            c.gameObject.SetActive(true);
            d.gameObject.SetActive(true);

            e.gameObject.SetActive(false);
            f.gameObject.SetActive(false);
            g.gameObject.SetActive(false);

        }
        if (kk > 24 && kk <= 30)
        {
            a.gameObject.SetActive(true);
            b.gameObject.SetActive(true);
            c.gameObject.SetActive(true);
            d.gameObject.SetActive(true);

            e.gameObject.SetActive(true);
            f.gameObject.SetActive(false);
            g.gameObject.SetActive(false);

        }
        if (kk > 30 && kk <= 36)
        {
            a.gameObject.SetActive(true);
            b.gameObject.SetActive(true);
            c.gameObject.SetActive(true);
            d.gameObject.SetActive(true);

            e.gameObject.SetActive(true);
            f.gameObject.SetActive(true);
            g.gameObject.SetActive(false);

        }
        if (kk > 36 && kk <= 42)
        {
            a.gameObject.SetActive(true);
            b.gameObject.SetActive(true);
            c.gameObject.SetActive(true);
            d.gameObject.SetActive(true);

            e.gameObject.SetActive(true);
            f.gameObject.SetActive(true);
            g.gameObject.SetActive(true);

        }
        if(kk > 42 && kk <= 48)
        {
            Levelbutton[0].interactable = true;
            Levelbutton[1].interactable = true;
            Levelbutton[2].interactable = true;
            Levelbutton[3].interactable = true;
            Levelbutton[4].interactable = true;
            Levelbutton[5].interactable = true;
            Levelbutton[6].interactable = true;
            Levelbutton[7].interactable = false;
            Levelbutton[8].interactable = false;
            Levelbutton[9].interactable = false;
            Levelbutton[10].interactable = false;
            Levelbutton[11].interactable = false;
            Levelbutton[12].interactable = false;
            Levelbutton[13].interactable = false;
            Levelbutton[14].interactable = false;
            Levelbutton[15].interactable = false;
            Levelbutton[16].interactable = false;
            Levelbutton[17].interactable = false;
            Levelbutton[18].interactable = false;
            Levelbutton[19].interactable = false;
            Levelbutton[20].interactable = false;
         
        }
        if(kk > 48 && kk <= 52)
        {
            Levelbutton[0].interactable = true;
            Levelbutton[1].interactable = true;
            Levelbutton[2].interactable = true;
            Levelbutton[3].interactable = true;
            Levelbutton[4].interactable = true;
            Levelbutton[5].interactable = true;
            Levelbutton[6].interactable = true;
            Levelbutton[7].interactable = true;
            Levelbutton[8].interactable = true;
            Levelbutton[9].interactable = true;
            Levelbutton[10].interactable = true;
            Levelbutton[11].interactable = true;
            Levelbutton[12].interactable = true;
            Levelbutton[13].interactable = true;
            Levelbutton[14].interactable = false;
            Levelbutton[15].interactable = false;
            Levelbutton[16].interactable = false;
            Levelbutton[17].interactable = false;
            Levelbutton[18].interactable = false;
            Levelbutton[19].interactable = false;
            Levelbutton[20].interactable = false;
           
        }
        if(kk > 52&& kk <= 60)
        {
            Levelbutton[0].interactable = true;
            Levelbutton[1].interactable = true;
            Levelbutton[2].interactable = true;
            Levelbutton[3].interactable = true;
            Levelbutton[4].interactable = true;
            Levelbutton[5].interactable = true;
            Levelbutton[6].interactable = true;
            Levelbutton[7].interactable = true;
            Levelbutton[8].interactable = true;
            Levelbutton[9].interactable = true;
            Levelbutton[10].interactable = true;
            Levelbutton[11].interactable = true;
            Levelbutton[12].interactable = true;
            Levelbutton[13].interactable = true;
            Levelbutton[14].interactable = true;
            Levelbutton[15].interactable = true;
            Levelbutton[16].interactable = true;
            Levelbutton[17].interactable = true;
            Levelbutton[18].interactable = true;
            Levelbutton[19].interactable = true;
            Levelbutton[20].interactable = true;
    
        }

    }
    public void aa()
    {
        p = 0;
        kk++;
        PlayerPrefs.SetInt("Reachedlevellkll", kk);


    }
  
}
