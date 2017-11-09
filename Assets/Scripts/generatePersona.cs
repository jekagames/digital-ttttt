using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class generatePersona : MonoBehaviour {

public Flowchart maingame;
public string myPersonaName;
public string myPersonaTitle;
public string myPersonaPosCharacter;
public string myPersonaNegCharacter;
public Text personaText;
	// Use this for initialization
	void Start () { 

		getName ();
		getTitle ();
		getChar ();
		personaText.text = "[TROUBLESHOOTER ON DUTY: " + myPersonaName + " the " + myPersonaTitle + "]";
	
		maingame.SetStringVariable ("myPersonaName", myPersonaName);
		maingame.SetStringVariable ("myPersonaTitle", myPersonaTitle);
		maingame.SetStringVariable ("myPersonaPosCharacter", myPersonaPosCharacter);
		maingame.SetStringVariable ("myPersonaNegCharacter", myPersonaNegCharacter);
	}
		

	void getName() 
	{
		Debug.Log ("Getting the name");
		List<string> personaName = new List<string>();
		personaName.Add("Apple");
		personaName.Add("Guybrush");
		personaName.Add("Rue");
		personaName.Add("Lex");
		personaName.Add("Snugglecakes");
		personaName.Add("Clark");
		personaName.Add("Likki");
		personaName.Add("Timberly");
		personaName.Add("Pothos");
		personaName.Add("Morgan");
		personaName.Add("Chris");
		personaName.Add("Tuck");
		personaName.Add("Ainsley");
		personaName.Add("Pomme");
		personaName.Add("Kimothy");
		personaName.Add("Quarky");
		personaName.Add("Avocado");
		personaName.Add("Dominique");
		personaName.Add("Bo");
		personaName.Add("Hivemind");
		personaName.Add("Red");
		personaName.Add("Quinn");
		personaName.Add("Charlie");
		personaName.Add("Llewellyn");
		personaName.Add("Andy");
		personaName.Add("Finn");

		//pull a persona name randomly from the list
		myPersonaName = personaName[Random.Range(0, Mathf.RoundToInt(personaName.Count-1))];
		Debug.Log ("Got the Name");
	}

	void getTitle()
	{
		Debug.Log ("Getting the title");
		List<string> personaTitle = new List<string>();
		personaTitle.Add("Obscure");
		personaTitle.Add("Alluring");
		personaTitle.Add("Smooth");
		personaTitle.Add("Youthful");
		personaTitle.Add("Beautiful");
		personaTitle.Add("Scatterbrained");
		personaTitle.Add("Gentle");
		personaTitle.Add("Cat");
		personaTitle.Add("Snake");
		personaTitle.Add("Astounding");
		personaTitle.Add("Snark");
		personaTitle.Add("Biter");
		personaTitle.Add("Fabulous");
		personaTitle.Add("Gorgeous");
		personaTitle.Add("Ticklish");
		personaTitle.Add("Elderly");
		personaTitle.Add("Obvious");
		personaTitle.Add("Moustache");
		personaTitle.Add("Cuddly");
		personaTitle.Add("Crunchy");
		personaTitle.Add("Muscular");
		personaTitle.Add("Unicorn");
		personaTitle.Add("Magnificent");
		personaTitle.Add("Bloody");
		personaTitle.Add("Sassy");
		personaTitle.Add("Sparrow");

		myPersonaTitle = personaTitle [Random.Range (0, Mathf.RoundToInt(personaTitle.Count - 1))];
		Debug.Log ("Got the Title");
	}

	void getChar(){
		Debug.Log ("Getting the persona");
		List<string> personaCharacter = new List<string>();
		personaCharacter.Add("time management");
		personaCharacter.Add("sensitivity");
		personaCharacter.Add("sense of smell");
		personaCharacter.Add("self care");
		personaCharacter.Add("scalp massage technique");
		personaCharacter.Add("sarcasm");
		personaCharacter.Add("patience");
		personaCharacter.Add("pain tolerance");
		personaCharacter.Add("listening");
		personaCharacter.Add("fine motor skills");
		personaCharacter.Add("fashion sense");
		personaCharacter.Add("dexterity");
		personaCharacter.Add("dance moves");
		personaCharacter.Add("cooking");
		personaCharacter.Add("constitution");
		personaCharacter.Add("conflict resolution");
		personaCharacter.Add("comedic timing");
		personaCharacter.Add("cleanliness");
		personaCharacter.Add("charisma");
		personaCharacter.Add("business sense");
		personaCharacter.Add("bedside manner");
		personaCharacter.Add("ability to think on your feet");
		personaCharacter.Add("ability to remember important dates");
		personaCharacter.Add("ability to read facial expressions");
		personaCharacter.Add("ability to find the perfect gift");
		personaCharacter.Add("ability to care for living creatures");

		myPersonaPosCharacter = personaCharacter [Random.Range (0, Mathf.RoundToInt(personaCharacter.Count - 1))];
		myPersonaNegCharacter = personaCharacter [Random.Range (0, Mathf.RoundToInt(personaCharacter.Count - 1))];
		Debug.Log ("Got the persona characteristics");
	}


	// Update is called once per frame
	void Update () {
		
	}


}
