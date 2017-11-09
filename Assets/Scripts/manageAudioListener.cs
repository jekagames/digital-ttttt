using UnityEngine;
using System.Collections;
using Fungus;


public class manageAudioListener : MonoBehaviour
{
	public Flowchart SeparatedInstructions;
	public Flowchart PauseMenu;
	public Flowchart EndofGameText;
	public Flowchart MainGameText;
	private AudioListener myAudioListener;

	void Start ()
	{

		myAudioListener = GetComponent<AudioListener>();
		Debug.Log ("I got the AudioListener");
	}

	void Update(){
		//Debug.Log("Hello I am trying to call these methods");
		//disableListener ();
		//enableListener ();
	}
	
		void disableListener ()
	{
		//if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log ("Hello I am trying to work on disabling");
			myAudioListener.enabled = false;
			Debug.Log ("Listener Disabled");
		//}
	}
		
	void enableListener ()
	{
		//if (Input.GetKeyDown (KeyCode.S)) {
			Debug.Log ("Hello I am trying to work on enabling");
			myAudioListener.enabled = true;
			Debug.Log ("Listener Enabled");
		//}
		
	}
}
