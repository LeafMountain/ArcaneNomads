using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Crafting/Recipe")]
public class Recipe : ScriptableObject {
	public int scrapCost;
	public Item craftedItem;
}