using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private GameObject onGameUi;
    [SerializeField] private GameObject loseUi;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject ballPrefab;
    private string scoringText;
    private string text;
    private GameObject ballFinder =null;
    private int lifePoint = 3;
    public int LifePoint 
    {  
        get { return lifePoint; } 
        set { lifePoint = value; } 
    }


    private void Start()
    {
        ballPrefab = Instantiate(ball, transform.position, Quaternion.identity);
        ballPrefab.transform.parent = transform;
        text = "Life : " + lifePoint;
        lifeText.SetText(text);
        PlayerPrefs.SetInt("TotalScore", 0);
    }

    private void Update()
    {
        scoringText = ("Score : " + PlayerPrefs.GetInt("TotalScore"));
        scoreText.SetText(scoringText);
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
            else if (lifePoint == 0)
            {
                onGameUi.SetActive(false);
                loseUi.SetActive(true);
            }
        }
        text = "Life : " + lifePoint;
        lifeText.SetText(text);
    }
}
