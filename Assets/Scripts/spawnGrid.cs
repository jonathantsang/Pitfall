using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGrid : MonoBehaviour {

	public GameObject tile;

	private boundary bounds;
	private Vector2 curPos;
	private Transform boardHolder;
	public List<Vector3> gridPositions = new List<Vector3> ();

	private int wid = 5;
	private int hei = 5;

	[System.Serializable]
	public class boundary{
		public int width;
		public int height;

		public boundary(int w, int h){
			width = w;
			height = h;
		}
	}

	// Use this for initialization
	void Start () {
		bounds = new boundary (wid, hei);
		curPos = new Vector2(-2, -2);
		generateGrid ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InitialiseList()
	{
		gridPositions.Clear ();

		for (int x = 0; x < bounds.height; x++) 
		{
			for (int y = 1; y < bounds.width; y++) 
			{
				gridPositions.Add (new Vector3 (x, y, 0f));
			}
		}
	}

	void generateGrid(){
		boardHolder = new GameObject ("Board").transform;
		for (int i = 0; i < bounds.height; i++) {
			for (int j = 0; j < bounds.width; j++) {
				GameObject instance = Instantiate (tile, new Vector2(curPos.x + j, curPos.y + i), Quaternion.identity);
				instance.transform.SetParent (boardHolder);
				gridPositions.Add (new Vector3 (i, j, 0f));
			}
		}
	}
}
