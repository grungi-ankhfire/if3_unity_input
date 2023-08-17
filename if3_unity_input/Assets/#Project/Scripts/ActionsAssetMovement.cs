using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionsAssetMovement : MonoBehaviour
{

    public InputActionAsset actions;
    private InputAction move;
    public float speed;

    void OnEnable()
    {
        actions.FindActionMap("Player").Enable();
    }

    void OnDisable()
    {
        actions.FindActionMap("Player").Disable();
    }

    void Awake()
    {
        move = actions.FindActionMap("Player").FindAction("move");
    }

    void Update()
    {
        float moveAmount = move.ReadValue<float>();
        transform.Translate( moveAmount * transform.right * speed * Time.deltaTime);
    }
}
