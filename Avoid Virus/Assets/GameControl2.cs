using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl2 : MonoBehaviour
{

	public static GameControl2 instance = null;

	[SerializeField]
	GameObject restartButton;

	[SerializeField]
	Text highScoreText;

	[SerializeField]
	Text yourScoreText;

	[SerializeField]
	GameObject[] obstacles;

	[SerializeField]
	Transform spawnPoint;

	[SerializeField]
	float spawnRate = 2f;
	float nextSpawn;

	[SerializeField]
	float timeToBoost = 5f;
	float nextBoost;

	int highScore = 0, yourScore,marks=0;
	
	public static bool gameStopped;
	float timetaken = 0;

	float nextScoreIncrease = 0f;

	// Use this for initialization
	void Start()
	{

		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);

		restartButton.SetActive(false);
		
		gameStopped = false;
		Time.timeScale = 1f;
		highScore = PlayerPrefs.GetInt("highScore");
		nextSpawn = Time.time + spawnRate;
		nextBoost = Time.unscaledTime + timeToBoost;
		marks = PlayerPrefs.GetInt("marks");
		PlayerPrefs.SetInt("marks", marks);
		timetaken = Time.time;
		yourScore= PlayerPrefs.GetInt("yourScore");
	}

	// Update is called once per frame
	void Update()
	{
		if (!gameStopped)
			IncreaseYourScore();

		highScoreText.text = "High Score: " + highScore;
		yourScoreText.text = "Your Score: " + yourScore;

		if (Time.time > nextSpawn)
			SpawnObstacle();

		if (Time.unscaledTime > nextBoost && !gameStopped)
			BoostTime();
	}

	public void DinoHit()
	{
		if (yourScore > highScore)
			PlayerPrefs.SetInt("highScore", yourScore);
		Time.timeScale = 0;
		gameStopped = true;
		restartButton.SetActive(true);
	}

	void SpawnObstacle()
	{
		nextSpawn = Time.time + spawnRate;
		int randomObstacle = Random.Range(0, obstacles.Length);
		Instantiate(obstacles[randomObstacle], spawnPoint.position, Quaternion.identity);
	}

	void BoostTime()
	{
		nextBoost = Time.unscaledTime + timeToBoost;
		Time.timeScale += 0.25f;
	}

	void IncreaseYourScore()
	{
		if (Time.unscaledTime > nextScoreIncrease && Time.timeScale != 0f)
		{
			yourScore += 1;
			nextScoreIncrease = Time.unscaledTime + 1;
		}
	}

	public void RestartGame()
	{
		timetaken = 0f;
		PlayerPrefs.SetFloat("timetaken", timetaken);
		SceneManager.LoadScene("Level1");
	}

	public void FinishLevel()
	{
		PlayerPrefs.SetInt("yourScore", yourScore);
		timetaken = Time.time;
		PlayerPrefs.SetFloat("timetaken", timetaken);
		UnityEngine.Debug.Log(timetaken + " Score " + yourScore);
	}
}