using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ear_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> earClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-01"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-02"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-03"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-04"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-05"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-06"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-07"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-08"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-09"));
		earClips.Add ((AudioClip)Resources.Load ("Sounds/ear-10"));
		Debug.Log("The ear audio loaded");
	}

	void OnMouseDown ()
	{
		Debug.Log("Clicked the ear!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  earClips[Random.Range(0,earClips.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}
}