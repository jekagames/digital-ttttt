using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> plantClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-01"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-02"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-03"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-04"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-05"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-06"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-07"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-08"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-09"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-10"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-11"));
		plantClips.Add ((AudioClip)Resources.Load ("Sounds/plant-12"));

		Debug.Log("plant audio loaded");
	}

	void OnMouseDown ()
	{
		Debug.Log("Clicked the plant!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  plantClips[Random.Range(0,plantClips.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}
}


