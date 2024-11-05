using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    [SerializeField] private GameObject player;
    private Vector3 initialScale;
    RaycastHit2D hit;
    private float direction;
    private Vector2 new_position;
    private int randomBoost;

    private void Start()
    {
        initialScale = transform.localScale;
    }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boost")
        {
            Debug.Log("Boost");
            randomBoost = Random.Range(0, 2);
            if (randomBoost == 1)
            {
                StartCoroutine(sizeUp());
            }
            else
            {
                player.GetComponent<Life>().LifePoint += 1;
            }
        }
    }

    IEnumerator sizeUp()
    {
        transform.localScale = transform.localScale * 2;
        yield return new WaitForSeconds(15);
        transform.localScale = initialScale;
    }
}

