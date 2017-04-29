using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPlayer : MonoBehaviour {

	public GameObject player;
	private GameData gamedata;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnEnable(){
		// Add delegates to this
		SceneManager.sceneLoaded += findGameData;
		SceneManager.sceneLoaded += findSpawnPoints;
		SceneManager.sceneLoaded += respawnPlayer;
	}

	void OnDestroy(){
		SceneManager.sceneLoaded -= findGameData;
		SceneManager.sceneLoaded -= findSpawnPoints;
		SceneManager.sceneLoaded -= respawnPlayer;
	}

	void findGameData(Scene scene, LoadSceneMode mode){
		gamedata = GameObject.FindGameObjectWithTag ("GameData").GetComponent<GameData> ();
		if (gamedata == null) {
			Debug.Log ("error in gamedata");
		}
	}

	void findSpawnPoints(Scene scene, LoadSceneMode mode){
		gamedata.levelData [GameData.level].startPoint = GameObject.FindGameObjectWithTag ("start").transform;
		gamedata.levelData [GameData.level].endPoint = GameObject.FindGameObjectWithTag ("end").transform;
	}

	public void respawnPlayer(Scene scene, LoadSceneMode mode){
		Debug.Log ("respawn player");
		Instantiate (player, gamedata.levelData [GameData.level].startPoint.position, Quaternion.identity);
	}


}
