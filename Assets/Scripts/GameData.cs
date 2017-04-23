using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

	public static GameData instance;
	public GameObject player;

	public static int level;
	public LevelData[] levelData;

	void Awake(){
		// Singleton Behaviour
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);    
		DontDestroyOnLoad(gameObject);
	}

	[System.Serializable]
	public class LevelData{
		// Storing start and end as transforms for now
		public Transform startPoint;
		public Transform endPoint;

		// boundary object
		public boundary levelBounds;
	}

	// On LEVEL LOAD *** FIX *** the finding of start and end point

	// Use this for initialization
	void Start () {
		levelData [level].startPoint = GameObject.FindGameObjectWithTag ("start").transform;
		levelData [level].endPoint = GameObject.FindGameObjectWithTag ("end").transform;

		Instantiate (player, levelData[0].startPoint.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
