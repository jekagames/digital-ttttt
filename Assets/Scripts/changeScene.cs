using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	// Update is called once per frame
	void sceneChange () {
		if (Input.GetKey(KeyCode.UpArrow))
			Debug.Log ("A key or mousepress was detected");
		SceneManager.LoadScene("ttttt-main", LoadSceneMode.Single);
	}
}
