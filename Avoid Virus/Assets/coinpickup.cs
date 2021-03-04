using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinpickup : MonoBehaviour
{
    public GameObject questioncoin;
    public GameObject pauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Dino"))
        {
            
            pauseMenuUI.SetActive(true);
            Destroy(questioncoin);
            Time.timeScale = 0f;
        }
    }
}
