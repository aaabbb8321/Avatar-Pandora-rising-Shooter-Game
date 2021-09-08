using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class demonava : MonoBehaviour
{


    NavMeshAgent navMeshAgent;
    [SerializeField]
    public Transform pos1;
    [SerializeField]
    public Transform pos2;
    [SerializeField]
    public Transform pos3;

    [SerializeField]
    public float range;
    [SerializeField]
    public float rateoffire;
    [SerializeField]
    public float nextfire = 0;
    Animator anim;
    private GameObject playerobj;
    [SerializeField]
    public GameObject gun;

    public float distance;

    public Transform enemy;
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

        navMeshAgent.SetDestination(GameObject.FindWithTag("4").transform.position);

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
        if (collision.gameObject.tag == "4")
        {
            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("5").transform.position);

        }
        if (collision.gameObject.tag == "5")
        {

            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("6").transform.position);
        }
        if (collision.gameObject.tag == "6")
        {
            Debug.Log("iiii");
            navMeshAgent.SetDestination(GameObject.FindWithTag("4").transform.position);
        }

    }






}
