using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private string level_1;

    public void Startlevel1()
    {
        SceneManager.LoadScene(level_1);
    }
}
