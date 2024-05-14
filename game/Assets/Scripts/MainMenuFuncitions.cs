using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFuncitions : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("MainHall");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
