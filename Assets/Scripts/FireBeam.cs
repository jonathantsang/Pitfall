using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBeam : TimedObject {

	private GameObject beam;
	private GameObject number;

	// Use this for initialization
	void Start () {
		base.findNumDict ();

		// cycle object is 0 to 4, increasing by 1 each time
		timedCycle = new Cycle (0, 4, 1);

		// Beam is second child
		beam = gameObject.transform.GetChild (1).gameObject;
		base.updateNumber ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
