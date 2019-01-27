using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class StructureGeneratorSystem : ComponentSystem {
	struct Data {
		public StructureGeneratorComponent Structure;
		public Transform Transform;
	}

    protected override void OnUpdate() {
		foreach(Data Entity in GetEntities<Data>()) {
			// Check if something needs to be spawned
			if(Entity.Structure.Tiles.Length > 0 /* Temp */ && Entity.Structure.SpawnedTiles.Count < 1) {
				Vector3Int Area = Entity.Structure.Area;

				bool UseRandom = Entity.Structure.RandomizeArea;
				int MaxX = !UseRandom ? Area.x : Random.Range(Area.x, Entity.Structure.AreaMax.x);
				int MaxY = !UseRandom ? Area.y : Random.Range(Area.y, Entity.Structure.AreaMax.y);
				int MaxZ = !UseRandom ? Area.z : Random.Range(Area.z, Entity.Structure.AreaMax.z);

				for(int z = 0; z < MaxZ; z++)
					for(int y = 0; y < MaxY; y++)
						for(int x = 0; x < MaxX; x++)
						{
							GameObject RandomTile = Entity.Structure.Tiles[Random.Range(0, Entity.Structure.Tiles.Length)];
							Vector3 TileSize = Entity.Structure.TileSize;
							Vector3 TotalSize = new Vector3(TileSize.x * Entity.Structure.Area.x, TileSize.y * Entity.Structure.Area.y, TileSize.z * Entity.Structure.Area.z);
							Vector3 Center = Entity.Transform.position;
							Vector3 BottomLeft = Center - TotalSize / 2;
							Vector3 OffsetFromStart = new Vector3(x * TileSize.x, y * TileSize.y, z * TileSize.z);


							// CenterOffset -= (Vector3)Entity.Structure.Area / 2;

							// Position to spawn at
							Vector3 SpawnPosition = BottomLeft + OffsetFromStart + TileSize / 2;

							// SpawnPosition += Entity.Structure.transform.position;
							// SpawnPosition -= TileSize / 2;
							// SpawnPosition += Entity.Transform.position;

							// Spawn a tile
							GameObject NewTile = GameObject.Instantiate(RandomTile, SpawnPosition, Quaternion.identity, Entity.Structure.transform);
							
							// Store spawned tile
							Entity.Structure.SpawnedTiles.Add(NewTile);
						}
			}
		}
    }
}
