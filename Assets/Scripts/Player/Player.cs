using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MovingObject {

	public static Player instance;

	// Use this for initialization
	void Start () {
		base.Start ();

		// Singleton Behaviour
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);    
	}
	
	// Update is called once per frame
	void Update () {
		movement ();
	}


}
