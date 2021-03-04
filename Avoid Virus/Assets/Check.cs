using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Check : MonoBehaviour
{
    int marks = 0;
    public GameObject pauseMenuUI;
    public GameObject Correct;
    public GameObject Wrong;

   
    public void CorrectAnswer()
    {
        marks = PlayerPrefs.GetInt("marks");
        pauseMenuUI.SetActive(false);
        Correct.SetActive(true);
        marks++;
        PlayerPrefs.SetInt("marks", marks);
        UnityEngine.Debug.Log(marks);
    }
    public void WrongAnswer()
    {
        pauseMenuUI.SetActive(false);
        Wrong.SetActive(true);
        UnityEngine.Debug.Log(marks);
    }

    public void Proceed()
    {
        
        Wrong.SetActive(false);
        Correct.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        PlayerPrefs.SetInt("marks", 0);
    }
}
