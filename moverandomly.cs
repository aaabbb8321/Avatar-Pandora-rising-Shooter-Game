using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class moverandomly : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    NavMeshPath path;
    public float timeForNewPath;
    bool inCoRoutine;
    Vector3 target;
    bool validPath;
    public float range;
    public float rateoffire;
    public float nextfire = 0;
    Animator anim;
    public Transform player;
    public GameObject gun;
    public float distance;
    public Transform fireball;
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        anim = GetComponent<Animator>();
       
        nextfire = Time.time;


    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        Vector3 relativepos = player.transform.position - transform.position;
        if (distance > range)
        {
            if (!inCoRoutine)
            {
                StartCoroutine(DoSomething());
            }


        }
        if (distance < range)
        {
            Quaternion rotation = Quaternion.LookRotation(relativepos);
            transform.LookAt(player.transform.position);
            if (Time.time > nextfire)
            {
                nextfire = Time.time + rateoffire;
                var firebullet = Instantiate(fireball, enemy.position, Quaternion.identity);
                firebullet.GetComponent<Rigidbody>().AddForce(relativepos* 1000);
                if (distance > range)
                {
                    navMeshAgent.SetDestination(player.transform.position);
                }

            }
        }
    }


    Vector3 getNewRandomPosition()
    {
        float x = Random.Range(-20, 20);
        float z = Random.Range(-20, 20);
        Vector3 pos = new Vector3(x, 0, z);
        return pos;
    }

    IEnumerator DoSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(0.01f);
        GetNewPath();
        validPath = navMeshAgent.CalculatePath(target, path);

        while (!validPath)
        {
            yield return new WaitForSeconds(0.01f);
            GetNewPath();
            validPath = navMeshAgent.CalculatePath(target, path);
        }

        inCoRoutine = false;

    }
    void GetNewPath()
    {
        target = getNewRandomPosition();

        navMeshAgent.SetDestination(target);
    }
}