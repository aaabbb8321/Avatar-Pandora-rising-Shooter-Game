using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadlevel : MonoBehaviour
{
    public GameObject mm;
    public GameObject load;
    public GameObject lo;
    // Start is called before the first frame update
    void Awake()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameplay()
    {
        Application.LoadLevel("Level1");
        mm.gameObject.SetActive(true);
        load.gameObject.SetActive(true);
        lo.gameObject.SetActive(true);
    }
}

