using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class demonav : MonoBehaviour
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
    private float damageenemy;
    [SerializeField]
    private GameObject fireshot;
    [SerializeField]
    private Transform gunn;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        navMeshAgent.SetDestination(GameObject.FindWithTag("3").transform.position);

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



                if (distance > range)
                {
                    navMeshAgent.SetDestination(playerobj.transform.position);
                    navMeshAgent.stoppingDistance = 30f;
                }

            }



        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "1")
        {
            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("3").transform.position);

        }
        if (collision.gameObject.tag == "2")
        {
            
            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("1").transform.position);
        }
        if (collision.gameObject.tag == "3")
        {
            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("2").transform.position);
        }
  
    }






}
