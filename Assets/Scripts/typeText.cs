using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class typeText : MonoBehaviour {

	public string myText = "Hello, what is your name, Stranger?";
	public string myOtherText = "Happy Birthday, Merlin!";
	public float interLetterTime;
	public Text targetTypeText;

	// Use this for initialization
	void Start () {
		StartCoroutine (addText (myOtherText));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator addText(string text){
		int textLength = text.Length;
		for (int i = 0; i < textLength + 1; i++) {
			targetTypeText.text = text.Substring (0, i);
			yield return new WaitForSeconds (interLetterTime);
		}
	}

}
