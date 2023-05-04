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

    public void Movement()
    {
        //moving enemies around
    }

    public void actOnSight()
    {
        //interpolate towards the rats- attack
    }


    //OnCollision- attack
    //loseHealth- when rats touch, decrease in scale
    //alert- when colliding with rats- alert other enemies
    //all enemies interpolate to rats
    private void OnCollisionEnter(Collision collision)
    {
        //attack
        //loseHealth- when rats touch, decrease in scale
        //alert- when colliding with rats- alert other enemies
        //all enemies interpolate to rats
    }


}
