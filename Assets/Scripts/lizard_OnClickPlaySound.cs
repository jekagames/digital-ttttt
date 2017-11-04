using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizard_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> lizardClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-01"));
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-02"));
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-03"));
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-04"));
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-05"));
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-06"));
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-07"));
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-08"));
		lizardClips.Add ((AudioClip)Resources.Load ("Sounds/lizard-09"));
		Debug.Log("Lizard audio loaded");
	}

		void OnMouseDown ()
		{
			Debug.Log("Clicked the lizard!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
		transform.GetComponent<AudioSource>().clip =  lizardClips[Random.Range(0,lizardClips.Count)];
		transform.GetComponent<AudioSource>().Play();
		}
	}
}


