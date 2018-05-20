using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EquipmentMenu : MonoBehaviour {

	public GameObject buttonPrefab;

	private List<GameObject> buttons = new List<GameObject>();

	void Start () {
		DestroyButtons();
		CreateButtons(3);
	}

	public void PopulateMenu () {

	}

	void CreateButtons (int amount) {
		for (int i = 0; i < amount; i++) {
			buttons.Add(Instantiate(buttonPrefab, Vector3.zero, Quaternion.identity, transform));
		}
	}

	void DestroyButtons () {
		for (int i = 0; i < buttons.Count; i++) {
			Destroy(buttons[i]);
		}
	}
}

public class ButtonSettins {
	public string text;
	public UnityAction action;
}
