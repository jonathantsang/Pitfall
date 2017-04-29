using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObject : MonoBehaviour {

	protected Cycle timedCycle;
	protected Cycle hazardCycle;
	protected NumberDictionary numDict;

	protected GameObject number;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public virtual void incrementTimedCycle(){
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

	// Make sure the number is the first child
	public void updateNumber(){
		// number is first child
		number = gameObject.transform.GetChild (0).gameObject;
		// Assign the number to the sprite
		number.GetComponent<SpriteRenderer> ().sprite = numDict.redNumSprites[timedCycle.currentNum];
	}

	public void findNumDict(){
		numDict = GameObject.FindGameObjectWithTag ("numDict").GetComponent<NumberDictionary>();
		if (numDict == null) {
			Debug.Log ("error finding numdict");
		}
	}

		
}
