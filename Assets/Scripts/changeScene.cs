﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	void Update(){
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log ("You pressed Spacebar");	
		SceneManager.LoadScene("ttttt-main", LoadSceneMode.Single);
		}
	}
}
