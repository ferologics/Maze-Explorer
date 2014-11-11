using UnityEngine;
using System.Collections;

public class Maze : MonoBehaviour {

	// public int sizeX, sizeZ; used IntVector2 instead
	public MazeCell cellPrefab;
	public float generationStepDelay;
	public IntVector2 size;

	private MazeCell[,] cells;

	public IEnumerator Generate() {
		WaitForSeconds dealy = new WaitForSeconds (generationStepDelay);
		cells = new MazeCell[size.x, size.z];
		for (int x = 0; x < size.x; x++) {
			for (int z = 0; z < size.z; z++) {
				yield return dealy;
				CreateCell(new IntVector2(x, z));
			}
		}
	}

	private void CreateCell(IntVector2 coordinates) {
		MazeCell newCell = Instantiate (cellPrefab) as MazeCell;
		cells[coordinates.x, coordinates.z] = newCell;
		newCell.coordinates = coordinates;
		newCell.name = "Maze Cell" + coordinates.x + ", " + coordinates.z;
		newCell.transform.parent = transform;
		newCell.transform.localPosition = new Vector3(x - sizeX * 0.5f + 0.5f, 0f, z - sizeZ * 0.5f + 0.5f);
	}
}
