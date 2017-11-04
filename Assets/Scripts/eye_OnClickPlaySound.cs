using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eye_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> eyeClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-01"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-02"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-03"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-04"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-05"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-06"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-07"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-08"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-09"));
		eyeClips.Add ((AudioClip)Resources.Load ("Sounds/eye-10"));
		Debug.Log("The eye audio loaded");
	}

	void OnMouseDown ()
	{
		Debug.Log("Clicked the eye!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  eyeClips[Random.Range(0,eyeClips.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}
}