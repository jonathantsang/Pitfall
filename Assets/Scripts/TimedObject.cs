using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObject : MonoBehaviour {

	public Cycle timedCycle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void incrementTimedCycle(){
		if (timedCycle == null) {
			Debug.Log ("timedCycle is null");
			return;
		} else {
			// Adds the increment
			timedCycle.currentNum += timedCycle.increment;
			// Finds the overflow if needed
			timedCycle.currentNum = timedCycle.minNum + timedCycle.currentNum % timedCycle.maxNum;
		}
	}
		
}
