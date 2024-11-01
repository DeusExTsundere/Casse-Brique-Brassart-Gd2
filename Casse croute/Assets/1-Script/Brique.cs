using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.iOS;
using UnityEngine.UIElements;

public class Brique : MonoBehaviour
{
    [SerializeField,Range(1,4)] private int collisionRemaining = 1;
    [SerializeField] private GameObject[] bonus;
    private SpriteRenderer SpriteRenderer;
    private int randomizerBonus;

    private void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        if (collisionRemaining == 1)
        {
            SpriteRenderer.color = Color.white;
        }
        else if (collisionRemaining == 2)
        {
            SpriteRenderer.color = Color.yellow;
        }
        else if ( collisionRemaining == 3)
        {
            SpriteRenderer.color = Color.red;
        }
        else if ( collisionRemaining == 4)
        {
            SpriteRenderer.color = Color.blue;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            collisionRemaining --;
            if (collisionRemaining == 1)
            {
                SpriteRenderer.color = Color.white;
            }
            else if (collisionRemaining == 2)
            {
                SpriteRenderer.color = Color.yellow;
            }
            else if (collisionRemaining == 3)
            {
                SpriteRenderer.color = Color.red;
            }
            else if (collisionRemaining == 4)
            {
                SpriteRenderer.color = Color.blue;
            }
            if (collisionRemaining < 1)
            {
                //randomizerBonus = Random.Range(-1, 15);
                //if (randomizerBonus == 0)
                //{
                //    randomizerBonus = Random.Range(-1, bonus.Length);
                //    Instantiate(bonus[randomizerBonus]);
                //}
                Destroy(gameObject);
            }
        }
    }
}
