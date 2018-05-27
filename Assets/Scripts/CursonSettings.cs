using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursonSettings : MonoBehaviour
{

	public bool hideCursor = true;
	public bool lockCurson = true;

	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = !hideCursor;
	}

}