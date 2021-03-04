using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyRoomControlScript : MonoBehaviour {

	// References to trophies game objects to control
	public GameObject cup1, cup2, cup3;

	// Variables to contain Player Prefs values
	int cup1Got, cup2Got, cup3Got;

	// Use this for initialization
	void Start () {

		// Getting Player Prefs values to make sure you got
		// particular trophy
		cup1Got = PlayerPrefs.GetInt ("Cup1Got");
		cup2Got = PlayerPrefs.GetInt ("Cup2Got");
		cup3Got = PlayerPrefs.GetInt ("Cup3Got");

		// If you got trophy 1
		if (cup1Got == 1)
			// then it is shown on the shelf
			cup1.SetActive (true);
		// if you don't get it
		else
			// then it is not shown
			cup1.SetActive (false);

		// Same for trophy 2 and 3
		if (cup2Got == 1)
			cup2.SetActive (true);
		else
			cup2.SetActive (false);
		
		if (cup3Got == 1)
			cup3.SetActive (true);
		else
			cup3.SetActive (false);
	}

}
