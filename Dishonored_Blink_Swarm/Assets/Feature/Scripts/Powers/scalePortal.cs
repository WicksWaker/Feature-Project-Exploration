using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalePortal : MonoBehaviour
{
    public float a;
    public float b;

    public bool itsOne;

    public GameObject blink_Portal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            StopCoroutine(coroutineGrowShrink());
        }
    }
    public void GrownandShrink()
    {
        transform.localScale = Vector3.one * Mathf.Sin(Time.time);
    }

    IEnumerator coroutineGrowShrink()
    {
        
        itsOne = true; 
        while (itsOne = true)
        {
            blink_Portal.SetActive(true);
            yield return new WaitForSeconds(1.0f);

            GrownandShrink();

            itsOne = false;
        }
        blink_Portal.SetActive(false);


    }
}
