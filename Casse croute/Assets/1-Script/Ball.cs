using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private void OnBecameInvisible()
    {
        player.GetComponent<Life>().LifePoint -= 1;
        Destroy(gameObject);
    }
}
