using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PISTOL : MonoBehaviour
{
    public float rateoffire;
    public float nextfire = 0;
    public Transform fireball;
    public Transform enemy;

    // Start is called before the first frame update
    void Start()
    {

        nextfire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextfire)
        {
            nextfire = Time.time + rateoffire;
            var firebullet = Instantiate(fireball, enemy.position, Quaternion.identity);
            firebullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * 90000000);
        }
            
    }
}
