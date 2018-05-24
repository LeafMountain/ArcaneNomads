using System.Collections;
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
				UpdateCamUpData();
				}
				else
				{
					if(isDown)inventoryManager.inventoryPanel.SetActive(false);
				}
			
			startTime = Time.time;
			journeyLength = Vector3.Distance(camUpPosition, camDownPosition);
			
		
			

		}
		if(move){
			float distCovered = (Time.time - startTime) * 100f;
			float fracJourney = distCovered/journeyLength;

			if(!isDown){

				mainCamera.transform.position = Vector3.Slerp(camUpPosition, camDownPosition, fracJourney);
			
			}
			else
			{
				mainCamera.transform.position = Vector3.Slerp(camDownPosition, camUpPosition, fracJourney);
			}

			if(fracJourney > 0.99f)
			{
				

				moving = false;
				inventoryManager.MoveCamera = false;
				isDown = !isDown;
				if(isDown)inventoryManager.inventoryPanel.SetActive(true);

			}
		
		}
		
	
	}


	private void UpdateCamUpData(){

		camUpPosition = mainCamera.transform.position;
		camUpRotation = mainCamera.transform.rotation;

	}
	private void UpdateCamDownData(){

		camDownPosition = new Vector3(
			(player.transform.position.x -0.1f), 1.17f, (player.transform.position.z -0.86f));

		camDownRotation = player.transform.rotation;

	}
}
