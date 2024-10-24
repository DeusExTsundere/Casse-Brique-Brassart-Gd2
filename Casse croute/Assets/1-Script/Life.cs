using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private int lifePoint = 3;
    public int LifePoint 
    {  
        get { return lifePoint; } 
        set {lifePoint = value; } 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lifePoint <1 )
        {

        } 
    }
}
