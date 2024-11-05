using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMecanique : MonoBehaviour
{
    [SerializeField] private GameObject winUi;
    [SerializeField] private GameObject player;
    private GameObject brique;

    void Update()
    {
        brique = GameObject.FindGameObjectWithTag("Brique");
        if (brique == null)
        {
            winUi.SetActive(true);
            player.SetActive(false);
        }
    }
}
