using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject ballPrefab;
    private string text;
    private GameObject ballFinder =null;
    private int lifePoint = 3;

    private void Start()
    {
        ballPrefab = Instantiate(ball, transform.position, Quaternion.identity);
        ballPrefab.transform.parent = transform;
        text = "Life : " + lifePoint;
        lifeText.SetText(text);
    }

    public void CheckLife()
    {
        ballFinder = GameObject.FindGameObjectWithTag("Ball");
        if ( ballFinder == null )
        {
            lifePoint--;
            if ( lifePoint > 0)
            {
                ballPrefab = Instantiate(ball, transform.position, Quaternion.identity);
                ballPrefab.transform.parent = transform;
            }
        }
        text = "Life : " + lifePoint;
        lifeText.SetText(text);
    }
}
