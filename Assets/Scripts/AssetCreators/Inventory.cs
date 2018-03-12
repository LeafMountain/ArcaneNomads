using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject {

	public Slot[,] slots;
	public List<ItemSlot> items = new List<ItemSlot>();

	public Vector2Int size = Vector2Int.one;

	public void AddItem(Item item, Vector2Int position){
		List<ItemSlot> positions = GetAvailableSlots(item.size);

		if(positions.Count <= 0){
			return;
		}

		for (int i = 0; i < positions.Count; i++){
			if(positions[i].slots[0] == slots[position.x, position.y]){
				positions[i].AddItem(item);
				items.Add(positions[i]);
				return;
			}
		}
	}

	public void RemoveItem(){

	}

	public List<Item> GetItems(){
		List<Item> items = new List<Item>();

		foreach(var item in this.items){
			items.Add(item.item);
		}

		return items;
	}

	public List<ItemSlot> GetItemSlots(){
		return items;
	}

	void CreateSlots(){
		slots = new Slot[size.x, size.y];
		
		for (int y = 0; y < size.y; y++){
			for (int x = 0; x < size.x; x++){
				slots[x, y] = new Slot();
				slots[x, y].position = new Vector2Int(x, y);
			}
		}
	}

	List<ItemSlot> GetAvailableSlots(Vector2Int size){
		List<ItemSlot> positions = new List<ItemSlot>();
		
		for (int y = 0; y < size.y; y++){
			for (int x = 0; x < size.x; x++){

				int xMax = x + size.x - 1;
				int yMax = y + size.y - 1;

				if(yMax < size.y && xMax < size.x){
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
