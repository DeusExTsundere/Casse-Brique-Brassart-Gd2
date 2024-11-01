using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    RaycastHit2D hit;
    private float direction;
    private Vector2 new_position;
    private void Update()
    {
        new_position = transform.position;
        if ( direction > 0 && transform.position.x < 7)
        {
            new_position.x += speed/50;
        }
        else if ( direction < 0 && transform.position.x > -7 )
        {
            new_position.x -= speed/50;
        }
        transform.position = new_position;
    }

    public void ListenerControl(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<float>();    
    }
}

