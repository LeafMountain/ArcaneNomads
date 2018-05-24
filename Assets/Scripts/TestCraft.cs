using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCraft : MonoBehaviour {

	public Recipe recipe;

	public void Trigger () {
		GetComponent<CraftingStation> ().Craft (recipe);
	}
}