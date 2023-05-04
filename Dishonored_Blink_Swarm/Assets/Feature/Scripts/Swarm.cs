using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swarm : Powers
{
    //needs speed for rats
    public float speed;
    public int ratHealth; //(2 health a piece)
    public int reduceRatHealth;
    //public list numberOfRatsList; (10 rats)
    //prefab for rats- all 3, create list
    //randomize which prefabs are used
    GameObject rat_01Prefab;
    GameObject rat_02Prefab;
    GameObject rat_03Prefab;
    GameObject rat_04Prefab;

    //jump height min & max of rats
    public int jumpHeightMax;
    public int jumpHeightMix;

    //portal size- change min and max
    public int portalSizeMax;
    public int portalSizeMin;
    GameObject portalPrefab;

    //whisp size- change min and max
    public int whispSizeMax;
    public int whispSizeMin;
    GameObject whispPrefab;
    //public list whispAmountList;



    //when indicator & portal on- increase size of portal
    //makes portal max scale
    public void increasePortalSize()
    {
        //GetComponent<Scale>(); increase size- portalSizeMax
        //when all rats appear- turn off portal
        //(when index complete)
    }

    //spawn whisps - random height
    public void spawnWhisps()
    {
        //spawn 5 whisps- put into a list
        //increse to random height
        //decrease to height and turn off
    }

    //Spawn 10 rats (with 2 health a peice)
    public void spawnRats()
    {
        //Spawn 10 rats (with 2 health a peice)- instantiate
        //have them "jump" to a random height (max, mix)
        //put all rats onto a list
        //have rats boid
    }

    //interpolate to follow enemies
    
    //OnCollision- Attack enemies

    public void Attack()
    {
        //attack enemies-
        //jump to random height
        //make them lose health
        //when health 0- turn off rats
    }
}
