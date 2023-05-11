using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : Powers
{
    public Vector3 blink_Potal_Position;

    //speed of player normally- how much it increases
    public float speed;

    //max area of movement for player/ portal
    public int currentPos, nextPos, speedIncrease;

    //portal prefab
    GameObject blink_PortalPrefab;

    public void Start()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            speedUp();
            runToPoint();
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            speedUp();
            runToPoint();
        }
    }

    public void speedUp()
    {
        //increases speed of player dramatically
        speed *= speedIncrease;


        //wait for a bit
        StartCoroutine(ReSpeedAftWait());

        Debug.Log("It went faster to the point");
    }

    private IEnumerator ReSpeedAftWait()
    {
        yield return new WaitForSeconds(2f);

        //bring speed back 2 OG
        speed /= speedIncrease;
    }

    public void runToPoint()
    {

        StartCoroutine(moveHere());

        //it dun ran
        Debug.Log("It ran to the point");
    }

    private IEnumerator moveHere()
    {
        Vector3 startPos = transform.position;
        Vector3 nextPos = blink_Potal_Position;
        float howMuch = 1f;

        float tickTok = 0f;
        while (tickTok < howMuch)
        {
            float hereItIs = tickTok / howMuch;
            transform.position = Vector3.Lerp(startPos, nextPos, hereItIs);

            tickTok += Time.deltaTime;
            yield return null;
        }

        transform.position = nextPos;
    }
}
