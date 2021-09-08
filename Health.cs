using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    [SerializeField]
    private Button gunb;
    [SerializeField]
    private Text scoretext;
    [SerializeField]
    private string enemy;
    [SerializeField]
    private Text scoretexttt;
    public static int hee;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = PlayerPrefs.GetInt("hee").ToString();
        hee = PlayerPrefs.GetInt("hee");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = hee.ToString();
        scoretexttt.text = hee.ToString();
        if (Coin.score > 15)
        {
            gunb.interactable = true;

        }
        else
        {
            gunb.interactable = false;

        }
    }
    public void aa()
    {
        Coin.score -= 15;
        hee++;
        scoretext.text = hee.ToString();
        PlayerPrefs.SetInt("hee", hee);

    }
    public void bb()
    {
        if(hee>0)
        {
            hee--;
            PlayerPrefs.SetInt("hee", hee);
            Playerhealth.currenthealth = 300f;
        }
  

    }
    public void cc()
    {
        hee++;
        PlayerPrefs.SetInt("hee", hee);

    }

}
