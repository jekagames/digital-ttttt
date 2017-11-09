using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class generatePrompt : MonoBehaviour {

	public Flowchart maingame;
	public string myPrompt1;
	public string myPrompt2;

	// Use this for initialization
	void Start () {

			getPrompt ();
			maingame.SetStringVariable ("myPrompt1", myPrompt1);
			maingame.SetStringVariable ("myPrompt2", myPrompt2);
		}

	void getPrompt(){
		Debug.Log ("Getting the prompt");
		List<string> promptGen = new List<string>();
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");
		promptGen.Add("time management");

		myPrompt1 = promptGen [Random.Range (0, Mathf.RoundToInt(promptGen.Count - 1))];
		myPrompt2 = promptGen [Random.Range (0, Mathf.RoundToInt(promptGen.Count - 1))];
		Debug.Log ("Got the prompt");
	}


	// Update is called once per frame
	void Update () {
		
	}
}
