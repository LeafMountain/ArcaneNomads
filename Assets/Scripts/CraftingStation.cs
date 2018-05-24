using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingStation : MonoBehaviour {

	public IntVariable playerScrap;
	public Cookbook playerCookbook;
	public Inventory playerInventory;

	public bool Craft (Recipe recipe) {
		if (playerScrap.Value < recipe.scrapCost) {
			return false;
		}

		playerScrap.ApplyChange (-recipe.scrapCost);
		playerInventory.AddItem (recipe.craftedItem);

		return true;
	}
}