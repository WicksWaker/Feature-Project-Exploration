using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody rigidBody;
    private PlayerInputActions playerInputActions;
    private InputAction swarm;
    private InputAction blink;
    private InputAction jump;
    [SerializeField]
    private GameObject spawner;
    private GameObject portal;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();
        rigidBody = GetComponent<Rigidbody>();

        swarm = playerInputActions.Player.Swarm;
        swarm.Enable();
        Debug.Log("It Swarmed");

        jump = playerInputActions.Player.Jump;
        jump.Enable();
        Debug.Log("Jump Scare");

        blink = playerInputActions.Player.Blink;
        blink.Enable();
        Debug.Log("It Blinked");
    }

    private void FixedUpdate()
    {
        Vector2 moveVec = playerInputActions.Player.Move.ReadValue<Vector2>();
        rigidBody.AddForce(new Vector3(moveVec.x, 0, moveVec.y) * 5f, ForceMode.Force);

    }

    private void OnEnable()
    {
        playerInputActions.Player.Move.performed += OnMove;
        swarm.performed += OnSwarm;
        blink.performed += OnBlink;
        jump.performed += OnJump;
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
        //need to implement jump
        if (context.performed)
        {
            rigidBody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }

    //calls Swarm
    public void OnSwarm(InputAction.CallbackContext context)
    {
        spawner.GetComponent<ratMove>().ratSpawner();
    }

    //calls Blink
    public void OnBlink(InputAction.CallbackContext context)
    {
        GetComponent<playerBlink>(); 
    }

    public void PrintText(string text)
    {
        Debug.Log(text);
    }

}
