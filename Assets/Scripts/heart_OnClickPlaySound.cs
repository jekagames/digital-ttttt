using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> heartClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-01"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-02"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-03"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-04"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-05"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-06"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-07"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-08"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-09"));
		heartClips.Add ((AudioClip)Resources.Load ("Sounds/heart-10"));
		Debug.Log("The heart audio loaded");
	}

	void OnMouseDown ()
	{
		Debug.Log("Clicked the heart!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  heartClips[Random.Range(0,heartClips.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}
}