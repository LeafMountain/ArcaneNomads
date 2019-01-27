using System.Collections;
using System.Collections.Generic;

//Should be a 2D array with a limited space
[System.Serializable]
public class GridArray {

	public Slot[,] slots;
	public List<ItemSlot> items = new List<ItemSlot>();

	public GridPosition size = new GridPosition(0, 0);

	public bool AddItem(GridElement item, GridPosition position){
		List<ItemSlot> positions = GetAvailableSlots(item.size);

		if(positions.Count <= 0){
			return false;
		}

		for (int i = 0; i < positions.Count; i++){
			if(positions[i].slots[0] == slots[position.x, position.y]){
				positions[i].AddItem(item);
				items.Add(positions[i]);
				return true;
			}
		}

		return false;
	}

	public void RemoveItem(){
		
	}

	public List<GridElement> GetItems(){
		List<GridElement> items = new List<GridElement>();

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
				slots[x, y].position = new GridPosition(x, y);
			}
		}
	}

	List<ItemSlot> GetAvailableSlots(GridPosition size){
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

						// newPos.center = FindCenter(this.slots[x, y], this.slots[xMax, yMax]);
						newPos.slots = slots;
						newPos.size = size;

						positions.Add(newPos);
					}					
				}
			}
		}

		return positions;
	}

	// Position FindCenter(Slot minSlot, Slot maxSlot){
	// 	Vector2 pos = Vector2.zero;
		
	// 	//Add minimum position
	// 	pos += minSlot.position;
	// 	//Add maximum position
	// 	pos += maxSlot.position;
	// 	//Find point in the middle
	// 	pos /= 2;

	// 	return pos;
	// }

	// List<Slot> FindSlotsWithingArea(Vector2Int minSlot, Vector2Int maxSlot){
	// 	// for (int j = y; j <= yMax; j++){
	// 	// 	for (int i = x; i <= xMax; i++){
	// 	// 		slots.Add(this.slots[i, j]);
	// 	// 	}
	// 	// }

	// 	return null;
	// }

	//A space in the inventory consisting of an area
	[System.Serializable]
	public class Slot {
		// public Transform parent;
		public GridPosition position;
		public bool occupied = false;
		public ItemSlot occupant;
	}

	//A holder for an item? Maybe?
	public class ItemSlot {
		// public Vector2 center;
		public List<Slot> slots;
		public GridPosition size;
		public GridElement item;

		public void AddItem(GridElement item){
			this.item = item;

			for (int i = 0; i < slots.Count; i++){
				slots[i].occupied = true;
			}
		}

		public GridElement RemoveItem(){
			for (int i = 0; i < slots.Count; i++){
				slots[i].occupied = false;
			}

			return item;
		}
	}
}

[System.Serializable]
public class GridElement {
	public GridPosition size;
	public object item;
}

[System.Serializable]
	public class GridPosition {
		public int x { get; set; }
		public int y { get; set; }

		public GridPosition(int x, int y){
			this.x = x;
			this.y = y;
		}
	}
