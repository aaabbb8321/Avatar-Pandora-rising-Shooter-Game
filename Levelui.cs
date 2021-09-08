using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Levelui : MonoBehaviour
{
    Button[] LevelButons;
    public int i;
    public static int j;
    public int ReachedLevel;
    // Start is called before the first frame update
    private void Start()
    {
        
        ReachedLevel = PlayerPrefs.GetInt("ReachedLevelll", j);
        LevelButons = new Button[transform.childCount];
        for (i = 0; i < LevelButons.Length; i++)
        {
            LevelButons[i] = transform.GetChild(i).GetComponent<Button>();
            LevelButons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
            if (i + 1 > ReachedLevel)
            {
                LevelButons[i].interactable = false;
            }

        }
        if(j<4)
        {
            for (i = 0; i < 8; i++)
            {
                LevelButons[i] = transform.GetChild(i).GetComponent<Button>();
                LevelButons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
                LevelButons[i].interactable = false;

            
            }

        }

    }

    // Update is called once per frame

    public void aa()
    {
        j++;
     


    }




}