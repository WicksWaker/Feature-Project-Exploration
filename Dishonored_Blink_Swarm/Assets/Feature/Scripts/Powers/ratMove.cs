using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratMove : MonoBehaviour
{
    public GameObject enemy;
    public GameObject rat_Prefab;
    //public List<GameObject> rats;
    public List<GameObject> ratPrefabList;
    public bool grounded = true;
    public int ratHealth = 2;

    public Vector3 rats;
    

    //spawn prefabs
    //will need to boid
    public void Start()
    {
        
        

    }

    public void ratSpawner()
    {
        for (int index = 0; index < 11; index++)
        {
            int prefabIndex = Random.Range(0, ratPrefabList.Count);
            Vector3 spawn_Near = new Vector3(index % 2, 0.33f, index / 2);
            GameObject temp = Instantiate(ratPrefabList[prefabIndex], transform.position + spawn_Near, Quaternion.identity);
            ratPrefabList.Add(temp);
            temp.GetComponent<what_Do>().enemy = GameObject.Find("Enemy");
        }
    }

    private void Update()
    {
       
       // transform.position += (enemy.transform.position - transform.position).normalized * Time.deltaTime * 5.0f;
    }

    //will need to have health & lose health


    //WANT to be able to jump to a random height
    public void OnCollisionEnter(Collision collision)
    {
        if (grounded = true)
        {
            //starts a coroutine for jump and attack until health = 0 on rats or enemy health = 0
        }
    }


    public void OnCollisionExit(Collision collision)
    {
        if (grounded = true)
        {
            //stops the coroutine for jump and attack until health = 0 on rats or enemy health = 0
        }
    }

    public void randoJump()
    {
        if (ratPrefabList.Count == Random.Range(0, 11))
        {
            if (grounded = true)
            {
                transform.position = new Vector3();
            }
        }

        if (grounded = false)
        {
            transform.position = new Vector3();

            //get rat object and have it move up the y axis at random height- may need to access the list in start
            //GetComponent<"Rat">().;
            //transform.position.y += Random.Range(0.0f, 5.0f);
            
        }
    }


}
