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
		public int startPointX;
		public int startPointY;
		public int endPointX;
		public int endPointY;
	}
		

	// Use this for initialization
	void Start () {
		Instantiate (player, new Vector2 (LevelData [0].startPointX, LevelData [0].startPointY), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
