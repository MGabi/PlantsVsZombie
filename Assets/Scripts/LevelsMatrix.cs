using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsMatrix : MonoBehaviour {

	// col 1 : time until next zombie
	// col 2 : position
	public static int[][] levelOne = new int[5][]{
		new int[]{ 1, 0 },
		new int[]{ 3, 1 },
		new int[]{ 3, 2 },
		new int[]{ 3, 3 },
		new int[]{ 3, 4 }
	};

	public static int[][] levelTwo = new int[5][]{
		new int[]{ 1, 0 },
		new int[]{ 3, 1 },
		new int[]{ 3, 2 },
		new int[]{ 3, 3 },
		new int[]{ 3, 4 }
	};

	public static int[][] levelThree = new int[5][]{
		new int[]{ 1, 0 },
		new int[]{ 3, 1 },
		new int[]{ 3, 2 },
		new int[]{ 3, 3 },
		new int[]{ 3, 4 }
	};

	public static int[][] levelFour = new int[5][]{
		new int[]{ 1, 0 },
		new int[]{ 3, 1 },
		new int[]{ 3, 2 },
		new int[]{ 3, 3 },
		new int[]{ 3, 4 }
	};

	public static int[][] levelFive = new int[5][]{
		new int[]{ 1, 0 },
		new int[]{ 3, 1 },
		new int[]{ 3, 2 },
		new int[]{ 3, 3 },
		new int[]{ 3, 4 }
	};
}
