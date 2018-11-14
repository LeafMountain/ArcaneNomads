using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class DamageSystem : ComponentSystem
{
	struct Data
	{
		DamageComponent[] DamageComponents;
	}

    protected override void OnUpdate()
    {
        foreach(var Entity in GetEntities<Data>())
		{
			
		}
    }
}
