using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class demothree : MonoBehaviour
{


    NavMeshAgent navMeshAgent;
    [SerializeField]
    private Transform pos1;
    [SerializeField]
    private Transform pos2;
    [SerializeField]
    private Transform pos3;

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
    private GameObject fireshot;
    [SerializeField]
    private Transform gunn;
    [SerializeField]
    private float damageenemy;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        navMeshAgent.SetDestination(GameObject.FindWithTag("7").transform.position);

        anim = GetComponent<Animator>();
        nextfire = Time.time;

        playerobj = GameObject.FindWithTag("player");


    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, playerobj.transform.position);
        Vector3 relativepos = playerobj.transform.position - transform.position;

        if (distance < range)
        {
            Quaternion rotation = Quaternion.LookRotation(relativepos);
            transform.LookAt(playerobj.transform.position);
            if (Time.time > nextfire)
            {
                nextfire = Time.time + rateoffire;
                RaycastHit hit;
                if (Physics.Raycast(gun.transform.position, gun.transform.forward, out hit, 400f))
                {
                  

                    Instantiate(fireshot, gunn.position, Quaternion.identity);
                    if (hit.collider.gameObject.tag == "player")
                    {

                        Playerhealth.currenthealth -= damageenemy;
                    }
                }


            }



        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "7")
        {
            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("9").transform.position);

        }
        if (collision.gameObject.tag == "8")
        {

            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("7").transform.position);
        }
        if (collision.gameObject.tag == "9")
        {
            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("8").transform.position);
        }

    }






}
