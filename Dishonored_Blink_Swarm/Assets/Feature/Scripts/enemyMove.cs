using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "rat")
        {
            //attack rat- reduce rat health
            //reduce our health
            //shrink size
        }   
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "rat")
        {
            //stops coroutine of attack rat, reduce health and shrink size
        }
    }
}
