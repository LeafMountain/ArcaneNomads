using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSlot : MonoBehaviour {

	public Slot[,] slots;
	Transform [,] positions;

	public Item testItem;

	public int xSize = 1;
	public int ySize = 1;

	public float slotSize = .5f;

	void Enable(){
		positions = new Transform[xSize,ySize];
	}

	void CreateSlots(){
		slots = new Slot[xSize, ySize];
		for (int y = 0; y < ySize; y++){
			for (int x = 0; x < xSize; x++){
				slots[x, y] = new Slot();
				slots[x, y].parent = transform;

				float xOffset = ((xSize - 1) * slotSize) / 2;
				float yOffset = ((ySize - 1) * slotSize) / 2;				

				Vector3 offset = new Vector3(x * slotSize, 0, y * slotSize);
				Vector3 centerOffset = new Vector3(-xOffset, 0, -yOffset);
				
				slots[x, y].position = transform.position + offset + centerOffset;

				slots[x, y].item = testItem;
				
			}
		}
	}

	void OnDrawGizmos(){
		Vector3 size = Vector3.one * slotSize;

		CreateSlots();
		
		for (int y = 0; y < slots.GetLength(1); y++){
			for (int x = 0; x < slots.GetLength(0); x++){
				VisualizeSlot(slots[x,y].position, size, new Color(0, 1, .2f, 1), slots[x,y].item);
			}
		}
	}

	void VisualizeSlot(Vector3 position, Vector3 size, Color color, Item item){
		Color outlineColor = color;
		
		Color slotColor = outlineColor;
		slotColor.a = .5f;

		Gizmos.color = slotColor;
		Gizmos.DrawCube(position, size);

		Gizmos.color = outlineColor;
		Gizmos.DrawWireCube(position, size);

		if(item != null){
			Gizmos.color = outlineColor;
			Gizmos.DrawMesh(item.prefab.GetComponentInChildren<MeshFilter>().sharedMesh, position, transform.rotation, transform.lossyScale * slotSize);
		}
	}

	[System.Serializable]
	public struct Slot {
		public Transform parent;
		public Vector3 position;
		public Item item;
	}
}
