using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Inventory")]
public class Inventory : ScriptableObject {

	public int inventorySize;
	public List<Item> items = new List<Item>();

	public bool Full {
		get {
			return items.Count >= inventorySize;
		}
	}

	public void AddItem (Item item) {
		if(Full){
			Debug.Log("Inventory full.");
			return;
		}

		items.Add(item);
	}

	public Item RemoveItem (Item item) {
		int itemIndex = GetNextItemIndex(item);

		if(itemIndex >=	0){
			Item removedItem = items[itemIndex];			
			items.RemoveAt(itemIndex);
			return removedItem;
		}

		return null;
	}

	public void RemoveItem (string name) {
		Item item = items.Find(aitem => aitem.name == name);
		RemoveItem(item);
	}

	int GetNextItemIndex (Item item) {
		for (int i = 0; i < items.Count; i++) {
			if(items[i]) {
				if (items[i] == item){
					return i;
				}
			}
		}

		return -1;
	}
}
