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
			timedCycle.currentNum += timedCycle.increment;
			// If the increment pushes the current past the max
			while (timedCycle.currentNum > timedCycle.maxNum) {
				timedCycle.currentNum -= timedCycle.maxNum;
			}
		}

	}
}
