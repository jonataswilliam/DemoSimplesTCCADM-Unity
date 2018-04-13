using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class questions_scene_comportament : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButton("Cancel")) {
			SceneManager.LoadScene ("class1");
		}
	}
}
