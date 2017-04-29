using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour {

	public static GameData instance;
	public GameObject player;

	public static int level;
	public static int numberMoves;
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

	// On LEVEL LOAD the finding of start and end point
	void OnEnable(){
		// Add delegates to this
		SceneManager.sceneLoaded += findSpawnPoints;
	}

	void OnDestroy(){
		SceneManager.sceneLoaded -= findSpawnPoints;
	}

	// Use this for initialization
	void Start () {
		// First time is free
		levelData [level].startPoint = GameObject.FindGameObjectWithTag ("start").transform;
		levelData [level].endPoint = GameObject.FindGameObjectWithTag ("end").transform;
		// Done in SpawnPlayer script now
		// Instantiate (player, levelData[0].startPoint.position, Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// for a move of y increment it by that and add to each timed moving object
	public static void moves(int y){
		GameData.numberMoves += y;
		// Find all objects affected by time
		GameObject[] objs = GameObject.FindGameObjectsWithTag ("timed");
		foreach (GameObject timedObj in objs) {
			// Check if the object is a firebeam object, check for others
			if (timedObj.GetComponent<FireBeam> () == null) {
				timedObj.GetComponent<TimedObject> ().incrementTimedCycle ();
			} else {
				timedObj.GetComponent<FireBeam> ().incrementTimedCycle ();
			}
			timedObj.GetComponent<TimedObject> ().updateNumber ();
		}
	}

	void findSpawnPoints(Scene scene, LoadSceneMode mode){
		levelData [level].startPoint = GameObject.FindGameObjectWithTag ("start").transform;
		levelData [level].endPoint = GameObject.FindGameObjectWithTag ("end").transform;
	}


}
