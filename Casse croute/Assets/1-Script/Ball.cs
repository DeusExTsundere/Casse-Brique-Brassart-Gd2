using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    private AudioSource m_AudioSource;
    private Vector2 inDirection;
    private Vector2 inNormal;
    private bool kicked = false;
    private float speed =1.0f;
    private Rigidbody2D rb;
    private GameObject player;
    private GameObject otherBall = null;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        rb.Sleep();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        m_AudioSource.Play();
        inDirection = rb.velocity;
        inNormal = collision.contacts[0].normal;
        Vector2.Reflect(inDirection,inNormal);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (rb.velocity.x > 0)
        {
            rb.velocity += new Vector2(0.01f,0);
        }
        else
        {
            rb.velocity -= new Vector2(0.1f,0);
        }
        if (rb.velocity.y > 0)
        {
            rb.velocity += new Vector2(0, 0.01f);
        }
        else
        {
            rb.velocity -= new Vector2(0, 0.01f);
        }

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        player.GetComponent<Life>().CheckLife();
    }

    public void kick(InputAction.CallbackContext context)
    {
        if (context.started && transform.parent != null)
        {
            rb.IsAwake();
            kicked = true;
            rb.AddForce(transform.right * (transform.parent.position.x/7) * -100);
            rb.AddForce(transform.up * 100);
        }
        transform.parent = null;
    }

}
