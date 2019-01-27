using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSlot : MonoBehaviour {
	public GridArray inventory;

	public Item testItem;
	public Item testItem1;

	public float slotSize = 1;

	void OnEnable(){
		// inventory.CreateSlots();
		// AddItems();
	}

	// void CreateSlots(){
	// 	slots = new Slot[xSize, ySize];
		
	// 	for (int y = 0; y < ySize; y++){
	// 		for (int x = 0; x < xSize; x++){
	// 			slots[x, y] = new Slot();
	// 			slots[x, y].parent = transform;

	// 			float xOffset = ((xSize - 1) * slotSize) / 2;
	// 			float yOffset = ((ySize - 1) * slotSize) / 2;				

	// 			Vector2 offset = new Vector2(x * slotSize, y * slotSize);
	// 			Vector2 centerOffset = new Vector2(-xOffset, -yOffset);
				
	// 			slots[x, y].position = (Vector2)transform.position + offset + centerOffset;				
	// 		}
	// 	}
	// }

	// void OnDrawGizmosSelected(){
	// 	Vector3 size = Vector3.one * slotSize;
	// 	inventory.items.Clear();

	// 	inventory.CreateSlots();
		
	// 	for (int y = 0; y < inventory.slots.GetLength(1); y++){
	// 		for (int x = 0; x < inventory.slots.GetLength(0); x++){
	// 			VisualizeSlot(inventory.slots[x,y].position, size, new Color(0, 1, 1, 1));
	// 		}
	// 	}

	// 	AddItems();

	// 	foreach (var item in inventory.items){
	// 		Gizmos.color = new Color(1, 0, 0, .8f);
	// 		Gizmos.DrawCube(item.center, new Vector3(item.size.x, item.size.y, 1) * slotSize * .8f);
	// 	}
	// }

	// void AddItems() {
	// 	inventory.AddItem(testItem, new Vector2Int(0, 0));

	// 	// Item testItemitem = Item.CreateInstance<EquipmentHead>();
	// 	// testItemitem.size = new Vector2Int(1, 2);
	// 	// inventory.AddItem(testItemitem, new Vector2Int(0, 0));

	// 	// Item testItemitem1 = Item.CreateInstance<EquipmentHead>();
	// 	// testItemitem1.size = new Vector2Int(1, 2);
	// 	// inventory.AddItem(testItemitem1, new Vector2Int(1, 0));
	// }

	// void VisualizeSlot(Vector3 position, Vector3 size, Color color){
	// 	Color outlineColor = color;
		
	// 	Color slotColor = outlineColor;
	// 	slotColor.a = .5f;

	// 	Gizmos.color = slotColor;
	// 	Gizmos.DrawCube(position, size);

	// 	Gizmos.color = outlineColor;
	// 	Gizmos.DrawWireCube(position, size);
	// }
}
