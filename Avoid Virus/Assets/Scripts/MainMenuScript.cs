using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
		SceneManager.LoadScene ("Scene01");
	}

	// Load Trophy Room scene when trophy room button is pressed
	public void GotoTrophyRoom()
	{
		SceneManager.LoadScene ("TrophyRoom");
	}

	// Reset All Player Preferences data to start earn trophies again
	public void ResetPlayerPrefs()
	{
		PlayerPrefs.DeleteAll ();
	}

}
