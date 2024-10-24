using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    [SerializeField] private int speedDivide = 10;
    private sideLimit sideReach = sideLimit.none;
    RaycastHit2D hit;
    private Vector2 direction;
    private Vector2 position;
    private void Update()
    {
        if(Physics2D.Raycast(transform.position, transform.forward,0.5f))
        {
            if(hit.collider.gameObject.GetComponent<TagAttribute>)
        }
        position = transform.position;
        if (true)
        {
            position += direction;
        }
        else if (true)
        {
            position -= -direction;
        }

        transform.position = position;
    }

    public void ListenerControl(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
        direction.x = direction.x / speedDivide;
    }
}

enum sideLimit
{
    left,
    right,
    none
}
