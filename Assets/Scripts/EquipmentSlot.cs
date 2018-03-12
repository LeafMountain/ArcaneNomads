using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSlot : MonoBehaviour {

	Slot[,] slots;
	List<ItemSlot> positions = new List<ItemSlot>();

	public Item testItem;
	public Item testItem1;
	
	public Vector2Int testItemSize;

	public int xSize = 1;
	public int ySize = 1;

	float slotSize = .5f;

	public void AddItem(Item item, Vector2Int position){
		List<ItemSlot> positions = GetAvailableSlots(item.size);

		if(positions.Count <= 0){
			return;
		}

		for (int i = 0; i < positions.Count; i++){
			if(positions[i].slots[0] == slots[position.x, position.y]){
				positions[i].AddItem(item);
				this.positions.Add(positions[i]);
				return;
			}
		}
	}

	public void RemoveItem(){

	}

	void OnEnable(){
		CreateSlots();
	}

	void CreateSlots(){
		slots = new Slot[xSize, ySize];
		
		for (int y = 0; y < ySize; y++){
			for (int x = 0; x < xSize; x++){
				slots[x, y] = new Slot();
				slots[x, y].parent = transform;

				float xOffset = ((xSize - 1) * slotSize) / 2;
				float yOffset = ((ySize - 1) * slotSize) / 2;				

				Vector2 offset = new Vector2(x * slotSize, y * slotSize);
				Vector2 centerOffset = new Vector2(-xOffset, -yOffset);
				
				slots[x, y].position = (Vector2)transform.position + offset + centerOffset;				
			}
		}
	}

	List<ItemSlot> GetAvailableSlots(Vector2Int size){
		List<ItemSlot> positions = new List<ItemSlot>();
		
		for (int y = 0; y < ySize; y++){
			for (int x = 0; x < xSize; x++){

				int xMax = x + size.x - 1;
				int yMax = y + size.y - 1;

				if(yMax < ySize && xMax < xSize){
					bool open = true;

					List<Slot> slots = new List<Slot>();
					
					//Check if any of the slots are occupied
					for (int j = y; j <= yMax; j++){
						for (int i = x; i <= xMax; i++){
							slots.Add(this.slots[i, j]);
						}
					}

					foreach (var item in slots)
					{
						if(item.occupied){
							open = false;
							break;
						}
					}

					if(open){
						ItemSlot newPos = new ItemSlot();					

						Vector2 pos = Vector2.zero;

						//Add minimum position
						pos += this.slots[x, y].position;
						//Add maximum position
						pos += this.slots[xMax, yMax].position;
						//Find point in the middle
						pos /= 2;

						newPos.center = pos;
						newPos.slots = slots;
						newPos.size = size;

						positions.Add(newPos);
					}					
				}
			}
		}

		return positions;
	}

	void OnDrawGizmos(){
		Vector3 size = Vector3.one * slotSize;
		positions.Clear();

		CreateSlots();
		
		for (int y = 0; y < slots.GetLength(1); y++){
			for (int x = 0; x < slots.GetLength(0); x++){
				VisualizeSlot(slots[x,y].position, size, new Color(0, 1, 1, 1));
			}
		}

		// AddItem(testItem, new Vector2Int(1, 1));
		AddItem(testItem1, new Vector2Int(0, 2));

		Item testItemitem = Item.CreateInstance<EquipmentHead>();
		testItemitem.size = new Vector2Int(2, 2);
		AddItem(testItemitem, new Vector2Int(0, 0));

		Item testItemitem1 = Item.CreateInstance<EquipmentHead>();
		testItemitem1.size = new Vector2Int(1, 2);
		AddItem(testItemitem1, new Vector2Int(2, 0));

		foreach (var item in this.positions){
			Gizmos.color = new Color(1, 0, 0, .8f);
			Gizmos.DrawCube(item.center, new Vector3(item.size.x, item.size.y, 1) * slotSize * .8f);
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
	public class Slot {
		public Transform parent;
		public Vector2 position;
		public bool occupied = false;
		public ItemSlot occupant;
	}

	public class ItemSlot {
		public Vector2 center;
		public List<Slot> slots;
		public Vector2Int size;
		public Item item;

		public void AddItem(Item item){
			this.item = item;

			for (int i = 0; i < slots.Count; i++){
				slots[i].occupied = true;
			}
		}

		public Item RemoveItem(){
			for (int i = 0; i < slots.Count; i++){
				slots[i].occupied = false;
			}

			return item;
		}
	}
}
