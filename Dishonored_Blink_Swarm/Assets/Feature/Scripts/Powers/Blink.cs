using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : Powers
{
    //speed of player normally- how much it increases
    public float speed;
    public int speedIncrease;

    //max area of movement for player/ portal
    public int maxMovement;
    public int minMovement;

    //portal prefab
    GameObject blink_PortalPrefab;

    public void speedUp()
    {
        //increases speed of player dramatically
    }

    public void runToPoint()
    {
        //player moves to point
        //without being able to deviate
    }
}
