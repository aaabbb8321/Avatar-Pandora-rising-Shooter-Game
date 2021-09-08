using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class demonavone : MonoBehaviour
{



    NavMeshAgent navMeshAgent;


    [SerializeField]
    private float range;
    [SerializeField]
    private float rateoffire;
    [SerializeField]
    private float nextfire = 0;

    Animator anim;
    private GameObject playerobj;
    [SerializeField]
    private GameObject gun;
    private float distance;
    [SerializeField]
    private Transform enemy;
    [SerializeField]
    private float damageenemy;
    [SerializeField]
    private GameObject fireshot;
    [SerializeField]
    private Transform gunn;


    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();


        anim = GetComponent<Animator>();
        nextfire = Time.time;

        playerobj = GameObject.FindWithTag("player");


    }

    // Update is called once per frame
    void Update()
    {
        if(distance>range)
        {

            navMeshAgent.SetDestination(playerobj.transform.position);
            navMeshAgent.stoppingDistance = 30f;
        }
        distance = Vector3.Distance(transform.position, playerobj.transform.position);
        Vector3 relativepos = playerobj.transform.position - transform.position;


        if (distance < range)
        {
            anim.SetBool("firing", true);
            Quaternion rotation = Quaternion.LookRotation(relativepos);
            transform.LookAt(playerobj.transform.position);
            if (Time.time > nextfire)
            {
                RaycastHit hit;
                if(Physics.Raycast(gun.transform.position, gun.transform.forward, out hit))
                {
                   

                    Instantiate(fireshot, gunn.position, Quaternion.identity);
                    if (hit.collider.gameObject.tag == "player")
                    {
                       
                        Playerhealth.currenthealth -= damageenemy;
                    }


                }
               




                nextfire = Time.time + rateoffire;
                //var firebullet = Instantiate(fireball, enemy.position, Quaternion.identity);
                //firebullet.GetComponent<Rigidbody>().AddForce(relativepos * 1000);
           

            }


        }
    }
}