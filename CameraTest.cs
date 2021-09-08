using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    public Camera cam;
    private float[] dis = new float[32];
    // Start is called before the first frame update
    void Start()
    {

        cam.layerCullDistances = dis;

        dis[8] = 500f;

    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
