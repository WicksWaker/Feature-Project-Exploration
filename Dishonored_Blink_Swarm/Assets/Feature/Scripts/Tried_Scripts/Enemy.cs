using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject Rat;
    private int nowHereStop = 0;
    public int swordSwingMax, swordSwingMin, enemyHealth, numEnemy = 5, _freq, _amp;
    public float timeDuration = 1f, timeStart, speed, distBetw, moveRad = 5f, moveSped = 2f;
    private float distance;
    public bool checkToCalculate = false, moving = false;
    private bool isMoving = true;
    public Vector3 enemyPosMin, enemyPosMax;
    private Vector3[] hangOut = new Vector3[]
    {
        new Vector3(5f, 0f, 5f),
        new Vector3( -2f,0f , -1f),
        new Vector3(2f, 0f, -3f)
    };

    //list of enemies- to call to

    public void Start()
    {
        enemyHealth = 10;
        Movement();
    }

    public void Movement()
    {
        //if enemy is moving then change x & z, y remains the same
        if (isMoving)
        {
            float a = Time.time * moveSped;
            float x = Mathf.Sin(a) * moveRad;
            float y = transform.position.y;
            float z = Mathf.Cos(a) * moveRad;

            //moving enemies around- x & z axis, cannot jump
            //has to be inside the if statement
            transform.position = new Vector3(x, y, z);

            Debug.Log("It was moving");
        }
        if (Vector3.Distance(transform.position, hangOut[nowHereStop]) < 0.1f)
        {
            isMoving = false;

            int randomIndex = Random.Range(0, hangOut.Length);
            nowHereStop = randomIndex;
            StartCoroutine(startAgain());
        }

        isMoving = true;
        
    }

    private IEnumerator startAgain()
    {
        yield return new WaitForSeconds(2f);
        isMoving = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //attack
        if (collision.gameObject.CompareTag("Rat"))
        {
            //loseHealth- when rats touch, decrease in scale
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                this.gameObject.SetActive(false);
            }

            //interpolate towards the rats- attack


            //all enemies move towards those rats
            alertAllies();
        }
    }

    private void FixedUpdate()
    {
        /*//iterate over each cloud that was created
        foreach (Transform enemy in transform)
        {
            //get the enemy scale and position
            float scaleVal = enemy.localScale.x;
            //epos= enemy position
            Vector3 ePos = enemy.position;

            //move enemy in rando circ path
            float angle = (Time.time - timeStart) * speed;
            float x = Mathf.Cos(angle) * (enemyPosMax.x - enemyPosMin.x) / 2f;
            float z = Mathf.Sin(angle) * (enemyPosMax.z - enemyPosMin.z) / 2f;
            ePos.x = x + (enemyPosMax.x + enemyPosMin.x) / 2f;
            ePos.z = z + (enemyPosMax.z + enemyPosMin.z) / 2f;

            enemy.position = ePos;
        }*/
    }

    //alert- when colliding with rats- alert other enemies
    void alertAllies()
    {
        distance = Vector3.Distance(transform.position, Rat.transform.position);
        Vector3 direction = Rat.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (distance < distBetw)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, Rat.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.up * angle);
        }

        //have other enemies interpolate & have an alert sign go off above head (originally set to inactive)
        /*GameObject enemies_Grp = GameObject.Find("Enemies_Grp");

        for (int index = 0; index < numEnemy; index++)
        {
            Vector3 ePos = Vector3.zero;
            ePos.x = Random.Range(enemyPosMax.x, enemyPosMax.x);
            ePos.y = transform.position.y;
            ePos.y = Random.Range(enemyPosMax.y, enemyPosMax.y);

            Transform enemy = enemies_Grp.transform.GetChild(index);
            enemy.SetParent(enemies_Grp.transform);
            enemy.position = ePos;
        }*/

        Debug.Log("Called for allies");

    }


}
