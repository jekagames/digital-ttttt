using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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


}
