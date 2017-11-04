using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teeth_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> teethClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-01"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-02"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-03"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-04"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-05"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-06"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-07"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-08"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-09"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-10"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-11"));
		teethClips.Add ((AudioClip)Resources.Load ("Sounds/teeth-12"));
		Debug.Log("The teeth audio loaded");
	}

	void OnMouseDown ()
	{
		Debug.Log("Clicked the teeth!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  teethClips[Random.Range(0,teethClips.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}
}