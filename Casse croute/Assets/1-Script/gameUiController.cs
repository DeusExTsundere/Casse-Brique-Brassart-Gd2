using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameUiController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScore;

    private void OnEnable()
    {
        finalScore.SetText("Final Score : " + PlayerPrefs.GetInt("TotalScore"));
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
