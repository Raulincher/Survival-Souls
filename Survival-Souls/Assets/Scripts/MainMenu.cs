using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void QuitApplication()
    {
        Debug.Log("Exit game");
        Application.Quit();
    }
}
