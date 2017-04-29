using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {

	// All moving object have to follow the time limit
	private float timeElapsed = 0f;
	private float timeLimit = 0.15f;

	// All moving objects need to have a boundary on where they can move
	private boundary levelBounds;

	// References
	private Rigidbody2D rb2d;
	private GameData gameData;

	enum Direction {up, right, down, left}
	Direction myDirection;

	// Use this for initialization
	public void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		gameData = GameObject.FindGameObjectWithTag ("GameData").GetComponent<GameData> ();
		if (gameData == null) {
			Debug.Log ("error in finding GameData");
		}

	}
		
	
	// Update is called once per frame
	void Update () {
		
	}

	// Moves based on the rigidbody. It can only move when it is been 2 seconds
	public void movement(){
		timeElapsed += Time.deltaTime;
		if (Input.GetKeyDown ("w") && timeElapsed >= timeLimit && validMovement(1)) {
			Debug.Log ("go up");
			GameData.moves (1);
			rb2d.MovePosition (new Vector2 (rb2d.position.x, rb2d.position.y + 1));
			timeElapsed = 0;
		} else if (Input.GetKeyDown ("a") && timeElapsed >= timeLimit && validMovement(4)) {
			Debug.Log ("go left");
			GameData.moves (1);
			rb2d.MovePosition (new Vector2 (rb2d.position.x - 1, rb2d.position.y));
			timeElapsed = 0;
		} else if (Input.GetKeyDown ("s") && timeElapsed >= timeLimit && validMovement(3)) {
			Debug.Log ("go down");
			GameData.moves (1);
			rb2d.MovePosition (new Vector2 (rb2d.position.x, rb2d.position.y - 1));
			timeElapsed = 0;
		} else if (Input.GetKeyDown ("d") && timeElapsed >= timeLimit && validMovement(2)) {
			Debug.Log ("go right");
			GameData.moves (1);
			rb2d.MovePosition (new Vector2 (rb2d.position.x + 1, rb2d.position.y ));
			timeElapsed = 0;
		}
	}

	// Checks if the movement is valid
	// 1 up, 2 right, 3 down, 4 left
	public bool validMovement(int i){
		// The curPos x and y should correspond to the grid values, with 0,0 being at Vector2(0,0)
		Vector2 curPos = gameObject.transform.position;
		int xBoundary = gameData.levelData [GameData.level].levelBounds.width;
		int yBoundary = gameData.levelData [GameData.level].levelBounds.height;
		if (i == 1) {
			// Minus one because the grid starts at 0 index
			if (curPos.y + 1 > yBoundary - 1) {
				Debug.Log ("error");
				return false;
			}
			return true;
		} else if (i == 2) {
			// Minus one because the grid starts at 0 index
			if (curPos.x + 1 > xBoundary - 1) {
				Debug.Log ("error");
				return false;
			}
			return true;
		} else if (i == 3) {
			if (curPos.y - 1 < 0) {
				Debug.Log ("error");
				return false;
			}
			return true;
		} else if (i == 4) {
			if (curPos.x -1  < 0) {
				Debug.Log ("error");
				return false;
			}
			return true;
		}
		Debug.Log ("error in valid movement");
		return false;

	}

}
