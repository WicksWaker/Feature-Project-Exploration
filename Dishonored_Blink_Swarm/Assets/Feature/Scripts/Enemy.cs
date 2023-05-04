using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth;
    public float speed;
    public int swordSwingMax;
    public int swordSwingMin;
    //list of enemies- to call to

    public void Awake()
    {
        Movement();
    }

    public void Movement()
    {
        //moving enemies around- x & z axis, cannot jump
    }

    private void OnCollisionEnter(Collision collision)
    {
        //attack
        //if ()
        //{
            //loseHealth- when rats touch, decrease in scale
            //interpolate towards the rats- attack
            //alertAllies();
        //}
        

        //alert- when colliding with rats- alert other enemies
         void alertAllies()
        { 
            //have other enemies interpolate & have an alert sign go off above head (originally set to inactive)
        }
    }


}
