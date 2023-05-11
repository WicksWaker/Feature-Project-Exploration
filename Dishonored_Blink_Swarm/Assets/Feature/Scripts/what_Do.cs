using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class what_Do : MonoBehaviour
{

    public Vector3 p0 = new Vector3(0, 0, 0);
    public Vector3 p1 = new Vector3(2, 3, 5);
    public GameObject enemy;
    public GameObject spawner;
    public float timeDuration = 1f;

    public bool checkToCalculate = false;
    public Vector3 p01;
    public bool moving = false;
    public float timeStart;

    //public List<GameObject> rats;
    public bool grounded = true;
    public int ratHealth = 2;
    private NavMeshAgent _Agent;

    public void Start()
    {
        _Agent = gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        _Agent.destination = enemy.transform.position;
        //interpolate to enemy
        if (checkToCalculate)
        {
            checkToCalculate = false;
            moving = true;
            timeStart = Time.time;
        }

        if (moving)
        {
            float u = (Time.time - timeStart) / timeDuration;
            if (u >= 1)
            {
                u = 1;
                moving = false;
            }
            //use standard linera interpolation formula
            //enemy = (1 - u) * spawner + u * p1;

            //transform.position = enemy;
        }
    }

    //will need to have health & lose health


    //WANT to be able to jump to a random height
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("Got that enemy tag collision");
            if (grounded = true)
            {
                transform.position += (enemy.transform.position - transform.position).normalized * Time.deltaTime * 5.0f;
                Debug.Log("grounded is true- gonna start CoRoutine Up");
                //starts a coroutine for jump and attack until health = 0 on rats or enemy health = 0
            }
            Debug.Log("Completed jump and attack collision");
        }
        
    }


    public void attackEnemy()
    {

        Debug.Log("Gonna start the rat attack");
        //attacks enemy- makes enemy lose health per randoJump & reduces enemy size
    }

    public void randoJump()
    {
        if (GetComponent<ratMove>().ratPrefabList.Count == Random.Range(0, 11))
        {
            Debug.Log("Got the ratmove script and prefab list and random range");
            if (grounded = true)
            {
                Debug.Log("rats are definately grounded");
                transform.position = new Vector3(0, 5, 0);
                Debug.Log("rats jumped up");
                grounded = false;
                Debug.Log("grounded no longer");
            }
        }

        if (grounded = false)
        {
            Debug.Log("grounded no longer 2");
            transform.position = new Vector3(0,0,0);
            Debug.Log("back at starting pos");
            //get rat object and have it move up the y axis at random height- may need to access the list in start
            //GetComponent<"Rat">().;
            //transform.position.y += Random.Range(0.0f, 5.0f);

        }
    }
}
