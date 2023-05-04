using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody rigidBody;
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector2 moveVec = playerInputActions.Player.Move.ReadValue<Vector2>();
        rigidBody.AddForce(new Vector3(moveVec.x, 0, moveVec.y) * 5f, ForceMode.Force);
    }

    //calls movement- up, down, left, right, WASD
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveVec = context.ReadValue<Vector2>();
        rigidBody.AddForce(new Vector3(moveVec.x,0, moveVec.y) * 5f, ForceMode.Force);
    }

    //calls Jump- Space Bar
    public void OnJump(InputAction.CallbackContext context)
    {
        //
    }

    //calls Swarm
    public void OnSwarm(InputAction.CallbackContext context)
    {
        GetComponent<Swarm>(); 
    }

    //calls Blink
    public void OnBlink(InputAction.CallbackContext context)
    {
        GetComponent<Blink>(); 
    }

    public void PrintText(string text)
    {
        Debug.Log(text);
    }

}
