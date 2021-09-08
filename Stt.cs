using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stt : MonoBehaviour
{
    public static int r=1;
    public static int p;
    [SerializeField]
    private GameObject gameObjectToMove;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(r);
    }
    public void aa()
    {
        MoveGameObject();
        Playerhealth.currenthealth = 300f;
        Levelaaa.s = 0;
        Levelaaa.m = 0;
        Levelaaa.j = 0;
        Levelaaa.k = 0;
        p = 1;

    }
    public void bb()
    {
        MoveGameObject();
        Playerhealth.currenthealth = 300f;
        Levelaaa.s = 0;
        Levelaaa.m = 0;
        Levelaaa.j = 0;
        Levelaaa.k = 0;
        p = 2;
        
    }
    public void cc()
    {
        MoveGameObject();
        Playerhealth.currenthealth = 300f;
        Levelaaa.j = 0;
        Levelaaa.s = 0;
        Levelaaa.m = 0;
        Levelaaa.k = 0;

        p = 4;
      
    }
    public void dd()
    {
        MoveGameObject();
        Playerhealth.currenthealth = 300f;
        Levelaaa.s = 0;
        Levelaaa.m = 0;
        Levelaaa.j = 0;
        Levelaaa.k = 0;
        p = 5;
       
    }
    public void ee()
    {
        MoveGameObject();
        Playerhealth.currenthealth = 300f;
        Levelaaa.s = 0;
        Levelaaa.m = 0;
        Levelaaa.j = 0;
        Levelaaa.k = 0;
        p = 6;
    }
    public void ff()
    {
        Playerhealth.currenthealth = 300f;
        Levelaaa.m = 0;
        Levelaaa.j = 0;
        Levelaaa.s = 0;
        Levelaaa.k = 0;
        p = 7;
        MoveGameObject();
    }
    public void gg()
    {
        Playerhealth.currenthealth = 300f;
        Levelaaa.s = 0;
        Levelaaa.m = 0;
        Levelaaa.j = 0;
        Levelaaa.k = 0;
        p = 0;
        MoveGameObject();
    }
    public void MoveGameObject()
    {
        gameObjectToMove.transform.position = new Vector3(4.03f, 17.85f, -10.09f);
    }


}
