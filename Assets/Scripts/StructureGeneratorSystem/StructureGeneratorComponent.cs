using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureGeneratorComponent : MonoBehaviour {

	// The tiles to pick from
	public GameObject[] Tiles;
	// Number of tiles to spawn
	public Vector3 TileSize = Vector3.one;

	public bool RandomizeArea = false;
	public Vector3Int Area = Vector3Int.one;
	public Vector3Int AreaMax = Vector3Int.one;
	public bool RandomizeRotation;
	public bool RandomizeBy90Degrees = true;
	// Keep track of spawned tiles
	[HideInInspector]
	public List<GameObject> SpawnedTiles;

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.white;
		for(int z = 0; z < Area.z; z++)
			for(int y = 0; y < Area.y; y++)
				for(int x = 0; x < Area.x; x++)
				{
					Vector3 DrawPosition = new Vector3(x * TileSize.x, y * TileSize.y + TileSize.y / 2, z * TileSize.z);
					Gizmos.DrawWireCube(DrawPosition, TileSize);
				}
		
		// The size of the entire structure
		Vector3 TotalArea = new Vector3(Area.x * TileSize.x, Area.y * TileSize.y, Area.z * TileSize.z);
		Vector3 Offset = new Vector3(0, TileSize.y / 2, 0);

		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube((transform.position - TileSize / 2) + TotalArea / 2 + Offset, TotalArea);
	}
}