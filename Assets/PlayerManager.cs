using System;
using UnityEngine;

public class PlayerManager
{
	public GUIText scoreText;
	private int score;
	public int hazardCount;
	public int cistern;
	public Cistern _cistern;
	public Plant _plant;


	public PlayerManager ()
	{
		score = 0;
		//scoreText = new GUIText();
		//scoreText.text = "Score: " + score;
		_cistern = new Cistern ();
		_plant = new Plant ();

	}
	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}
	public void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}


	public void GetHighScores()
	{
		for(int i = 0; i < 10; i++)
		{
			Debug.Log(PlayerPrefs.GetString(i + "HScoreName") + " has a score of: " +  PlayerPrefs.GetInt(i + "HScore"));
		}
	}
	public void AddHighScore(string name, int score)
	{
		int newScore;
		string newName;
		int oldScore;
		string oldName;
		newScore = score;
		newName = name;

		for(int i=0;i<10;i++)
		{
			if(PlayerPrefs.HasKey(i+"HScore"))
			{
				if(PlayerPrefs.GetInt(i+"HScore")< newScore)
				{ 
					// new score is higher than the stored score
					oldScore = PlayerPrefs.GetInt(i+"HScore");
					oldName = PlayerPrefs.GetString(i+"HScoreName");
					PlayerPrefs.SetInt(i+"HScore",newScore);
					PlayerPrefs.SetString(i+"HScoreName",newName);
					newScore = oldScore;
					newName = oldName;
				}
			}else
			{
				PlayerPrefs.SetInt(i+"HScore",newScore);
				PlayerPrefs.SetString(i+"HScoreName",newName);
				newScore = 0;
				newName = "";
			}
		}
	}
}


