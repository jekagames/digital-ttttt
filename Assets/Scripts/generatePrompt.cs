using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class generatePrompt : MonoBehaviour {

	public Flowchart maingame;
	public string myPrompt1;
	public string myPrompt2;


	// Use this for initialization
	void Start () {
		reRollPrompt ();
		InvokeRepeating ("reRollPrompt", 1, 1);
	
		}

	void getPrompt(){
		Debug.Log ("Getting the prompt");
		List<string> promptGen = new List<string>();
		promptGen.Add("you were completely exhausted");
		promptGen.Add("something ended abruptly");
		promptGen.Add("you felt like everything was going wrong all at once");
		promptGen.Add("you were told you were needed, but all you wanted to do was rest");
		promptGen.Add("you had to decide between two outcomes");
		promptGen.Add("you were told to rest but all you wanted to do was be needed");
		promptGen.Add("you that that world was ending...and it was");
		promptGen.Add("you were scared of missing out on an activity");
		promptGen.Add("someone you trusted betrayed you");
		promptGen.Add("there weren't enough hours in a day");
		promptGen.Add("you misunderstood a signal");
		promptGen.Add("you had trouble deciding what to do with your time");
		promptGen.Add("you understood the signals perfectly");
		promptGen.Add("you felt like you were surrounded by people who didn't understand anything");
		promptGen.Add("a signal misunderstood you");
		promptGen.Add("you felt like the only person who didn't understand what was being said");
		promptGen.Add("you changed your mind in the middle of a complex task");
		promptGen.Add("you overthought your appearance");
		promptGen.Add("you felt vulnerable");
		promptGen.Add("you were underdressed for an occasion");
		promptGen.Add("the sign and the signifier were perfectly in sync");
		promptGen.Add("you were unsure if anything in this world could last forever");
		promptGen.Add("you had to go to the bathroom at the most inopportune moment");
		promptGen.Add("you couldn't make your body do what your brain wanted it to do");
		promptGen.Add("you cried for days");
		promptGen.Add("the task at hand seemed to take forever");
		promptGen.Add("you were stopped up for days");
		promptGen.Add("you were sick of sharing");
		promptGen.Add("you had a question but you didn't ask it");
		promptGen.Add("you wanted to share, but nobody wanted what you had to give");
		promptGen.Add("you had an answer but you didn't give it");
		promptGen.Add("the pain would never stop");
		promptGen.Add("literally everyone was watching you");
		promptGen.Add("nothing made sense");
		promptGen.Add("you couldn't think of anything");
		promptGen.Add("you no longer had control of your life");
		promptGen.Add("you had a gift but you returned it");
		promptGen.Add("something that happened to you felt like it could have been in a movie");
		promptGen.Add("you felt like you needed more privacy");
		promptGen.Add("you were in a conundrum");
		promptGen.Add("you were going through a big change");
		promptGen.Add("nothing seemed to make any sense");
		promptGen.Add("you suspected you weren't being told the whole story");
		promptGen.Add("you wanted to be recognized for your accomplishments");
		promptGen.Add("you needed a way out");
		promptGen.Add("you were bbetween a rock and a hard place");
		promptGen.Add("you felt like you were uninentionally annoying someone but didn't know how or why");
		promptGen.Add("you wondered what it would be like to start over");
		promptGen.Add("you were mesmerized by what turned out to be a humbug");
		promptGen.Add("you wondered whether what you were doing was healthy");
		promptGen.Add("you were hungry");
		promptGen.Add("you were haunted by the past");
		promptGen.Add("you smelled something very distinct and memorable");
		promptGen.Add("somebody wanted more than you could give");
		promptGen.Add("you felt like magic was alive and well in the world");
		promptGen.Add("you gave someone more than they wanted");
		promptGen.Add("you thought things couldn't get any worse");
		promptGen.Add("you couldn't finish what you started");
		promptGen.Add("you felt literal electricity between yourself and another person");
		promptGen.Add("something ended and you didn't know what to do with yourself afterwards");
		promptGen.Add("you flirted with someone inappropriately");
		promptGen.Add("you needed to ask for help but you couldn't get out the words");
		promptGen.Add("someone flirted with you inappropriately");
		promptGen.Add("you weren't being heard");
		promptGen.Add("you flirted with someone appropriately");
		promptGen.Add("you were entrusted with a secret");
		promptGen.Add("you made eye contact for an uncomfortably long time");
		promptGen.Add("you felt disrespected");
		promptGen.Add("you were that hand that fed and were bitten");
		promptGen.Add("you felt discombobulated");
		promptGen.Add("you drastically changed your appearance");
		promptGen.Add("you accidentally said something you shouldn't have");
		promptGen.Add("an animal understood you better than any human ever could");
		promptGen.Add("you said exactly what you meant but later regretted it");
		promptGen.Add("you felt old");
		promptGen.Add("every time you spoke, you were more misunderstood");
		promptGen.Add("you felt young");
		promptGen.Add("your decisions took on a life of their own");
		promptGen.Add("you felt old but then realized you were young");
		promptGen.Add("you felt hopeful for the future");
		promptGen.Add("you couldn't get what you wanted, no matter how hard you tried");
		promptGen.Add("you wanted for nothing");
		promptGen.Add("you were too shy to speak up about what you wanted");
		promptGen.Add("you wished for more than this world could give you");
		promptGen.Add("you spoke up about what you wanted and got shot down");
		promptGen.Add("you were able to cut loose");
		promptGen.Add("you were doing more than your fair share");
		promptGen.Add("you weren't able to care");
		promptGen.Add("someone else was doing all the work and you felt guilty");
		promptGen.Add("you cared too much");
		promptGen.Add("a product was not as advertised");
		promptGen.Add("you stayed in bed and it was glorious");
		promptGen.Add("you wanted to be left alone");
		promptGen.Add("you were ridiculed for your decisions");
		promptGen.Add("you wanted to be surrounded with people but not interact with any of them");
		promptGen.Add("you proved everyone wrong");
		promptGen.Add("you struggled to reach the next level");
		promptGen.Add("you realized that you could overcome a hard situation");
		promptGen.Add("you had to make an important life choice");
		promptGen.Add("you proved everyone right");

		myPrompt1 = promptGen [Random.Range (0, Mathf.RoundToInt(promptGen.Count - 1))];
		myPrompt2 = promptGen [Random.Range (0, Mathf.RoundToInt(promptGen.Count - 1))];
		Debug.Log ("Got the prompt");
	}


	void reRollPrompt () {
		getPrompt ();
		maingame.SetStringVariable ("myPrompt1", myPrompt1);
		maingame.SetStringVariable ("myPrompt2", myPrompt2);
	}
}
