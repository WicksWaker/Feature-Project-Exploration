using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    //Blink GOs
    GameObject[] blinkItems;

    [SerializeField] GameObject blink_Use_Indicator, blink_Portal, _blinkParent;

    //Swarm GOs
    [SerializeField] GameObject portalPrefab, swarm_Use_Indicator, _SwarmParent, swarm_Container, rat_Container, whisp_Container, portal_Container;

    //energy ints- normal number (40), decrease by 5
    public int Energy, decreasedByFive;
    
    //both parents need to be a singleton

    public void Start()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            decreaseandIncreaseEnergy();
            whereToPlace();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            decreaseandIncreaseEnergy();
            whereToPlaceTwo();
        }
        
    }

    public void Update()
    {
        whereToPlace();
    }

    IEnumerator decreaseandIncreaseEnergy()
    {
        //still need to key this to the 'E' && 'F' key thru new input
        if (Input.GetKeyDown(KeyCode.F) && Energy >= 0 || Input.GetKeyDown(KeyCode.E) && Energy >= 0)
        {
            //when Blink or Swarm is used- bring down energy by 5f
            Energy -= 5;
            yield return new WaitForSecondsRealtime(1f);
        }
        else
        {
            //when 20 seconds have passed- restore to full energy
            if (Energy <= 0)
            {
                Energy += 40;
                yield return new WaitForSecondsRealtime(20f);
            }

            yield return null;
        }
       
    }

    public void whereToPlace()
    {
        //turns on portal for blink and swarm
        //shows where it will spawn
        //turns back off when component not in use
        if (Input.GetKeyDown(KeyCode.F))
        {
            _blinkParent.SetActive(true);
        }
        else
        {
            _blinkParent.SetActive(false);
        }
    }

    public void whereToPlaceTwo()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _SwarmParent.SetActive(true);
        }
        else
        {
            _SwarmParent.SetActive(false);
        }
    }
}
