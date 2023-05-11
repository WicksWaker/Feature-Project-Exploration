using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBlink : MonoBehaviour
{

    //Dash componenet
    public float blinkSpeed;
    Rigidbody riggy;
    bool blinking;

    public GameObject blinkEffects;


    private void Start()
    {
        riggy = GetComponent<Rigidbody>();
    }

    private void Blinking()
    {
        riggy.AddForce(transform.forward * blinkSpeed, ForceMode.Impulse);
        blinking = false;

        GameObject effect = Instantiate(blinkEffects, Camera.main.transform.position, blinkEffects.transform.rotation);
        effect.transform.parent = Camera.main.transform;
        effect.transform.LookAt(transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            blinking = true;
        
    }

    private void FixedUpdate()
    {
        if (blinking)
            Blinking();
    }
}
