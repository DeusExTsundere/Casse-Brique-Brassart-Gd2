using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject player;
    private GameObject otherBall = null;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            rb.velocity += new Vector2(0,0.2f) ;
        }
    }

    private void OnBecameInvisible()
    {
        otherBall = GameObject.FindGameObjectWithTag("Ball");
        if (otherBall = null)
        {
            player.GetComponent<Life>().LifePoint -= 1;
        }
        Destroy(gameObject);
    }

    public void kick(InputAction.CallbackContext context)
    {
        if (context.started && transform.parent != null)
        {
            rb.AddForce(transform.right * (transform.parent.position.x/7) * -100);
            rb.AddForce(transform.up * 100);
        }
        transform.parent = null;
    }

}
