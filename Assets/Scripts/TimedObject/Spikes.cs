using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : TimedObject {

	protected int spikesOn = 3;

	private GameObject spikes;

	// Use this for initialization
	void Start () {
		base.findNumDict ();

		// cycle object is 0 to 4, increasing by 1 each time
		timedCycle = new Cycle (0, 4, 1);

		// spike sprite is second child
		spikes = gameObject.transform.GetChild (1).gameObject;
		spikes.SetActive (false);
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
		if (timedCycle.currentNum == spikesOn) {
			spikes.SetActive (true);
		} else {
			spikes.SetActive (false);
		}
	
	}
		

}
