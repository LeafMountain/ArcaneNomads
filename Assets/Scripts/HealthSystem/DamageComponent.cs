using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using System;

[Serializable]
public struct ECSDamageComponent : IComponentData
{
	int DamageAmount;
}

public class DamageComponent : ComponentDataProxy<ECSDamageComponent> {}
