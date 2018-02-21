using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryModify : MonoBehaviour {

	public Inventory inventory;

	// public void Add(Equipment item){
	// 	//Check if inventory is full
	// 	inventory.AddItem(item);
	// }

	// public void Remove(Equipment item){
	// 	inventory.RemoveItem(item);
	// }

	public Equipment Drop(Equipment item){
		return item;
	}
}
