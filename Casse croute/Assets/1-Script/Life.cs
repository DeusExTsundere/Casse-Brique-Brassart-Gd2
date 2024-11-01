using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private GameObject ballPrefab;
    private GameObject ballFinder =null;
    private int lifePoint = 3;
    public int LifePoint 
    {  
        get { return lifePoint; } 
        set {lifePoint = value; } 
    }

    private void Start()
    {
        ballPrefab = Instantiate(ball, transform.position, Quaternion.identity);
        ballPrefab.transform.parent = transform;
        //Instantiate(ball);
    }

    void Update()
    {
        if (lifePoint >1 )
        {
            ballFinder = GameObject.FindGameObjectWithTag("Ball");
            if ( ballFinder = null )
            {
                ballPrefab = Instantiate(ball,transform.position,Quaternion.identity);
                ballPrefab.transform.parent = transform;
                //Instantiate(ball);
            }
        } 
    }
}
