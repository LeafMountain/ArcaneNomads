using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class PlayerMoveSystem : ComponentSystem {

	public struct Data
	{
		public PlayerInput Input;
		public SuperCharacterController characterController;
	}

    protected override void OnUpdate()
    {
        foreach (var entity in GetEntities<Data>())
		{
			entity.characterController.Move(entity.Input.Move);
		}
    }
}
