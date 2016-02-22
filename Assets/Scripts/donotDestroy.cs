using UnityEngine;
using System.Collections;

public class donotDestroy : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
}
