using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputActionMovement : MonoBehaviour
{

    public float speed = 4;

    public InputAction move;
    
    void OnEnable()
    {
        move.Enable();
    }

    void OnDisable()
    {
        move.Disable();
    }

    void Start() {
        move.performed += ctx => { OnMove(ctx); };
    }

    void Update()
    {
        float moveAmount = move.ReadValue<float>();
        transform.Translate( moveAmount * transform.right * speed * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context) {
        // Debug.Log("WE ARE MOVING!!");
    }

}
