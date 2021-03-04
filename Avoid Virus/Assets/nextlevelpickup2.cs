using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextlevelpickup2 : MonoBehaviour
{
    public GameObject arrowpickup;
    public GameObject pauseMenuUI;
    int marks;
    float timetaken;
    int yourScore;

    [SerializeField]
    Text Marks;

    [SerializeField]
    Text TimeTaken;

    [SerializeField]
    Text Score;

    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Dino"))
        {
            
            Time.timeScale = 0f;
            yourScore = PlayerPrefs.GetInt("yourScore");
            Score.text = "Your Score: "+yourScore;
            timetaken = Time.time;
            PlayerPrefs.SetFloat("timetaken", timetaken);
            TimeTaken.text = "Time Taken: " + timetaken +"s";
            marks = PlayerPrefs.GetInt("marks");
            Marks.text = "Marks: " + marks +"/15";
            pauseMenuUI.SetActive(true);
            
        }
    }
}
