using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swarm : Powers
{
    //needs speed for rats
    //jump height min & max of rats
    //portal size- change min and max
    //whisp size- change min and max
    public float speed;
    public int ratHealth = 10, reduceRatHealth, jumpHeightMax, jumpHeightMin, portalSizeMax, portalSizeMin, whispSizeMax, whispSizeMin;

    //public list numberOfRatsList; (10 rats)
    //prefab for rats- all 3, create list
    //randomize which prefabs are used
    GameObject[] rats, portalPrefab, whispPrefab;

    public void Start()
    {
        increasePortalSize();
        activeWhisps();
        activeRats();
    }

    //when indicator & portal on- increase size of portal
    //makes portal max scale
    public void increasePortalSize()
    {
        Transform portalTransform = GameObject.Find("portal_Prefab").transform;
        StartCoroutine(SUandD(portalTransform, portalSizeMin, portalSizeMax));
        gameObject.SetActive(false);
        //GetComponent<Scale>(); increase size- portalSizeMax
        //when all rats appear- set portal
        //(when reach max index number)
        Debug.Log("Made the portal bigger");
    }

    //SetActive whisps - random height
    public void activeWhisps()
    {
        GameObject[] whisps = GameObject.FindGameObjectsWithTag("Whisp");
        foreach (GameObject whisp in whisps)
        {
            StartCoroutine(SUandD(whisp.transform, whispSizeMin, whispSizeMax));
        }
        StartCoroutine(DeObjectsaftS(whisps));
        gameObject.SetActive(false);
        //SetActive 5 whisps
        //Scale to random height, min, max
        //decrease to min height and Set inactive
        Debug.Log("Whispers be whispering");
    }

    //SetActive 10 rats
    public void activeRats()
    {
        //SetActive 10 rats
        //when health 0- turn off rats
        if (ratHealth <= 0)
        {
            //set rats to inactive
            gameObject.SetActive(false);
        }

        //have them "jump" to a random height (max, mix)
        GameObject[] rats = GameObject.FindGameObjectsWithTag("Rat");
        foreach(GameObject rat in rats)
        {
            //StartCoroutine(NEEDS COROUTINE FOR JUMPING (rat.transform, jumpHeightMax, jumpHeightMin));
        }
        
        //have rats boid
        Debug.Log("Rats activation- go!");
    }

    private IEnumerator SUandD(Transform transform, float minScale, float maxScale)
    {
        float timeHappening = 0f;
        float howLong = 1f;
        while (timeHappening < howLong)
        {
            //floats to determine the amount of time and how long during it this should be happening
            //minimum scale to start w/
            float itsHappening = timeHappening / howLong;
            float scale = Mathf.Lerp(minScale, minScale, itsHappening);

            //inscreased the local scale for however long it takes then return null
            transform.localScale = new Vector3(scale, scale, scale);
            timeHappening += Time.deltaTime;
            yield return null;
            Debug.Log("Scaled Up and Down");
        }

        //increase to max scale
        transform.localScale = new Vector3(maxScale, maxScale, maxScale);
    }

    private IEnumerator DeObjectsaftS(GameObject[] objects)
    {
        //wait a bit then set back to false
        yield return new WaitForSeconds(1f);
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }

    //interpolate to follow enemies

    //OnCollision- Attack enemies
    private void OnCollisionEnter(Collision collision)
    {
        Attack();
    }

    public void Attack()
    {
        //attack enemies-
        //jump to random height


        //max height is same as enemy


        //make them lose health
        //GetComponent<Enemy>().numHealth();



        Debug.Log("Attacked");
    }
}
