using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireColumnBeam : MonoBehaviour {

	private GameObject beam;

	// Use this for initialization
	void Start () {
		// Beam is second child
		beam = gameObject.transform.GetChild (1).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
