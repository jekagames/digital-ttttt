using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class onManualClick : MonoBehaviour {
	public Flowchart flowchart;
	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown () {
		manualButtonClicked ();
	}

	void manualButtonClicked() {
			Debug.Log ("You clicked the Manual");
			flowchart.ExecuteBlock ("Menu");
	}
}
