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

        float direction = 0;

        if (kb.leftArrowKey.isPressed) {
            direction += -1;
        }
        if (kb.rightArrowKey.isPressed) {
            direction += 1;
        }        

        transform.Translate( direction * transform.right * speed * Time.deltaTime);

    }
}
