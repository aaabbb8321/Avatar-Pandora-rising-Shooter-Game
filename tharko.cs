using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tharko : MonoBehaviour
{
    [SerializeField]
    private Text dratext;
    [SerializeField]
    private Button gunc;

    private int sc;
    // Start is called before the first frame update
    void Start()
    {
        dratext.text = PlayerPrefs.GetInt("sc").ToString();
        sc = PlayerPrefs.GetInt("sc");
        gunc.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        dratext.text = sc.ToString();
        PlayerPrefs.SetInt("sc", sc);


    }
    public void aa()
    {
        sc++;
        dratext.text = sc.ToString();
        PlayerPrefs.SetInt("sc", sc);

    }

}

