using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> fishClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-01"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-02"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-03"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-04"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-05"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-06"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-07"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-08"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-09"));
		fishClips.Add ((AudioClip)Resources.Load ("Sounds/fish-10"));
		Debug.Log("The fish audio loaded");
	}

	void OnMouseDown ()
	{
		Debug.Log("Clicked the fish!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  fishClips[Random.Range(0,fishClips.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}
}