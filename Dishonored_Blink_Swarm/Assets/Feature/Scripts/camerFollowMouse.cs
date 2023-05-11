using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerFollowMouse : MonoBehaviour
{

    //var
    float rotateX;
    float mSens = 90f;
    public Transform player;

    private void Start()
    {

        //hide cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mY = Input.GetAxis("Mouse Y") * Time.deltaTime * mSens;
        float mX = Input.GetAxis("Mouse X") * Time.deltaTime * mSens;

        //cam up & down
        rotateX -= mY;
        rotateX = Mathf.Clamp(rotateX, -90f, 90f);
        transform.localEulerAngles = new Vector3(rotateX, 0f, 0f);

        //left & right
        player.Rotate(Vector3.up * mX);
    }
}
