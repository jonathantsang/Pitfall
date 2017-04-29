using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBeam : TimedObject {

	protected int beamOn = 3;

	private GameObject beam;

	// Use this for initialization
	void Start () {
		base.findNumDict ();

		// cycle object is 0 to 4, increasing by 1 each time
		timedCycle = new Cycle (0, 4, 1);
		hazardCycle = new Cycle (2, 4);

		// beam sprite is second child
		beam = gameObject.transform.GetChild (1).gameObject;
		beam.SetActive (false);
		base.updateNumber ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void incrementTimedCycle(){
		if (timedCycle == null) {
			Debug.Log ("timedCycle is null");
			return;
		} else {
			// Adds the increment
			timedCycle.currentNum += timedCycle.increment;
			// Finds the overflow if needed
			timedCycle.currentNum = timedCycle.minNum + timedCycle.currentNum % timedCycle.maxNum;
			checkTurnOffBeam ();
		}
	}

	void checkTurnOffBeam(){
		// Make beamOn a Cycle object to make it longer
		if (timedCycle.currentNum >= hazardCycle.minNum && timedCycle.currentNum < hazardCycle.maxNum) {
			beam.SetActive (true);
		} else {
			beam.SetActive (false);
		}
	
	}
		

}
