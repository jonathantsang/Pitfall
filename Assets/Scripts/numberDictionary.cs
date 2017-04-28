using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberDictionary : MonoBehaviour {

	public static NumberDictionary instance;

	public Sprite[] redNumSprites;
	public Sprite[] blueNumSprites;
	public Sprite[] greyNumSprites;

	// Use this for initialization
	void Start () {
		// Singleton Behaviour
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);    
		DontDestroyOnLoad(gameObject);
	}

	// Update is called once per frame
	void Update () {

	}
}
