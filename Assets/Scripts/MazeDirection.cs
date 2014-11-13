using UnityEngine;

public enum MazeDirection {
	North,
	South,
	West,
	East
}


public static class MazeDirections {

	public const int Count = 4;

	public static MazeDirection RandomValue {
		get {
			return (MazeDirection)Random.Range(0,Count);
		}
	}

	private static IntVector2[] vectors = {
		new IntVector2(0,1),
		new IntVector2(1,0),
		new IntVector2(0,-1),
		new IntVector2(-1,0)
	};


}
