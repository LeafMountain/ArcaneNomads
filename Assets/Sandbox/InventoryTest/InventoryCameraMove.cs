﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCameraMove {

	private InventoryManager inventoryManager;
	
	private GameObject mainCamera;
	private GameObject player;

	private Vector3 camUpPosition;
	private Quaternion camUpRotation;
	private Vector3 camDownPosition;
	private Quaternion camDownRotation;
	
	private bool isDown;
	private bool moving;
	private float startTime;
	private float journeyLength;

	private InventoryCameraMove(){}
	public InventoryCameraMove(GameObject mainCamera, GameObject player, InventoryManager inventoryManager){

		this.mainCamera = mainCamera;
		this.player = player;
		this.inventoryManager = inventoryManager;
		moving = false;

	
	}
	public void MoveCamera(bool move){

		if(!moving && move){
			moving = true;
			UpdateCamDownData();
			if(!isDown){
			
				PlayOpenInventorySound();
				UpdateCamUpData();
				Player.Instance.ToggleInput(false);
				mainCamera.GetComponent<SimpleCamera>().enabled = false;
				
				}
				else
				{
					mainCamera.GetComponent<Camera>().orthographic = true;
					inventoryManager.inventoryPanel.SetActive(false);
					PlayCloseInventorySound();
					
				}
			
			startTime = Time.time;
			journeyLength = Vector3.Distance(camUpPosition, camDownPosition);
			
		
			

		}
		if(move){
			float distCovered = (Time.time - startTime) * 100f;
			float fracJourney = distCovered/journeyLength;

			if(!isDown){

				mainCamera.transform.position = Vector3.Slerp(camUpPosition, camDownPosition, fracJourney);
				mainCamera.transform.rotation = Quaternion.Slerp(camUpRotation, camDownRotation, fracJourney);
				
			}
			else
			{
				mainCamera.transform.position = Vector3.Slerp(camDownPosition, camUpPosition, fracJourney);
				mainCamera.transform.rotation = Quaternion.Slerp(camDownRotation, camUpRotation, fracJourney);
			}

			if(fracJourney > 0.99f)
			{
				

				moving = false;
				inventoryManager.MoveCamera = false;
				isDown = !isDown;
				if(isDown){
					inventoryManager.inventoryPanel.SetActive(true);
					
				}
				else{
						Player.Instance.ToggleInput(true);
						mainCamera.GetComponent<SimpleCamera>().enabled = true;
						
				}

			}
			if(!isDown && fracJourney > 0.4f && moving){
				mainCamera.GetComponent<Camera>().orthographic = false;
				
			}
		
		}
		
	
	}


	private void UpdateCamUpData(){

		camUpPosition = mainCamera.transform.position;
		camUpRotation = mainCamera.transform.rotation;

	}
	private void UpdateCamDownData(){

		camDownPosition = player.GetComponentInChildren<Renderer>().bounds.center;

		camDownRotation = player.transform.rotation;

		 camDownPosition -= player.transform.forward * 1.0f ;

		

	}
	private void PlayOpenInventorySound(){


		inventoryManager.InventoryAS.clip = inventoryManager.InventorySFXClips[0];
		inventoryManager.InventoryAS.Play();
		
			

	}
	private void PlayCloseInventorySound(){

		inventoryManager.InventoryAS.clip = inventoryManager.InventorySFXClips[1];
		inventoryManager.InventoryAS.Play();

	}
}
