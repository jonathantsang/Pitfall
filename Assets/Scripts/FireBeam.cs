using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBeam : TimedObject {

	private GameObject beam;
	private GameObject number;

	private NumberDictionary numDict;

	// Use this for initialization
	void Start () {
		numDict = GameObject.FindGameObjectWithTag ("numDict").GetComponent<NumberDictionary>();
		if (numDict == null) {
			Debug.Log ("error finding numdict");
		}

		// cycle object is 0 to 4, increasing by 1 each time
		timedCycle = new Cycle (0, 4, 1);

		// Beam is second child
		beam = gameObject.transform.GetChild (1).gameObject;
		// number is third child
		number = gameObject.transform.GetChild (2).gameObject;
		// Assign the number to the sprite
		number.GetComponent<SpriteRenderer> ().sprite = numDict.redNumSprites[timedCycle.currentNum];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
