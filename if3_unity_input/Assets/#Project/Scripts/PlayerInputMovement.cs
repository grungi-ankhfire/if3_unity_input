using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputMovement : MonoBehaviour
{

    private PlayerInput playerInput;
    private InputAction move;
    public float speed;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        move = playerInput.actions["move"];
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed) {
            Debug.Log(context.control);
        }
    }

    private void Update()
    {
        float moveAmount = move.ReadValue<float>();
        transform.Translate( moveAmount * transform.right * speed * Time.deltaTime);
    }

}
