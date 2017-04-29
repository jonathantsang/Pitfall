using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.CompareTag ("hurt")) {
			Debug.Log ("reload level");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.CompareTag ("end")) {
			Debug.Log ("finished level");
		}
	}
}
