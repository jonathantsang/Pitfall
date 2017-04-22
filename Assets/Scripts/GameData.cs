using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

	public static GameData instance;
	public GameObject player;

	public levelData[] LevelData;

	void Awake(){
		// Singleton Behaviour
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);    
		DontDestroyOnLoad(gameObject);
	}

	[System.Serializable]
	public class levelData{
		public Transform startPoint;
		public Transform endPoint;
	}
		

	// Use this for initialization
	void Start () {
		Instantiate (player, LevelData[0].startPoint.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
