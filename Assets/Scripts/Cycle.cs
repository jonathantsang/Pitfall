using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cycle {

	// min is inclusive, max is exclusive
	public int minNum;
	public int maxNum;
	public int increment;

	public int currentNum;

	// Basic constructor
	public Cycle(){
		minNum = 0;
		minNum = 4;
		increment = 1;
		currentNum = minNum;
	}

	public Cycle(int start, int end, int increases){
		minNum = start;
		maxNum = end;
		increment = increases;
		currentNum = minNum;
	}

	public Cycle(int start, int end, int increases, int startNum){
		minNum = start;
		maxNum = end;
		increment = increases;
		currentNum = startNum;
	}
}
