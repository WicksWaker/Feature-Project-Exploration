using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    public int Energy;

    //both need to be a singleton

    public void decreaseEnergy()
    {
        //when Blink or Swarm is used- bring down energy by 5f
    }

    public void increaseEnergyOverTime()
    {
        //when 20 seconds have passed- restore to full energy
    }

    public void whereToPlace()
    {
        //turns on portal for blink and swarm
        //needs CoRoutine- while loop or if statement
        //shows where it will spawn

        //GetComponent<>();- turn on portal in inspector
        //GetComponent<>();- turn on indicator in inspector
        //turns back off when not in use

        //GetComponent<>();- turn off portal in inspector
        //GetComponent<>();- turn off indicator in inspector
    }
}
