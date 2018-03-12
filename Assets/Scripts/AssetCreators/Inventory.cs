using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject {

	public List<Item> items = new List<Item>();

	public void Add(Item item){
		items.Add(item);
	}

	public Item Remove(Item item) {
		Item removedItem = null;

		if(items.Contains(item)){
			removedItem = RemoveAt(items.IndexOf(item));
		}

		return removedItem;
	}

	public Item RemoveAt(int index){
		Item removedItem = null;

		if(items.Count <= index){
			removedItem = items[index];
			items.RemoveAt(index);
		}

		return removedItem;
	}
}
