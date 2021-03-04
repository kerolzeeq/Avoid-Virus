using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadlevel2 : MonoBehaviour
{

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
