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

		disableListener ();
		Debug.Log ("Initial volume change");
	}

	void Update(){
		//Debug.Log("Hello I am trying to call these methods");
		//disableListener ();
		//enableListener ();
	}
	
		void disableListener ()
	{
		//if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log ("I am trying to turn the volume down");
		AudioListener.volume = 0.0F;
			Debug.Log ("volume turned down");
		//}
	}
		
	void enableListener ()
	{
		//if (Input.GetKeyDown (KeyCode.S)) {
			Debug.Log ("I am trying to turn the volume down");
		AudioListener.volume = 1.0F;
			Debug.Log ("volume turned up");
		//}
		
	}
}
