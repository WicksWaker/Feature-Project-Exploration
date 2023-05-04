using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    //Blink GOs
    [SerializeField] GameObject blink_Use_Indicator;
    [SerializeField] GameObject blink_Portal;
    [SerializeField] GameObject _blinkParent;

    //Swarm GOs
    [SerializeField] GameObject portalPrefab;
    [SerializeField] GameObject swarm_Use_Indicator;
    [SerializeField] GameObject _SwarmParent;
    [SerializeField] GameObject swarm_Container;
    [SerializeField] GameObject rat_Container;
    [SerializeField] GameObject whisp_Container;
    [SerializeField] GameObject portal_Container;

    //energy ints- normal number (40), decrease by 5
    public int Energy;
    public int decreasedByFive;
    
    //both parents need to be a singleton

    public void Start()
    {
        decreaseandIncreaseEnergy();
        whereToPlace();
    }

    public void Update()
    {
        whereToPlace();
    }

    IEnumerator decreaseandIncreaseEnergy()
    {
        //still need to key this to the 'E' && 'F' key thru new input
        if (GetComponent<Blink>() && Energy >= 0 || GetComponent<Swarm>() && Energy >= 0)
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
        if (GetComponent<Blink>())
        {
            _blinkParent.SetActive(true);
        }
        else
        {
            _blinkParent.SetActive(false);
        }

        if (GetComponent<Swarm>())
        {
            _SwarmParent.SetActive(true);
        }
        else
        {
            _SwarmParent.SetActive(false);
        }
    }
}
