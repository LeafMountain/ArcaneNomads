using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToonShaderController : MonoBehaviour {

	Material material;

	void Start(){
		material = GetComponent<MeshRenderer>().material;
	}

	public void SetOutline(float width){
		material.SetFloat("_OutlineWidth", width);
	}

	public void SetOutlineColor(Color color){
		material.SetColor("_OutlineColor", color);
	}
}
