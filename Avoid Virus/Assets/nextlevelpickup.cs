using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevelpickup : MonoBehaviour
{
    public GameObject arrowpickup;
    public GameObject pauseMenuUI;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Dino"))
        {

            pauseMenuUI.SetActive(true);
            Destroy(arrowpickup);
            Time.timeScale = 0f;
        }
    }
}
