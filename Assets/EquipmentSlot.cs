using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSlot : MonoBehaviour {

	public Slot[,] slots;

	public Item testItem;
	public Vector2Int testItemSize;

	public int xSize = 1;
	public int ySize = 1;

	public float slotSize = .5f;

	void OnEnable(){
		CreateSlots();
		PlaceItems();
	}

	void CreateSlots(){
		slots = new Slot[xSize, ySize];
		for (int y = 0; y < ySize; y++){
			for (int x = 0; x < xSize; x++){
				slots[x, y] = new Slot();
				slots[x, y].parent = transform;

				float xOffset = ((xSize - 1) * slotSize) / 2;
				float yOffset = ((ySize - 1) * slotSize) / 2;				

				Vector2 offset = new Vector3(x * slotSize, y * slotSize);
				Vector2 centerOffset = new Vector3(-xOffset, -yOffset);
				
				slots[x, y].position = (Vector2)transform.position + offset + centerOffset;

				slots[x, y].item = testItem;
				
			}
		}
	}

	void PlaceItems(){
		foreach(var slot in slots){
			Instantiate(slot.item.prefab, slot.position, Quaternion.identity, slot.parent);
		}
	}

	List<AvailablePosition> GetAvailableSlots(Vector2Int size){
		List<AvailablePosition> positions = new List<AvailablePosition>();
		
		for (int y = 0; y < ySize; y++){
			for (int x = 0; x < xSize; x++){

				int xMax = x + size.x - 1;
				int yMax = y + size.y - 1;

				if(yMax < ySize && xMax < xSize){

					AvailablePosition newPos = new AvailablePosition();					

					Vector2 pos = Vector2.zero;

					//Add minimum position
					pos += this.slots[x, y].position;
					//Add maximum position
					pos += this.slots[xMax, yMax].position;
					//Find point in the middle
					pos /= 2;

					List<Slot> slots = new List<Slot>();

					for (int j = y; j < yMax; y++){
						for (int i = x; i < xMax; i++){
							slots.Add(this.slots[i, j]);
						}
					}

					newPos.center = pos;
					newPos.slots = slots;								

					positions.Add(newPos);
				}
			}
		}

		return positions;
	}

	public void AddItem(Item item, Vector2Int position){
		if(position.x <= xSize && position.y <= ySize){
			slots[position.x, position.y].item = item;
		}
	}

	void OnDrawGizmosSelected(){
		Vector3 size = Vector3.one * slotSize;

		CreateSlots();
		
		for (int y = 0; y < slots.GetLength(1); y++){
			for (int x = 0; x < slots.GetLength(0); x++){
				VisualizeSlot(slots[x,y].position, size, new Color(0, 1, 1, 1));
			}
		}

		foreach (var slot in GetAvailableSlots(testItemSize)){
			Gizmos.color = Color.blue;
			Gizmos.DrawSphere(slot.center, slotSize / 2);
			
			Gizmos.color = new Color(0, 1, 0, .5f);
			Debug.Log(slot.center);
			Gizmos.DrawCube(slot.center, (slotSize * 0.95f) * new Vector3(testItemSize.x, 1, testItemSize.y));
		}

	}

	void VisualizeSlot(Vector3 position, Vector3 size, Color color){
		Color outlineColor = color;
		
		Color slotColor = outlineColor;
		slotColor.a = .5f;

		// Gizmos.color = slotColor;
		// Gizmos.DrawCube(position, size);

		Gizmos.color = outlineColor;
		Gizmos.DrawWireCube(position, size);
	}

	[System.Serializable]
	public struct Slot {
		public Transform parent;
		public Vector2 position;
		public Item item;
	}

	public struct AvailablePosition {
		public Vector2 center;
		public List<Slot> slots;
	}
}
