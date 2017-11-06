using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playIntro : MonoBehaviour {

	public List<AudioClip> introClip = new List<AudioClip>();

	void Start(){
		// SoundFolder should be in Assets/Resources 
		introClip.Add ((AudioClip)Resources.Load ("Sounds/intro"));
		Debug.Log("The intro audio loaded");
		InvokeRepeating ("playSound", 2, 10);
	}



	void playSound ()
	{
		Debug.Log("Playing the intro");
		if (!transform.GetComponent<AudioSource>().isPlaying)
		{
			transform.GetComponent<AudioSource>().clip =  introClip[Random.Range(0,introClip.Count)];
			transform.GetComponent<AudioSource>().Play();
		}
	}


}