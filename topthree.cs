using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class topthree : MonoBehaviour
{
    Button[] Levelbutton;
    // Start is called before the first frame update
    void Start()
    {
        Levelbutton = new Button[transform.childCount];


        if (Top.kk >= 40)
        {
            for (int i = 0; i < Levelbutton.Length; i++)
            {
                Levelbutton[i] = transform.GetChild(i).GetComponent<Button>();

                Levelbutton[i].interactable = false;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
