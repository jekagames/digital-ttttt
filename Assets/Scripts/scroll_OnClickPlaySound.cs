using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_OnClickPlaySound : MonoBehaviour {

	public List<AudioClip> scrollClips = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-01"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-02"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-03"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-04"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-05"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-06"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-07"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-08"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-09"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-10"));
		scrollClips.Add ((AudioClip)Resources.Load ("Sounds/scroll-11"));
		Debug.Log("scroll audio loaded");
	}

	void OnMouseDown ()
	{
		Debug.Log("Clicked the scroll!");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  scrollClips[Random.Range(0,scrollClips.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}
}