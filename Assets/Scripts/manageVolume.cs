using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageColliders : MonoBehaviour {

	// Use this for initialization
	void disableSound () {
		AudioListener.volume = 0;
	}
	
	// Update is called once per frame
	void enableSound () {
		AudioListener.volume = 1;
	}
}
