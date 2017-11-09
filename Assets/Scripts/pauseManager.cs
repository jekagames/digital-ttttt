using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Fungus;

public class pauseManager : MonoBehaviour {

	public Flowchart flowchart;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update(){

		if (Input.GetKeyDown(KeyCode.Escape))
			{
			Debug.Log ("You pressed Escape");	
				flowchart.ExecuteBlock("Menu");
		}

				}

	void returnToMainMenu()
	{
		Debug.Log ("You pressed the mainscreen button");	
		SceneManager.LoadScene("ttttt-titlescreen", LoadSceneMode.Single);
	}

	void quitGame()
	{
		//Make the game Quit.
		Application.Quit();
	}
}
