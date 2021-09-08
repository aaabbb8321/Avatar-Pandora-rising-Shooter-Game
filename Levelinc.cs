using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Levelinc : MonoBehaviour
{
    Button[] LevelButons;
    public int i;
    public int j;
    // Start is called before the first frame update
    private void Start()
    {

        j = PlayerPrefs.GetInt("jjj");
    }

    // Update is called once per frame
    void Update()
    {
        int ReachedLevel = PlayerPrefs.GetInt("ReachedLevellll", j);
        LevelButons = new Button[transform.childCount];
        for (i = 0; i < LevelButons.Length; i++)
        {
            LevelButons[i] = transform.GetChild(i).GetComponent<Button>();
            LevelButons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();

        }
        if (i < LevelButons.Length)
        {
            if (i + 1 > ReachedLevel)
            {
                LevelButons[i].interactable = false;
            }

        }


    }
    public void aa()
    {

        j++;
        PlayerPrefs.SetInt("jjj", j);

        PlayerPrefs.SetInt("ReachedLevellll", j);

    }




}