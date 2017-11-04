using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beaker_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> beakerClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		beakerClips.Add ((AudioClip)Resources.Load ("Sounds/beaker-01"));
		beakerClips.Add ((AudioClip)Resources.Load ("Sounds/beaker-02"));
		beakerClips.Add ((AudioClip)Resources.Load ("Sounds/beaker-03"));
		beakerClips.Add ((AudioClip)Resources.Load ("Sounds/beaker-04"));
		beakerClips.Add ((AudioClip)Resources.Load ("Sounds/beaker-05"));
		beakerClips.Add ((AudioClip)Resources.Load ("Sounds/beaker-06"));
		beakerClips.Add ((AudioClip)Resources.Load ("Sounds/beaker-07"));
		beakerClips.Add ((AudioClip)Resources.Load ("Sounds/beaker-08"));
		Debug.Log("The beaker audio loaded");
	}

	void OnMouseDown ()
	{
		Debug.Log("Clicked the beaker!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  beakerClips[Random.Range(0,beakerClips.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}
}