using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthModifier : MonoBehaviour {
		
	public Text livesTargetText;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			statsManager.health++;
			Debug.Log (statsManager.health);
			livesTargetText.text = statsManager.health.ToString();
		}
	}
}
