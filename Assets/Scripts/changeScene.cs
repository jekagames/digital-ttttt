using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	void Update(){
		if (Input.anyKey)
		{
			Debug.Log ("You pressed a key");	
		SceneManager.LoadScene("ttttt-main", LoadSceneMode.Single);
		}
	}
}
