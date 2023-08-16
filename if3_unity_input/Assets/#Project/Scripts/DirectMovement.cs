using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DirectMovement : MonoBehaviour
{

    public float speed;

    void Update()
    {

        Keyboard kb = Keyboard.current;

        if (kb.leftArrowKey.isPressed) {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        if (kb.rightArrowKey.isPressed) {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }        

    }
}
