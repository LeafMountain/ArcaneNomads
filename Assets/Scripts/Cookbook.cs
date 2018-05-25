using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Crafting/Cookbook")]
public class Cookbook : ScriptableObject {

	[SerializeField] private List<Recipe> recipes = new List<Recipe> ();

	public List<Recipe> GetRecipes () {
		return recipes;
	}

	public bool AddRecipes (Recipe recipe) {
		if (!recipes.Contains (recipe)) {
			recipes.Add (recipe);
			return true;
		}

		return false;
	}

	public bool RemoveRecipes (Recipe recipe) {
		if (recipes.Contains (recipe)) {
			recipes.Remove (recipe);
			return true;
		}

		return false;
	}
}